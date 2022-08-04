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

        CalculateFunc userFunc = new CalculateFunc();

        // 계산 기록 열기/닫기
        private void UserToggleButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (userToggleButton1.Checked)
            {
                splitContainer1.SplitterDistance = ClientSize.Width / 2;
            }
            else
            {
                splitContainer1.SplitterDistance = ClientSize.Width;
            }
        }

        //계산 기록 로그 남기기
        public void WriteLog(string screen1)
        {
            logList.Items.Add(screen1);
        }

        // 계산 기록 초기화
        private void ListClearBtn_Click(object sender, EventArgs e)
        {
            logList.Clear();
            ColumnHeader columnHeader1 = new ColumnHeader();
            logList.Columns.Add(columnHeader1);
        }

        // ClearBtn 클릭시 계산기 화면 정리
        public void ClearBtn_Click(object sender, EventArgs e)
        {
            resultScreen.Text = "";
            recentScreen.Text = "";
            userFunc.OneMoreCalc = false;
            WriteLog("- - - - - - - - - -");
            logList.Columns[logList.Columns.Count - 1].Width = -2;

        }

        // 지우기 버튼 클릭시 한글자 지우기
        public void DelBtn_Click(object sender, EventArgs e)
        {
            if (resultScreen.Text.Length > 0)
            {
                if (resultScreen.Text.Length > 1 && userFunc.NumberCheck(resultScreen.Text, 2) == 7)
                {
                    resultScreen.Text = resultScreen.Text.Substring(0, resultScreen.Text.Length - 2);
                }
                else
                {
                    resultScreen.Text = resultScreen.Text.Substring(0, resultScreen.Text.Length - 1);
                }
            }
        }

        // equalBtn 클릭시 결과 출력
        public void EqualBtn_Click(object sender, EventArgs e)
        {
            ClickFunc clkFunc = new ClickFunc();
            string screenText = resultScreen.Text;
            string chCalc;
            if ((screenText.Length != 0) && (userFunc.NumberCheck(screenText, 1) == 0 || userFunc.NumberCheck(screenText, 1) == 4))
            {   // 저장된 수식을 계산하고 resultScreen에 결과 출력
                if (userFunc.OneMoreCalc)
                {
                    screenText += userFunc.LastCal;
                    chCalc = clkFunc.BracketInsert(screenText, "cal");
                }
                else
                {
                    chCalc = clkFunc.BracketInsert(screenText, "cal");
                    userFunc.SaveLastCalc(chCalc);
                }
                List<String> postModification = userFunc.CalStackUse(chCalc);
                screenText = userFunc.CalPostModification(postModification).ToString();
                WriteLog(chCalc + " = " + screenText);
                resultScreen.Text = screenText;
                recentScreen.Text = chCalc;

                userFunc.OneMoreCalc = true;
                logList.Columns[logList.Columns.Count - 1].Width = -2;
                logList.Items[logList.Items.Count - 1].EnsureVisible();

            }
        }
        //숫자 및 dot 버튼 클릭시 Event
        public void NumBtnClickEvent(object sender, EventArgs e)
        {
            string inputText = (sender as Button).Text;

            if (inputText == dotBtn.Text)
            {
                char[] splitStr = { '+', '－', '*', '/', '^' };
                string[] tempString = resultScreen.Text.Split(splitStr);
                if (tempString[tempString.Length - 1].Contains(dotBtn.Text))// 이전 값에 dot이 들어갔다면 안들어감
                {
                    return;
                }
                else
                {
                    resultScreen.Text += inputText;
                };
            }
            else
            {
                if (resultScreen.Text.Length > 0 && userFunc.NumberCheck(resultScreen.Text, 1) == 4) //닫힌 괄호 다음에 입력할 시
                {
                    resultScreen.Text += "*" + inputText;
                }
                else
                {
                    resultScreen.Text += inputText;
                }
            }

        }

        //수식 기호 버튼 클릭시 Event
        private void OpBtnClickEvent(object sender, EventArgs e)
        {
            string inputBtnName = (sender as Button).Name;
            ClickFunc clickedAction = new ClickFunc(inputBtnName, resultScreen.Text);
            resultScreen.Text = clickedAction.OpBtnClikInsert();
        }

        // 결과창 변경시 중간 계산값 recentScreen에 출력
        private void ResultScreen_TextChanged(object sender, EventArgs e) // recentScreen에 실시간 계산 표시
        {
            ClickFunc clkFunc = new ClickFunc();

            if (resultScreen.Text.Length > 0 && (userFunc.NumberCheck(resultScreen.Text, 1) == 0 || userFunc.NumberCheck(resultScreen.Text, 1) == 4))
            {
                List<String> postModification = userFunc.CalStackUse(clkFunc.BracketInsert(resultScreen.Text, "cal"));
                recentScreen.Text = userFunc.CalPostModification(postModification).ToString();
            }
            else
            {
                recentScreen.Text = "";
            }
        }

        private void EqualBtn_Leave(object sender, EventArgs e)
        {
            userFunc.LastCal = "";
            userFunc.OneMoreCalc = false;
        }

       /* //키패드 입력시 처리
        private void KeyInput(object sender, KeyEventArgs e)
        {      //translate key value to char            
            char keyNo = e.KeyValue.ToString()[(e.KeyValue.ToString().Length - 1)];
            //Do Something if key event value is numeric            
            if (char.IsNumber(keyNo))
            {
                int keyVal = int.Parse(keyNo.ToString());

                //do logic for numric            
            }
        }*/
    }
}
