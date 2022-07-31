using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //프로그램 시작
        public Form1()
        {
            InitializeComponent();
        }
        //숫자 및 dot 버튼 클릭시 Event
        public void numBtnClickEvent(string inputText) {

            if (inputText == dotBtn.Text) {
                if (resultScreen.Text.Contains(dotBtn.Text))
                {//이미 이전 값에 dot이 들어갔다면 안들어감
                    return;
                }
                else { 
                    resultScreen.Text += inputText;
                };
            }
            else {
                resultScreen.Text += inputText;
            }

        }
        //수식 버튼 클릭시 Event
        public void expBtnClickEvent(string inputText) {
            // 수식 버튼들 입력시 recentScreen에 현재식 내용 보여주고
            // 현재까지 결과 resultScreen에 보여주기
            if (inputText == bracketBtn.Text)
            {
                // 수식 확인해서 괄호 추가
                // 일단은 그냥 둠
                recentScreen.Text = resultScreen.Text + inputText;
                resultScreen.Text += inputText;
            }
            else if (inputText == clearBtn.Text)
            {
                resultScreen.Text = "";
                recentScreen.Text = "";
            }
            else if (inputText == equalBtn.Text)
            {
                // 여태 저장된 수식을 계산하고 resultScreen에 결과 출력
                resultScreen.Text += resultScreen.Text + inputText;
            }
            else if (inputText == delBtn.Text)
            {
                resultScreen.Text = resultScreen.Text.Substring(0, resultScreen.Text.Length - 1);
            } 
            else if (inputText == percentBtn.Text) 
            {
                //calcNow
                //recentScreen.Text = resultScreen.Text;
            }
            else if (inputText == divBtn.Text)
            {                
                resultScreen.Text += resultScreen.Text + inputText;
            }
            else if (inputText == mulBtn.Text)
            {
                resultScreen.Text += resultScreen.Text + inputText;
            }
            else if (inputText == minusBtn.Text)
            {
                resultScreen.Text += resultScreen.Text + inputText;
            }
            else if (inputText == plusBtn.Text)
            {
                resultScreen.Text += resultScreen.Text + inputText;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numBtn0_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn0.Text);
        }

        private void numBtn00_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn00.Text);
        }

        private void numBtn1_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn1.Text);
        }

        private void numBtn2_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn2.Text);
        }

        private void numBtn3_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn3.Text);
        }

        private void numBtn4_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn4.Text);
        }

        private void numBtn5_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn5.Text);
        }

        private void numBtn6_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn6.Text);
        }

        private void numBtn7_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn7.Text);
        }

        private void numBtn8_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn8.Text);
        }

        private void numBtn9_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(numBtn9.Text);
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            numBtnClickEvent(dotBtn.Text);
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
        }

        private void bracketBtn_Click(object sender, EventArgs e)
        {
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
