using System;
using System.Text;


namespace CalculatorApp
{
    internal class ClickFunc
    {

        string inputBtnName;
        string resultToScreen;


        public ClickFunc(string inputBtnName, string screenExit)
        {
            this.inputBtnName = inputBtnName;
            this.resultToScreen = screenExit;
        }

        public ClickFunc()
        {
        }

        public string OpBtnClikInsert()
        {
            // 수식 기호 버튼들 입력시 resultScreen에 현재식 내용 보여주고
            // 최근수식 및 결과 recentScreen에 보여주기
            if (this.resultToScreen.Length == 0)
            {
                if (this.inputBtnName == "bracketBtn")
                {
                    // 수식 확인해서 괄호 추가
                    this.resultToScreen = BracketInsert(this.resultToScreen, "");
                }
                else if (this.inputBtnName == "inverseBtn" || this.inputBtnName == "rootBtn")
                {
                    this.inputBtnName = (this.inputBtnName == "inverseBtn") ? "1/" : "√(";
                    this.resultToScreen += this.inputBtnName;
                }
            }
            else
            {
                int numCheck = NumberCheck(this.resultToScreen, 1);
                switch (this.inputBtnName)
                {
                    case ("percentBtn"):
                        if (numCheck == 1) //이전에 .을 입력했다면 입력제한
                        {
                            break;
                        }
                        else if (numCheck == 0 || numCheck == 4)
                        {
                            this.resultToScreen += "*(1/100)";
                        }
                        break;
                    case ("bracketBtn"):
                        // 수식 확인해서 괄호 추가
                        this.resultToScreen = BracketInsert(this.resultToScreen, "");
                        break;
                    case ("inverseBtn"):
                    case ("rootBtn"):
                        this.inputBtnName = (this.inputBtnName == "inverseBtn") ? "1/" : "√(";
                        if (numCheck == 1) //이전에 .을 입력했다면 입력제한
                        {
                            break;
                        }
                        else if (numCheck == 0 || numCheck == 4)
                        {
                            this.resultToScreen += "*" + this.inputBtnName;
                        }
                        else
                        {
                            this.resultToScreen += this.inputBtnName;
                        }
                        break;
                    case ("squaredBtn"):
                        if (numCheck == 0 || numCheck == 4)//숫자,닫힌괄호 뒤로 올시 입력
                        {
                            this.resultToScreen += "^(";
                        }
                        break;
                    case ("minusBtn"):
                        if (this.resultToScreen.Length > 1 && NumberCheck(this.resultToScreen, 2) == 7)
                        {
                            break;
                        }
                        if (numCheck == 0 || numCheck == 4)
                        {
                            this.resultToScreen += "－";//계산용 수식 
                        }
                        else if (numCheck == 3)//열린괄호 뒤로 갈땐 음수 값을 입력하게된다
                        {
                            this.resultToScreen += "-";
                        }
                        break;
                    case ("plusMinusBtn"):
                        StringBuilder userInput = new StringBuilder(this.resultToScreen);

                        if (numCheck == 0)
                        {

                            int numLoc = 0;
                            bool onlyNum = true;
                            for (int i = 1; i < this.resultToScreen.Length + 1; i++)
                            {
                                if (!onlyNum) { break; }
                                switch (NumberCheck(this.resultToScreen, i))
                                {
                                    case 0:
                                    case 1:
                                        continue;
                                    case 2:
                                    case 3:
                                    case 4:
                                    case 5:
                                    case 6:
                                    case 7:
                                    case 8:
                                        onlyNum = false;
                                        numLoc = i;
                                        break;
                                }
                            }
                            numLoc = this.resultToScreen.Length - numLoc;
                            if (onlyNum)
                            {
                                userInput.Insert(0, "(-");
                            }
                            else if (userInput[numLoc].Equals('-'))
                            {
                                userInput.Remove(numLoc - 1, 2);
                            }
                            else { userInput.Insert(numLoc + 1, "(-"); }
                        }
                        this.resultToScreen = userInput.ToString();
                        break;
                    case ("mulBtn"):
                        if (numCheck == 0 || numCheck == 4)//숫자,닫힌괄호 뒤로 올시 입력
                        {
                            this.resultToScreen += "*";
                        }
                        break;
                    case ("divBtn"):
                    case ("plusBtn"):
                        this.inputBtnName = (this.inputBtnName == "divBtn") ? "/" : "+";
                        if (numCheck == 0 || numCheck == 4)//숫자,닫힌괄호 뒤로 올시 입력
                        {
                            this.resultToScreen += this.inputBtnName;
                        }
                        break;
                    default:
                        Console.WriteLine("Error occured");
                        break;
                }
            }
            return this.resultToScreen;
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
                else
                {
                    if (bracketNumCheck == 0)
                    {
                        switch (NumberCheck(screenText, 1))
                        {
                            case 0:
                            case 4:
                                screenText += "*(";
                                break;
                            case 1:
                            case 2:
                                break;
                            case 3:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                                screenText += "(";
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (NumberCheck(screenText, 1))
                        {
                            case 0:
                            case 4:
                                screenText += ")";
                                break;
                            case 1:
                            case 2:
                                break;
                            case 3:
                            case 5:
                            case 6:
                            case 7:
                            case 8:
                                screenText += "(";
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            return screenText;
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
                case '^':
                    return 8;
                default:// 연산자
                    return 6;
            }
        }
    }
}
