using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using CalcClass;

namespace AnalyzerClass
{
    public class Analyzer
    {
        private static int ErrPosition = 0;
        public static string Expression = "";
        public static bool ShowMessage = false;
        public static bool CheckCurrency()
        {
            try
            {
                if (expression.Length > Math.Pow(2, 16))
                {
                    ShowMessege = true;
                    expression = "error 07";
                    return false;
                }

                int Openbreckets = 0;
                for (int CurrentPos = 0; CurrentPos < expression.Length; CurrentPos++)
                {
                    if (expression[CurrentPos] == '(')
                        Openbreckets++;
                    else
                        if (expression[CurrentPos] == ')')
                        if (Openbreckets > 0)
                            Openbreckets--;
                        else
                        {
                            ShowMessege = true;
                            expression = "error 01";
                            return false;
                        }

                }

                if (Openbreckets != 0)
                {
                    ShowMessege = true;
                    expression = "error 01";
                    return false;
                }
                return true;
            }
            catch
            {
                ShowMessege = true;
                expression = "error 01";
                return false;
            }
        }

        private static string Format()
        {

            try
            {

                expression = expression.Replace(" ", string.Empty);
                int CurrentPos = 0;
                while (CurrentPos < expression.Length)
                {

                    switch (expression[CurrentPos])
                    {
                        case '1':
                        case '2':
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                        case '8':
                        case '9':
                        case '0':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                bool b3 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 0)
                                        if (expression[CurrentPos - 1].ToString() == i.ToString())
                                            b1 = true;
                                }
                                if (CurrentPos < expression.Length - 1)
                                    if ((expression[CurrentPos + 1].ToString() == ")") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "*") || (expression[CurrentPos + 1].ToString() == "/") || (expression[CurrentPos + 1].ToString() == "+") || (expression[CurrentPos + 1].ToString() == "-"))
                                        b3 = true;
                                if ((CurrentPos > 0) && (!b1))
                                {
                                    if ((expression[CurrentPos - 2].ToString() == "d") || (expression[CurrentPos - 2].ToString() == "(") || (expression[CurrentPos - 2].ToString() == "+") || (expression[CurrentPos - 2].ToString() == "-") || (expression[CurrentPos - 2].ToString() == "*") || (expression[CurrentPos - 2].ToString() == "/") || (expression[CurrentPos - 2].ToString() == "m") || (expression[CurrentPos - 2].ToString() == "p"))
                                        b1 = true;
                                }
                                if ((b3 || CurrentPos == expression.Length - 1) && (b1 || CurrentPos == 0))
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                if ((b2 || CurrentPos == expression.Length - 1) && (b1 || CurrentPos == 0))
                                {
                                    CurrentPos++;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 02 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //----------------------------------------------------------

                        case '+':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 0)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                            b1 = true;
                                }
                                //---
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == "(") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "p"))
                                        b2 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 02 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if (CurrentPos > 0)
                                {
                                    if (expression[CurrentPos - 2].ToString() == ")")
                                        b1 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if ((b2 || CurrentPos == expression.Length - 1) && (b1 || CurrentPos == 0))
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //-----------------------------------------------------------------------------------------------------------

                        case '-':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 1)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                            b1 = true;
                                }
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == "(") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "p"))
                                        b2 = true;
                                }
                                if (CurrentPos > 0)
                                {
                                    if (expression[CurrentPos - 2].ToString() == ")")
                                        b1 = true;
                                }

                                if (b2 && b1)
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //----------------------------------------------------------------------------------------------------------

                        case '/':
                        case '*':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 1)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                            b1 = true;
                                }
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == "(") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "p"))
                                        b2 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if (CurrentPos > 0)
                                {
                                    if (expression[CurrentPos - 2].ToString() == ")")
                                        b1 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if (b2 && b1)
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 03 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //----------------------------------------------------------------------------------------------------------

                        case '(':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                            b2 = true;
                                    if (CurrentPos > 1)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                        {
                                            ShowMessege = true;
                                            expression = "Error 01 at " + CurrentPos.ToString();
                                            return expression;
                                        }
                                }
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == "(") || (expression[CurrentPos + 1].ToString() == "m") || (expression[CurrentPos + 1].ToString() == "p"))
                                        b2 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 01 at " + CurrentPos.ToString();
                                    return expression;
                                }
                                if (CurrentPos > 0)
                                {
                                    if ((expression[CurrentPos - 2].ToString() == "(") || (expression[CurrentPos - 2].ToString() == "*") || (expression[CurrentPos - 2].ToString() == "/") || (expression[CurrentPos - 2].ToString() == "+") || (expression[CurrentPos - 2].ToString() == "-") || (expression[CurrentPos - 2].ToString() == "d") || (expression[CurrentPos - 2].ToString() == "m") || (expression[CurrentPos - 2].ToString() == "p"))
                                        b1 = true;
                                }
                                else b1 = true;

                                if (b2 && b1)
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 01 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //-----------------------------------------------------------------------------                  

                        case ')':
                            {
                                bool b1 = false;
                                bool b2 = false;
                                for (int i = 0; i < 10; i++)
                                {
                                    if (CurrentPos < expression.Length - 1)
                                        if (expression[CurrentPos + 1].ToString() == i.ToString())
                                        {
                                            ShowMessege = true;
                                            expression = "Error 01 at " + CurrentPos.ToString();
                                            return expression;
                                        }
                                    if (CurrentPos > 1)
                                        if (expression[CurrentPos - 2].ToString() == i.ToString())
                                            b1 = true;
                                }
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if ((expression[CurrentPos + 1].ToString() == ")") || (expression[CurrentPos + 1].ToString() == "*") || (expression[CurrentPos + 1].ToString() == "/") || (expression[CurrentPos + 1].ToString() == "+") || (expression[CurrentPos + 1].ToString() == "-") || (expression[CurrentPos + 1].ToString() == "m"))
                                        b2 = true;
                                }
                                else b2 = true;
                                if (CurrentPos > 0)
                                {
                                    if (expression[CurrentPos - 2].ToString() == ")")
                                        b1 = true;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 01 at " + CurrentPos.ToString();
                                    return expression;
                                }

                                if (b2 && b1)
                                {
                                    expression = expression.Insert(CurrentPos + 1, " ");
                                    CurrentPos += 2;
                                    break;
                                }
                                else
                                {
                                    ShowMessege = true;
                                    expression = "Error 01 at " + CurrentPos.ToString();
                                    return expression;
                                }
                            }

                        //----------------------------------------------------------------------------------------------------------  

                        case 'm':
                        case 'p':
                            {
                                if (CurrentPos < expression.Length - 1)
                                {
                                    if (expression[CurrentPos + 1] == 'o')
                                    {
                                        bool b1 = false;
                                        bool b2 = false;
                                        if (!((CurrentPos + 3) >= expression.Length))
                                        {
                                            if (expression[CurrentPos + 1] == 'o' && expression[CurrentPos + 2] == 'd')
                                            { }
                                            else
                                            {
                                                ShowMessege = true;
                                                expression = "Error 02 at " + CurrentPos.ToString();
                                                return expression;
                                            }
                                        }
                                        else
                                        {
                                            ShowMessege = true;
                                            expression = "Error 05";
                                            return expression;
                                        }

                                        for (int i = 0; i < 10; i++)
                                        {
                                            if (expression[CurrentPos + 3].ToString() == i.ToString())
                                                b2 = true;
                                            if (CurrentPos > 1)
                                                if (expression[CurrentPos - 2].ToString() == i.ToString())
                                                    b1 = true;
                                        }

                                        if ((expression[CurrentPos + 3].ToString() == "(") || (expression[CurrentPos + 3].ToString() == "m") || (expression[CurrentPos + 3].ToString() == "p"))
                                            b2 = true;

                                        if (CurrentPos > 0)
                                        {
                                            if (expression[CurrentPos - 2].ToString() == ")")
                                                b1 = true;
                                        }
                                        else
                                        {
                                            ShowMessege = true;
                                            expression = "Error 03";
                                            return expression;
                                        }

                                        if (b2 && b1)
                                        {
                                            expression = expression.Insert(CurrentPos + 3, " ");
                                            CurrentPos += 4;
                                            break;
                                        }
                                        else
                                        {
                                            ShowMessege = true;
                                            expression = "Error 01 at " + CurrentPos.ToString();
                                            return expression;
                                        }
                                    }
                                    //----------------------------------------------------
                                    else
                                    {
                                        bool b1 = false;
                                        bool b2 = false;
                                        //bool b3 = false;
                                        if (CurrentPos == 0)
                                        {
                                            b1 = true;
                                        }
                                        for (int i = 0; i < 10; i++)
                                        {
                                            if (CurrentPos < expression.Length - 1)
                                                if (expression[CurrentPos + 1].ToString() == i.ToString())
                                                {
                                                    b2 = true;
                                                    break;
                                                }
                                        }
                                        if ((CurrentPos < expression.Length - 1) && (!b2))
                                            if ((expression[CurrentPos + 1].ToString() == "("))
                                                b2 = true;
                                        if ((CurrentPos > 0) && (!b1))
                                        {
                                            if ((expression[CurrentPos - 2].ToString() == "d") || (expression[CurrentPos - 2].ToString() == "(") || (expression[CurrentPos - 2].ToString() == "+") || (expression[CurrentPos - 2].ToString() == "-") || (expression[CurrentPos - 2].ToString() == "*") || (expression[CurrentPos - 2].ToString() == "/"))
                                                b1 = true;
                                        }
                                        if ((b2) && (b1))
                                        {
                                            expression = expression.Insert(CurrentPos + 1, " ");
                                            CurrentPos += 2;
                                            break;
                                        }
                                        else
                                        {
                                            ShowMessege = true;
                                            expression = "Error 01 at " + CurrentPos.ToString();
                                            return expression;
                                        }
                                    }
                                }
                                break;
                            }

                        //----------------------------------------------------------------------------------------------------------  

                        default:
                            ShowMessege = true;
                            expression = "error 02 at " + CurrentPos.ToString();
                            return expression;
                    }
                }
                expression = expression.Trim();
                return expression;
            }
            catch
            {
                ShowMessege = true;
                return expression = "error 06";
            }
        }


        public static ArrayList CreateStack()
        {
            ArrayList Stack = new ArrayList();
            string[] tokens = Expression.Split(' ');
            Stack<string> tmp = new Stack<string>();
            int n;

            foreach (string s in tokens)
            {
                if (int.TryParse(s.ToString(), out n))
                {
                    Stack.Add(s);
                }
                if (s == "(")
                {
                    tmp.Push(s);
                }
                if (s == ")")
                {
                    while (tmp.Count != 0 && tmp.Peek() != "(")
                    {
                        Stack.Add(tmp.Pop());
                    }
                    tmp.Pop();
                }
                if ("+-mp*/%".Contains(s))
                {
                    while (tmp.Count != 0 && Priority(tmp.Peek()) >= Priority(s))
                    {
                        Stack.Add(tmp.Pop());
                    }
                    tmp.Push(s);
                }
            }
            while (tmp.Count != 0)
            {
                Stack.Add(tmp.Pop());
            }

            return Stack;
        }
        public static string RunEstimate()
        {
            ArrayList Stack = CreateStack();
            Stack<int> tmp = new Stack<int>();
            int n;

            foreach (string s in Stack)
            {
                if (int.TryParse(s, out n))
                {
                    tmp.Push(n);
                }
                else
                {
                    switch (s)
                    {
                        case "*":
                            {
                                tmp.Push(MathLibrary.Mult(tmp.Pop(), tmp.Pop()));
                                if (MathLibrary.lastError.Length > 0)
                                {
                                    ShowMessage = true;
                                    Expression = MathLibrary.lastError;
                                    
                                    return Expression;
                                }
                                break;
                            }
                        case "/":
                            {
                                n = tmp.Pop();
                                tmp.Push(MathLibrary.Div(tmp.Pop(), n));
                                if (MathLibrary.lastError.Length > 0)
                                {
                                    ShowMessage = true;
                                    Expression = MathLibrary.lastError;
                                    MathLibrary.lastError = "";
                                    return Expression;
                                }
                                break;
                            }
                        case "%":
                            {
                                n = tmp.Pop();
                                tmp.Push(MathLibrary.Mod(tmp.Pop(), n));
                                if (MathLibrary.lastError.Length > 0)
                                {
                                    ShowMessage = true;
                                    Expression = MathLibrary.lastError;
                                    MathLibrary.lastError = "";
                                    return Expression;
                                }
                                break;
                            }
                        case "+":
                            {
                                tmp.Push(MathLibrary.Add(tmp.Pop(), tmp.Pop()));
                                if (MathLibrary.lastError.Length > 0)
                                {
                                    ShowMessage = true;
                                    Expression = MathLibrary.lastError;

                                    return Expression;
                                }
                                break;
                            }
                        case "-":
                            {
                                n = tmp.Pop();
                             //   if (tmp.Count == 0) tmp.Push(MathLibrary.IABS(n));
                                /*else*/ tmp.Push(MathLibrary.Sub(tmp.Pop(), n));
                                if (MathLibrary.lastError.Length > 0)
                                {
                                    ShowMessage = true;
                                    Expression = MathLibrary.lastError;
                                    return Expression;
                                }
                                break;
                            }
                        case "m":
                            {
                                tmp.Push(MathLibrary.IABS(tmp.Pop()));
                                if (MathLibrary.lastError.Length > 0)
                                {
                                    ShowMessage = true;
                                    Expression = MathLibrary.lastError;
                                    return Expression;
                                }
                                break;
                            }
                        case "p":
                            {
                                tmp.Push(MathLibrary.ABS(tmp.Pop()));
                                if (MathLibrary.lastError.Length > 0)
                                {
                                    ShowMessage = true;
                                    Expression = MathLibrary.lastError;
                                    return Expression;
                                }
                                break;
                            }
                        default:
                            {
                                ShowMessage = true;
                                Expression = "Error in calculating";
                                return Expression;
                            }
                    }
                }
            }

            return tmp.Pop().ToString();
        }
        public static string Estimate()
        {
            if (!CheckCurrency())
            {
                ShowMessage = false;
                return Expression;
            }
            Expression = Format();
            Expression = RunEstimate();
            ShowMessage = false;
            return Expression;
        }
        public static int Priority(string s)
        {
            if (s == "*" || s == "/" || s == "%")
                return 2;
            else if (s == "+" || s == "-" || s == "m" || s == "p")
                return 1;
            else return 0;
        }
    }
}
