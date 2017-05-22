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

        public static string Format()
        {
            for (int i = 0; i < Expression.Length; i++)
            {
                if (i == Expression.Length - 1) break;
                if ("()+-mp%*/".Contains(Expression[i])) Expression = Expression.Insert(i + 1, " ");
                if ("0123456789".Contains(Expression[i]))
                {
                    if ("0123456789".Contains(Expression[i + 1])) continue;
                    else Expression = Expression.Insert(i + 1, " ");
                }
            }
            return Expression;
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
