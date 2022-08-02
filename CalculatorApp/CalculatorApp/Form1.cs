using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace CalculatorApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //프로그램 시작
        public Form1()
        {
            InitializeComponent();
            ClientSize = new System.Drawing.Size(652, 460);
            resultScreen.Text = "";
            recentScreen.Text = "";
        }

        // 수식입력시 숫자 체크
        public int NumberCheck() {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' , '.'};

            string screenText = resultScreen.Text;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (screenText[screenText.Length - 1].Equals(numbers[j]))
                {
                    return 1;//숫자일시 return 1
                } else if (screenText[screenText.Length - 1].Equals('(') || screenText[screenText.Length - 1].Equals(')')) {
                    return 2;//괄호면 return 2
                }
            }
            return 0;
        }

        // bracket 알맞게 입력하기
        public string BracketInsert(string nowOrNot)
        {
            int bracketNumCheck = 0;
            string screenText = resultScreen.Text;
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
                for (int i = 0; i < bracketNumCheck; i++) {
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
                else if (!screenText[screenText.Length - 1].Equals('(') && bracketNumCheck != 0)
                {
                    screenText += ")";
                }
                else if (screenText[screenText.Length - 1].Equals(')') && bracketNumCheck == 0)
                {
                    screenText += "*(";
                }
                else if(NumberCheck() == 1)
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

        //로그 남기기
        public void WriteLog(string screen1) {
            string[] strs1 = new string[] { screen1 };
            ListViewItem lvi1 = new ListViewItem(strs1);
            logList.Items.Add(lvi1);            
        }

        //숫자 및 dot 버튼 클릭시 Event
        public void NumBtnClickEvent(object sender, EventArgs e) {
            string inputText = (sender as Button).Text;
            if (inputText == dotBtn.Text)
            {
                char[] splitStr = { '+', '-', '*', '/' };
                string[] tempString = resultScreen.Text.Split(splitStr);
                Console.WriteLine(tempString[tempString.Length - 1]);
                if (tempString[tempString.Length - 1].Contains(dotBtn.Text))
                {//이미 이전 값에 dot이 들어갔다면 안들어감
                    return;
                }
                else {
                    resultScreen.Text += inputText;
                };
            }
            else {
                if (resultScreen.Text.Length>0 && resultScreen.Text[resultScreen.Text.Length - 1].Equals(')')) {
                    resultScreen.Text += "*"+inputText;
                }
                else {
                    resultScreen.Text += inputText;
                }
            }

        }
        //수식 버튼 클릭시 Event
        private void ExpBtnClickEvent(object sender, EventArgs e) {
            // 수식 버튼들 입력시 resultScreen에 현재식 내용 보여주고
            // 최근수식 recentScreen에 보여주기

            string inputText = (sender as Button).Text;
            if (resultScreen.Text.Length < 1) {
                return;
            }

            if (inputText == bracketBtn.Text)
            {
                // 수식 확인해서 괄호 추가
                resultScreen.Text = BracketInsert("");
            }
            else if (inputText == clearBtn.Text)
            {
                resultScreen.Text = "";
                recentScreen.Text = "";
                WriteLog("----------");
            }
            else if (inputText == equalBtn.Text)
            {
                // 여태 저장된 수식을 계산하고 resultScreen에 결과 출력
                UserFunction userFunc = new UserFunction();
                string chCalc = BracketInsert("cal");
                List<String> postModification = userFunc.CalStackUse(chCalc);
                resultScreen.Text = userFunc.CalPostModification(postModification).ToString();  
                WriteLog(chCalc + " = " + resultScreen.Text);
                recentScreen.Text = chCalc;
            }
            else if (inputText == delBtn.Text)
            {
                if (resultScreen.Text.Length > 0) {
                    resultScreen.Text = resultScreen.Text.Substring(0, resultScreen.Text.Length - 1);

                }
            } 
            else if (inputText == percentBtn.Text) 
            {
                //calcNow
                //recentScreen.Text = resultScreen.Text;
            }
            else 
            {
                if (NumberCheck() != 0)
                {
                    resultScreen.Text += inputText;
                }
            }
        }

        private void UserToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (userToggleButton1.Checked)
            {
                ClientSize = new System.Drawing.Size(652, 460);
                splitContainer1.SplitterDistance = 326;

            }

            else {
                ClientSize = new System.Drawing.Size(335, 460);
                splitContainer1.SplitterDistance = 335;
            }
            
            
        }

        private void ResultScreen_TextChanged(object sender, EventArgs e)
        {
            if(resultScreen.Text.Length > 0 && NumberCheck() == 1 && NumberCheck() !=2)
            {
                UserFunction userFunc = new UserFunction();
                List<String> postModification = userFunc.CalStackUse(BracketInsert("cal"));
                recentScreen.Text = userFunc.CalPostModification(postModification).ToString();
            }
        }

        private void InverseBtn_Click(object sender, EventArgs e)
        {

        }

        private void SquaredBtn_Click(object sender, EventArgs e)
        {
            if (NumberCheck() == 1 || resultScreen.Text[resultScreen.Text.Length - 1].Equals(')'))
            {
                char[] splitStr = { '+', '-', '*', '/' };
                char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.' };

                Boolean expOrNot = false;

                string calStr = "";

                Stack<string> tempStr = new Stack<string>();
                 for (int i = resultScreen.Text.Length -1; i > -1; i--)
                 {
                    for (int j=0; j<splitStr.Length;j++) {
                        if (splitStr[j].Equals(resultScreen.Text[i])) {
                            expOrNot=true;
                            break;
                        }
                    }

                    if (expOrNot)
                    {
                        break;
                    }
                    else
                    {
                        for (int k = 0; k < numbers.Length; k++)
                        {
                            if (numbers[k].Equals(resultScreen.Text[i]))
                            {
                                tempStr.Push(resultScreen.Text[i].ToString());
                                break;
                            }
                        }
                    }

                 }
                Console.WriteLine(tempStr.Count);
                int num = tempStr.Count;
                for (int i =0; i < num; i++) {
                    calStr += tempStr.Pop();
                }
                Console.WriteLine(calStr);
                double result = Math.Pow(double.Parse(calStr),2);

                resultScreen.Text = resultScreen.Text.Substring(0, resultScreen.Text.Length - num);
                string resultStr = resultScreen.Text;

                resultScreen.Text += result;
                UserFunction userFunc = new UserFunction();
                string chCalc = BracketInsert("cal");
                List<String> postModification = userFunc.CalStackUse(chCalc);
                string realStr = userFunc.CalPostModification(postModification).ToString();

                resultScreen.Text = resultStr;
                resultScreen.Text += calStr.ToString() + "^2";
                WriteLog(BracketInsert("cal") + " = " + realStr);
            }
        }

        private void RootBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
