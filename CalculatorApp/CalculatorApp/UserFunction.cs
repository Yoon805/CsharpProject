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
                switch (temp[i])
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
                    case '.':
                        numbersSaveTemp += temp[i].ToString();
                        break;
                    case '(':
                    case '*':
                    case '/':
                        if (numbersSaveTemp.Length != 0)
                        {
                            mathList.Add(numbersSaveTemp);
                            numbersSaveTemp = "";
                        }
                        expsStack.Push(temp[i].ToString());
                        break;
                    case '+':
                    case '-':
                        if (numbersSaveTemp.Length != 0)
                        {
                            mathList.Add(numbersSaveTemp);
                            numbersSaveTemp = "";
                        }
                        if (expsStack.Count != 0)
                        {
                            while (expsStack.Count > 0)
                            {
                                if (expsStack.Peek().Equals("(")) { break; }
                                mathList.Add(expsStack.Pop().ToString());
                            }
                        }
                        expsStack.Push(temp[i].ToString());
                        break;
                    case ')':
                        if (numbersSaveTemp.Length != 0)
                        {
                            mathList.Add(numbersSaveTemp);
                            numbersSaveTemp = "";
                        }
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
                        break;
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
            Console.WriteLine(mathList);
            return mathList; // 저장된 후위수식 return
        }

        public double CalPostModification(List<String> PostMod)
        {
            Stack<double> numberStack = new Stack<double>();
            double result;
            for (int i = 0; i < PostMod.Count; i++)
            {
                switch (PostMod[i])
                {
                    case "0":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                    case "7":
                    case "8":
                    case "9":
                    case ".":
                        numberStack.Push(Double.Parse(PostMod[i]));
                        break;
                    case "+":
                        result = numberStack.Pop() + numberStack.Pop();
                        numberStack.Push(result);
                        break;
                    case "-":
                        result = 0 - numberStack.Pop() + numberStack.Pop();
                        numberStack.Push(result);
                        break;
                    case "*":
                        result = numberStack.Pop() * numberStack.Pop();
                        numberStack.Push(result);
                        break;
                    case "/":
                        result = 1 / numberStack.Pop() * numberStack.Pop();
                        numberStack.Push(result);
                        break;
                }
            }
            return numberStack.Pop();
        }
    }




}
