using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CalculatorApp
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //프로그램 시작
        public Form1()
        {
            InitializeComponent();
        }
        char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        // 수식입력시 숫자 체크
        public int NumberCheck() {
            string temp = resultScreen.Text;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (temp[temp.Length - 1].Equals(numbers[j]))
                {
                    return 1;//숫자일시 1 return
                }
            }
            return 0;
        }
        // 수식 계산 로직
        public void CalculateResult() {
            string temp = resultScreen.Text;
            Stack<Double> numberStack = new Stack<Double>();
            String numbersSaveTemp = "";
            List<char> expSave = new List<char>();

            // 리스트로 만든 수식형태를 숫자와 연산자로 구분해서 저장
            for (int i = 0; i < temp.Length; i++)
            {
                bool numCheck = false;
                for (int j = 0; j < numbers.Length; j++) //숫자체크
                {
                    if (temp[i].Equals(numbers[j]) || temp[i].Equals('.'))
                    {
                        numbersSaveTemp += temp[i];
                        numCheck = true;
                        break;
                    }
                }

                if (!numCheck)// 연산자가 나왔을 시 저장
                {
                    expSave.Add(temp[i]);
                    numberStack.Push(Convert.ToDouble(numbersSaveTemp));
                    numbersSaveTemp = "";
                }
            }
            numberStack.Push(Convert.ToDouble(numbersSaveTemp));//맨 마지막 숫자 저장

            ////저장한 숫자와 연산자 계산
            //
            double result = numberStack.Pop();
            for (int i = 0; i < expSave.Count; i++)
            {
                if (expSave[i].Equals('＋')) 
                {
                    result += numberStack.Pop();
                    Console.WriteLine(result);
                }
                else if (expSave[i].Equals('－'))
                {
                    result -= numberStack.Pop(); Console.WriteLine(result);

                }
                else if (expSave[i].Equals('×'))
                {
                    result *= numberStack.Pop(); Console.WriteLine(result);

                }
                else if (expSave[i].Equals('÷'))
                {
                    result /= numberStack.Pop(); Console.WriteLine(result);

                }
            }
            Console.WriteLine("결과 : "+result);

        }

        // bracket 알맞게 입력하기
        public void BracketInsert()
        {
            int bracketNumCheck = 0;
            string temp = resultScreen.Text;
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i].Equals('(') )
                {
                    bracketNumCheck++;
                }
                else if (temp[i].Equals(')') && bracketNumCheck != 0)
                {
                    bracketNumCheck--;
                }
            }

            if (temp[temp.Length - 1].Equals(')') && bracketNumCheck == 0)
            {
                resultScreen.Text += "*(";
            }
            else if(!temp[temp.Length - 1].Equals('(') && bracketNumCheck != 0)
            {
                resultScreen.Text += ")";
            }
            else 
            {
                resultScreen.Text += "(";
            }
        }

        //숫자 및 dot 버튼 클릭시 Event
        public void numBtnClickEvent(string inputText) {

            if (inputText == dotBtn.Text)
            {
                char[] splitStr = { '＋', '－', '×', '÷' };
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
                resultScreen.Text += inputText;
            }

        }
        //수식 버튼 클릭시 Event
        public void expBtnClickEvent(string inputText) {
            // 수식 버튼들 입력시 resultScreen에 현재식 내용 보여주고
            // 현재까지 결과 recentScreen에 보여주기
            if (inputText == bracketBtn.Text)
            {
                // 수식 확인해서 괄호 추가
                BracketInsert();

            }
            else if (inputText == clearBtn.Text)
            {
                resultScreen.Text = "";
                recentScreen.Text = "";
            }
            else if (inputText == equalBtn.Text)
            {
                // 여태 저장된 수식을 계산하고 resultScreen에 결과 출력
                //resultScreen.Text += inputText;
                CalculateResult();
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
                if (NumberCheck() == 1)
                {
                    resultScreen.Text += inputText;
                }
            }
            else if (inputText == mulBtn.Text)
            {
                if (NumberCheck() == 1)
                {
                    resultScreen.Text += inputText;
                }
            }
            else if (inputText == minusBtn.Text)
            {
                if (NumberCheck() == 1)
                {
                    resultScreen.Text += inputText;
                }
            }
            else if (inputText == plusBtn.Text)
            {
                if (NumberCheck() == 1)
                {
                    resultScreen.Text += inputText;
                }
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
            expBtnClickEvent(plusBtn.Text);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            expBtnClickEvent(minusBtn.Text);
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            expBtnClickEvent(mulBtn.Text);
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            expBtnClickEvent(divBtn.Text);
        }

        private void percentBtn_Click(object sender, EventArgs e)
        {
            expBtnClickEvent(percentBtn.Text);
        }

        private void bracketBtn_Click(object sender, EventArgs e)
        {
            expBtnClickEvent(bracketBtn.Text);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            expBtnClickEvent(clearBtn.Text);
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            expBtnClickEvent(equalBtn.Text);
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            expBtnClickEvent(delBtn.Text);
        }
    }
}
