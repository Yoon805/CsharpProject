using System;
using System.Collections.Generic;
using System.Text;


namespace CalculatorApp
{
    /*class calcText {
        private StringBuilder userInput = new StringBuilder();

        public StringBuilder UserInput { get => userInput; set => userInput = value; }
    }*/

    internal class UserFunction //수식 계산용 함수들
    {
        public List<String> CalStackUse(string temp)//후위표기법으로 변환
        {
            String numbersSaveTemp = "";//숫자 임시 저장
            List<String> mathList = new List<String>();//전체 식 저장
            Stack<string> expsStack = new Stack<string>();//기호 임시 저장

            for (int i = 0; i < temp.Length; i++)
            {
                switch (temp[i])
                {
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '.':
                    case '-':
                        numbersSaveTemp += temp[i].ToString();
                        break;
                    case '(':
                    case '*':
                    case '/':
                    case '^':
                        // 기호가 나왔을 시 저장되어있던 숫자를 mathlist에 저장
                        if (numbersSaveTemp.Length != 0)
                        {
                            mathList.Add(numbersSaveTemp);
                            numbersSaveTemp = "";
                        }
                        expsStack.Push(temp[i].ToString());
                        break;
                    case '+':
                    case '－'://구분을 위해 특수문자로 사용
                        if (numbersSaveTemp.Length != 0)
                        {
                            mathList.Add(numbersSaveTemp);
                            numbersSaveTemp = "";
                        }
                        while (expsStack.Count > 0)
                        {
                            if (expsStack.Peek().Equals("(")) { break; }
                            mathList.Add(expsStack.Pop().ToString());
                        }

                        expsStack.Push(temp[i].ToString());
                        break;
                    case ')':
                        if (numbersSaveTemp.Length != 0)
                        {
                            mathList.Add(numbersSaveTemp);
                            numbersSaveTemp = "";
                        }
                        while (expsStack.Count > 0)
                        {
                            if (expsStack.Peek().Equals("("))
                            {
                                expsStack.Pop();
                                break;
                            }
                            mathList.Add(expsStack.Pop().ToString());
                        }
                        break;
                    case '√':
                        if (numbersSaveTemp.Length != 0)
                        {
                            mathList.Add(numbersSaveTemp);
                            numbersSaveTemp = "";
                        }
                        //제곱근 연산자는 단항 연산자로 다른 연산자와 다르게 앞에 들어가므로
                        //제곱근 안을 따로 처리하여 연산 한뒤 반환해준다.
                        string rootString = "(";
                        int bracketNumCheck = 1;
                        int j = i + 2;
                        while (bracketNumCheck > 0)
                        {
                            if (temp[j].Equals('('))
                            {
                                bracketNumCheck++;
                                rootString += temp[j];
                            }
                            else if (temp[j].Equals(')') && bracketNumCheck != 0)
                            {
                                bracketNumCheck--;
                                rootString += temp[j];
                            }
                            else
                            {
                                rootString += temp[j];
                            }
                            j++;
                        }
                        List<String> postModification = CalStackUse(rootString);
                        i = j; // 미리 계산한 갯수만큼 들어갈 수  변경
                        string result = Math.Sqrt(CalPostModification(postModification)).ToString("F3");
                        for (int k = i; k < temp.Length; k++)
                        {
                            result += temp[k];
                        }
                        temp = result; // 구한 값을 맨 앞으로 넣어서 다시 for문 반복
                        i = -1; // 바로 다음 시도에서 i++이 실행되므로 -1부터 시작
                        break;
                    case 'E':
                        // 지수표기법에 의해 E가 포함된 경우 처리
                        string exponentString = "*10^(";
                        j = i + 1;
                        exponentString = (NumberCheck(temp, temp.Length - j) == 5) ? exponentString + "-" : exponentString;
                        j++;

                        while (temp.Length - j > 0 && NumberCheck(temp, temp.Length - j) == 0)
                        {
                            exponentString += temp[j];
                            j++;
                        }
                        exponentString += ")";
                        i = j;
                        for (int k = i; k < temp.Length; k++)
                        {
                            exponentString += temp[k];
                        }
                        temp = exponentString; // 구한 값을 맨 앞으로 넣어서 다시 for문 반복
                        i = -1; // 바로 다음 시도에서 i++이 실행되므로 -1부터 시작
                        break;
                }

            }
            if (numbersSaveTemp != "")
            {
                mathList.Add(numbersSaveTemp);//맨 마지막 숫자 저장
            }

            while (expsStack.Count > 0) // 남아있는 연산자 저장
            {
                mathList.Add(expsStack.Pop().ToString());
            }
            return mathList; // 저장된 후위수식 return
        }

        public double CalPostModification(List<String> PostMod)//후위수식을 받아 계산하기
        {
            Stack<double> numberStack = new Stack<double>();//숫자 임시 저장, 소수계산을 위해 double로 치환 저장
            double result;
            for (int i = 0; i < PostMod.Count; i++)
            {
                switch (PostMod[i])
                {
                    case "+":
                        result = numberStack.Pop() + numberStack.Pop();
                        numberStack.Push(result);
                        break;
                    case "－":
                        result = 0 - numberStack.Pop() + numberStack.Pop();
                        numberStack.Push(result);
                        break;
                    case "*":
                        result = numberStack.Pop() * numberStack.Pop();
                        numberStack.Push(result);
                        break;
                    case "/":
                        result = 1 / numberStack.Pop() * numberStack.Pop();
                        numberStack.Push(result);
                        break;
                    case "^":
                        double num1 = numberStack.Pop();
                        result = Math.Pow(numberStack.Pop(), num1);
                        numberStack.Push(result);
                        break;
                    default: //숫자일시 저장
                        numberStack.Push(Double.Parse(PostMod[i]));
                        break;
                }
            }
            return numberStack.Pop();
        }

        
        public int NumberCheck(string screenText, int number)// 뒤에서 n번째로 입력한 숫자 체크
        {
            switch (screenText[screenText.Length - number])
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    return 0;
                case '.':
                    return 1;
                case '-'://숫자로 받을 값들 0~9, . , -
                    return 2;
                case '(':
                    return 3;
                case ')':
                    return 4;
                case '－':
                    return 5;
                case '√':
                    return 7;
                default:// 연산자
                    return 6;
            }
        }


        public string BracketInsert(string screenText, string nowOrNot)// bracket 알맞게 입력하기
        {
            int bracketNumCheck = 0;
            for (int i = 0; i < screenText.Length; i++)
            {
                if (screenText[i].Equals('('))
                {
                    bracketNumCheck++;
                }
                else if (screenText[i].Equals(')') && bracketNumCheck != 0)
                {
                    bracketNumCheck--;
                }
            }
            if (nowOrNot.Equals("cal"))//중간계산시
            {
                string midResult = screenText;
                for (int i = 0; i < bracketNumCheck; i++)
                {
                    midResult += ')';
                }
                return midResult;
            }
            else//값 입력시
            {
                if (screenText.Length == 0)
                {
                    screenText += "(";
                }
                else if (!(NumberCheck(screenText, 1) == 3) && bracketNumCheck != 0)
                {
                    screenText += ")";
                }
                else if ((NumberCheck(screenText, 1) == 4 && bracketNumCheck == 0) || NumberCheck(screenText, 1) == 0)
                {
                    screenText += "*(";
                }
                else
                {
                    screenText += "(";
                }
            }
            return screenText;
        }
    }
}