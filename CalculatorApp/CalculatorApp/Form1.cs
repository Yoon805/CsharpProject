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
                    return 1;//숫자일시 1 return 
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
                else if (screenText[screenText.Length - 1].Equals(')') && bracketNumCheck == 0)
                {
                    screenText += "*(";
                }
                else if (!screenText[screenText.Length - 1].Equals('(') && bracketNumCheck != 0)
                {
                    screenText += ")";
                }
                else
                {
                    if (NumberCheck() == 1)
                    {
                        screenText += "*(";
                    }
                    else
                    {
                        screenText += "(";

                    }
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
                string calcStr = resultScreen.Text;
                List<String> postModification = new List<string>();
                UserFunction userFunc = new UserFunction();
                postModification = userFunc.CalStackUse(resultScreen.Text);
                resultScreen.Text = userFunc.CalPostModification(postModification).ToString();
                WriteLog(calcStr + " = " + resultScreen.Text);
                recentScreen.Text = calcStr;
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

        private void userToggleButton1_CheckedChanged(object sender, EventArgs e)
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

        private void resultScreen_TextChanged(object sender, EventArgs e)
        {
            if(resultScreen.Text.Length > 0 && NumberCheck() == 1 && NumberCheck() !=2)
            {
                List<String> postModification = new List<string>();
                UserFunction userFunc = new UserFunction();
                postModification = userFunc.CalStackUse(BracketInsert("cal"));
                recentScreen.Text = userFunc.CalPostModification(postModification).ToString();
            }
        }
    }
}
