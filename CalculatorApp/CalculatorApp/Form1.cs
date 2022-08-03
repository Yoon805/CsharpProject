﻿using System;
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

        // 뒤에서 n번째로 입력한 숫자 체크
        public int NumberCheck(string screenText, int number)
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
                case '-'://숫자로 받을 값들
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

        // bracket 알맞게 입력하기
        public string BracketInsert(string screenText, string nowOrNot)
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

        //로그 남기기
        public void WriteLog(string screen1)
        {
            string[] strs1 = new string[] { screen1 };
            ListViewItem lvi1 = new ListViewItem(strs1);
            logList.Items.Add(lvi1);
        }

        //숫자 및 dot 버튼 클릭시 Event
        public void NumBtnClickEvent(object sender, EventArgs e)
        {
            string inputText = (sender as Button).Text;
            if (inputText == dotBtn.Text)
            {
                char[] splitStr = { '+', '－', '*', '/', '^' };
                string[] tempString = resultScreen.Text.Split(splitStr);
                if (tempString[tempString.Length - 1].Contains(dotBtn.Text))//이미 이전 값에 dot이 들어갔다면 안들어감
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
                if (resultScreen.Text.Length > 0 && NumberCheck(resultScreen.Text, 1) == 4) //닫힌 괄호 다음에 입력할 시
                {
                    resultScreen.Text += "*" + inputText;
                }
                else
                {
                    resultScreen.Text += inputText;
                }
            }

        }
        //수식 버튼 클릭시 Event
        private void ExpBtnClickEvent(object sender, EventArgs e)
        {
            // 수식 버튼들 입력시 resultScreen에 현재식 내용 보여주고
            // 최근수식 및 결과 recentScreen에 보여주기

            string inputText = (sender as Button).Text;

            if (inputText == bracketBtn.Text)
            {
                // 수식 확인해서 괄호 추가
                resultScreen.Text = BracketInsert(resultScreen.Text, "");
            }
            else if (inputText == inverseBtn.Text)
            {
                if (resultScreen.Text.Length == 0)
                {
                    resultScreen.Text += "1/";
                }
                else if (NumberCheck(resultScreen.Text, 1) == 1) //이전에 .을 입력했다면 입력제한
                {
                    return;
                }
                else if (NumberCheck(resultScreen.Text, 1) == 0 || NumberCheck(resultScreen.Text, 1) == 4)
                {
                    resultScreen.Text += "*1/";
                }
                else
                {
                    resultScreen.Text += "1/";
                }
            }
            else if (inputText == rootBtn.Text)
            {
                if (resultScreen.Text.Length == 0)
                {
                    resultScreen.Text += "√(";
                }
                else if (NumberCheck(resultScreen.Text, 1) == 1) //이전에 .을 입력했다면 입력제한
                {
                    return;
                }
                else if (NumberCheck(resultScreen.Text, 1) == 0 || NumberCheck(resultScreen.Text, 1) == 4)
                {
                    resultScreen.Text += "*√(";
                }
                else
                {
                    resultScreen.Text += "√(";
                }
            }
            else if (resultScreen.Text.Length < 1)
            {
                return;
            }
            else if (inputText == clearBtn.Text)
            {
                resultScreen.Text = "";
                recentScreen.Text = "";
                WriteLog("- - - - - - - - - -");
            }
            else if (inputText == equalBtn.Text)
            {
                // 저장된 수식을 계산하고 resultScreen에 결과 출력
                UserFunction userFunc = new UserFunction();
                string chCalc = BracketInsert(resultScreen.Text, "cal");
                List<String> postModification = userFunc.CalStackUse(chCalc);
                resultScreen.Text = userFunc.CalPostModification(postModification).ToString();
                WriteLog(chCalc + " = " + resultScreen.Text);
                recentScreen.Text = chCalc;
            }
            else if (inputText == delBtn.Text)
            {
                if (resultScreen.Text.Length > 0)
                {
                    if (resultScreen.Text.Length > 1 && NumberCheck(resultScreen.Text, 2) == 7)
                    {
                        resultScreen.Text = resultScreen.Text.Substring(0, resultScreen.Text.Length - 2);
                    }
                    else
                    {
                        resultScreen.Text = resultScreen.Text.Substring(0, resultScreen.Text.Length - 1);
                    }
                }
            }
            else if (inputText == percentBtn.Text)
            {
                if (NumberCheck(resultScreen.Text, 1) == 1) //이전에 .을 입력했다면 입력제한
                {
                    return;
                }
                else if (NumberCheck(resultScreen.Text, 1) == 0 || NumberCheck(resultScreen.Text, 1) == 4)
                {
                    resultScreen.Text += "*1/100";
                }
            }
            else if (inputText == minusBtn.Text)
            {
                if (NumberCheck(resultScreen.Text, 1) == 0 || NumberCheck(resultScreen.Text, 1) == 4)
                {
                    resultScreen.Text += "－";//계산용 수식 
                }
                else if (NumberCheck(resultScreen.Text, 1) == 3)//열린괄호 뒤로 갈땐 음수 값을 입력하게된다
                {
                    resultScreen.Text += inputText;
                }
            }
            else
            {
                if (NumberCheck(resultScreen.Text, 1) == 0 || NumberCheck(resultScreen.Text, 1) == 4)//숫자,닫힌괄호 뒤로 올시 입력
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

            else
            {
                ClientSize = new System.Drawing.Size(335, 460);
                splitContainer1.SplitterDistance = 335;
            }
        }




        private void ResultScreen_TextChanged(object sender, EventArgs e) // recentScreen에 실시간 계산 표시
        {
            if (resultScreen.Text.Length > 0 && (NumberCheck(resultScreen.Text, 1) == 0 || NumberCheck(resultScreen.Text, 1) == 4))
            {
                UserFunction userFunc = new UserFunction();
                List<String> postModification = userFunc.CalStackUse(BracketInsert(resultScreen.Text, "cal"));
                recentScreen.Text = userFunc.CalPostModification(postModification).ToString();
            }
            else
            {
                recentScreen.Text = "";
            }
        }

        private void ListClearBtn_Click(object sender, EventArgs e)
        {
            logList.Clear();
        }
    }
}
