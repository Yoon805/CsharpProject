using System;
using System.Collections.Generic;

namespace CalculatorApp
{
    internal class UserFunction
    {


        public List<String> CalStackUse(string temp)
        {
            //string temp = "1+2*3+(4+2)/2";
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
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
                    if (numbersSaveTemp.Length != 0)
                    {
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
                        if (expsStack.Count != 0)
                        {
                            while (expsStack.Count > 0 || expsStack.Peek().Equals("("))
                            {
                                mathList.Add(expsStack.Pop().ToString());
                            }
                        }
                        expsStack.Push(temp[i].ToString());

                    }
                    else if (temp[i].Equals(')'))
                    {
                        if (expsStack.Count != 0)
                        {                        
                            while (expsStack.Count > 0)
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
            for (int i = 0; i < mathList.Count; i++)
            {
                Console.WriteLine(mathList[i].ToString());
            }

            return mathList; // 저장된 후위수식 return
        }

        public double CalPostModification(List<String> PostMod)
        {
            Stack<double> numberStack = new Stack<double>();
            double result;
            for (int i = 0; i < PostMod.Count; i++)
            {

                if (PostMod[i].Equals("+"))
                {
                    result = numberStack.Pop() + numberStack.Pop();
                    numberStack.Push(result);
                }
                else if (PostMod[i].Equals("-"))
                {
                    result = 0 - numberStack.Pop() + numberStack.Pop();
                    numberStack.Push(result);
                }
                else if (PostMod[i].Equals("*"))
                {
                    result = numberStack.Pop() * numberStack.Pop();
                    numberStack.Push(result);
                }
                else if (PostMod[i].Equals("/"))
                {
                    result = 1 / numberStack.Pop() * numberStack.Pop();
                    numberStack.Push(result);
                }
                else
                {
                    numberStack.Push(Double.Parse(PostMod[i]));
                }
            }
            return numberStack.Pop();
        }
    }




}
