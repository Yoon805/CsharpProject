using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    internal class UserFunction
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
                    // 기호가 나왔을 시 저장되어있던 숫자를 mathlist에 저장
                    case '(':
                    case '*':
                    case '/':
                    case '^':
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
                        //제곱 연산자는 단항 연산자로 다른 연산자와 다르게 앞에 들어가므로
                        //따로 처리하여 연산 한뒤 반환해준다.


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
    }
}