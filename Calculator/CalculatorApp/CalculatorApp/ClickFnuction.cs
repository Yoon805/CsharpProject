using System;
using System.Text;


namespace CalculatorApp
{
    internal class ClickFnuction
    {

        string inputBtnName;
        string screenExit;


        public ClickFnuction(string inputBtnName, string screenExit)
        {
            this.inputBtnName = inputBtnName;
            this.screenExit = screenExit;
        }

        public string ExpBtnClik()
        {
            // 수식 기호 버튼들 입력시 resultScreen에 현재식 내용 보여주고
            // 최근수식 및 결과 recentScreen에 보여주기
            UserFunction userFunc = new UserFunction();
            if (this.screenExit.Length == 0)
            {
                if (this.inputBtnName == "( )")
                {
                    // 수식 확인해서 괄호 추가
                    this.screenExit = userFunc.BracketInsert(this.screenExit, "");
                }
                else if (this.inputBtnName == "inverseBtn" || this.inputBtnName == "rootBtn")
                {
                    this.inputBtnName = (this.inputBtnName == "inverseBtn") ? "1/" : "√(";
                    this.screenExit += this.inputBtnName;
                }
            }
            else
            {
                int numCheck = userFunc.NumberCheck(this.screenExit, 1);
                switch (this.inputBtnName)
                {
                    case ("percentBtn"):
                        if (numCheck == 1) //이전에 .을 입력했다면 입력제한
                        {
                            break;
                        }
                        else if (numCheck == 0 || numCheck == 4)
                        {
                            this.screenExit += "*1/100";
                        }
                        break;
                    case ("bracketBtn"):
                        // 수식 확인해서 괄호 추가
                        this.screenExit = userFunc.BracketInsert(this.screenExit, "");
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
                            this.screenExit += "*" + this.inputBtnName;
                        }
                        else
                        {
                            this.screenExit += this.inputBtnName;
                        }
                        break;
                    case ("squaredBtn"):
                        if (numCheck == 0 || numCheck == 4)//숫자,닫힌괄호 뒤로 올시 입력
                        {
                            this.screenExit += "^(";
                        }
                        break;
                    case ("minusBtn"):
                        if (numCheck == 0 || numCheck == 4)
                        {
                            this.screenExit += "－";//계산용 수식 
                        }
                        else if (numCheck == 3)//열린괄호 뒤로 갈땐 음수 값을 입력하게된다
                        {
                            this.screenExit += "-";
                        }
                        break;
                    case ("plusMinusBtn"):
                        StringBuilder userInput = new StringBuilder(this.screenExit);

                        if (numCheck == 0)
                        {

                            int numLoc = 0;
                            bool onlyNum = true;
                            for (int i = 1; i < this.screenExit.Length + 1; i++)
                            {
                                if (!onlyNum) { break; }
                                switch (numCheck)
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
                            numLoc = this.screenExit.Length - numLoc;
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
                        this.screenExit = userInput.ToString();
                        break;
                    case ("mulBtn"):
                        if (numCheck == 0 || numCheck == 4)//숫자,닫힌괄호 뒤로 올시 입력
                        {
                            this.screenExit += "*";
                        }
                        break;
                    case ("divBtn"):
                    case ("plusBtn"):
                        this.inputBtnName = (this.inputBtnName == "divBtn") ? "/" : "+";
                        if (numCheck == 0 || numCheck == 4)//숫자,닫힌괄호 뒤로 올시 입력
                        {
                            this.screenExit += this.inputBtnName;
                        }
                        break;
                    default:
                        Console.WriteLine("Error occured");
                        break;
                }
            }
            return this.screenExit;
        }
    }
}
