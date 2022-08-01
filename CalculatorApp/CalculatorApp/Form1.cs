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
            resultScreen.Text = "";
            recentScreen.Text = "";
        }
        char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        // 수식입력시 숫자 체크
        public int NumberCheck() {
            string temp = resultScreen.Text;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (temp[temp.Length - 1].Equals(numbers[j]) || temp[temp.Length - 1].Equals('(') || temp[temp.Length - 1].Equals(')'))
                {
                    return 1;//숫자일시 1 return , 괄호여도 return 1
                }
            }
            return 0;
        }
        // 수식 계산 로직
        /*public void CalculateResult() {
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
                if (expSave[i].Equals('+')) 
                {
                    result += numberStack.Pop();
                    Console.WriteLine(result);
                }
                else if (expSave[i].Equals('-'))
                {
                    result -= numberStack.Pop(); Console.WriteLine(result);

                }
                else if (expSave[i].Equals('*'))
                {
                    result *= numberStack.Pop(); Console.WriteLine(result);

                }
                else if (expSave[i].Equals('/'))
                {
                    result /= numberStack.Pop(); Console.WriteLine(result);

                }
            }
            Console.WriteLine("결과 : "+result);

        }*/

       /* public List<String> CalStackUse() {
            string temp = resultScreen.Text;
            //string temp = "1+2*3+(4+2)/2";
            Console.WriteLine(temp);
            Console.WriteLine(temp.Length);
            String numbersSaveTemp = "";
            List<String> mathList = new List<String>();//전체 식 저장
            Stack<string> expsStack = new Stack<string>();//기호 임시 저장

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

                if (!numCheck)// 기호가 나왔을 시
                {
                    if (numbersSaveTemp.Length !=0) {
                        mathList.Add(numbersSaveTemp);
                        numbersSaveTemp = "";
                    }
                    

                    if (temp[i].Equals('('))
                    {
                        expsStack.Push(temp[i].ToString());
                    }
                    else if (temp[i].Equals('*') || temp[i].Equals('/'))
                    {
                        expsStack.Push(temp[i].ToString());
                    }
                    else if (temp[i].Equals('+') || temp[i].Equals('-'))
                    {
                        if (expsStack.Count == 0) {
                        }
                        else
                        {
                            while (expsStack.Count > 0 )
                            {
                                if (expsStack.Peek().Equals("("))
                                {
                                    break;
                                }
                                mathList.Add(expsStack.Pop().ToString());
                            }
                        }
                        expsStack.Push(temp[i].ToString());

                    }
                    else if (temp[i].Equals(')')) 
                    {
                        if (expsStack.Count == 0)
                        {
                        }
                        else
                        {
                            while (expsStack.Count > 0 )
                            {
                                if (expsStack.Peek().Equals("("))
                                {
                                    expsStack.Pop();
                                    break;
                                }
                                mathList.Add(expsStack.Pop().ToString());
                            }
                        }
                    }
                    
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

            Console.WriteLine(mathList.Count);
            recentScreen.Text = "";
            for (int i =0;i<mathList.Count;i++) {
                Console.WriteLine(mathList[i].ToString());
            }

            return mathList; // 저장된 후위수식 return
        }*/

        /*public double CalPostModification(List<String> PostMod) {
            Stack<double> numberStack = new Stack<double>();
            string expTemp = "";
            double result = 0;
            for (int i = 0; i < PostMod.Count; i++) {

                expTemp = PostMod[i];
                if (expTemp.Equals("+"))
                {
                    result = numberStack.Pop() + numberStack.Pop();
                    numberStack.Push(result);
                }
                else if (expTemp.Equals("-"))
                {
                    result = 0 - numberStack.Pop() + numberStack.Pop();
                    numberStack.Push(result);
                }
                else if (expTemp.Equals("*"))
                {
                    result = numberStack.Pop() * numberStack.Pop();
                    numberStack.Push(result);
                }
                else if (expTemp.Equals("/"))
                {
                    result =1 / numberStack.Pop() * numberStack.Pop();
                    numberStack.Push(result);
                }
                else 
                {
                    numberStack.Push(Double.Parse(PostMod[i]));
                }
            }
            result = numberStack.Pop();
            return result;
        }*/

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

            if (temp.Length ==0) {
                resultScreen.Text += "(";
            }
            else if (temp[temp.Length - 1].Equals(')') && bracketNumCheck == 0)
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
                resultScreen.Text += inputText;
            }

        }
        //수식 버튼 클릭시 Event
        private void ExpBtnClickEvent(object sender, EventArgs e) {
            // 수식 버튼들 입력시 resultScreen에 현재식 내용 보여주고
            // 현재까지 결과 recentScreen에 보여주기
            string inputText = (sender as Button).Text;
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
                List<String> postModification = new List<string>();
                UserFunction userFunc = new UserFunction();
                postModification = userFunc.CalStackUse(resultScreen.Text);
                resultScreen.Text = userFunc.CalPostModification(postModification).ToString();
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

    }
}
