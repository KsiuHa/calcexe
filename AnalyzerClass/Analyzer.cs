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


        public static System.Collections.ArrayList CreateStack()
        {
            try
            {
                String[] Exp = expression.Split(' ');
                System.Collections.ArrayList FinalStack = new System.Collections.ArrayList();
                System.Collections.ArrayList Stack = new System.Collections.ArrayList();

                int cur = 0;
                while (cur < Exp.Length)
                {
                    bool b1 = false;
                    int b = -1;
                    // якщо число 0-9
                    for (int i = 0; i < 10; i++)
                    {
                        if (Exp[cur][0].ToString() == i.ToString())
                        {
                            b1 = true;
                            break;
                        }
                    }
                    if (b1)
                    {
                        FinalStack.Add(Exp[cur].ToString());
                        cur++;
                        continue;
                    }
                    if ((Exp[cur].ToString() == "m") || (Exp[cur].ToString() == "p"))
                    {
                        Stack.Add(Exp[cur].ToString());
                        cur++;
                        continue;
                    }
                    //        Якщо "+" "-"
                    if ((Exp[cur] == "+") || (Exp[cur] == "-"))
                    {
                        if (Stack.Count > 0)
                        {
                            if (Stack[Stack.Count - 1].ToString() != "(")
                            {
                                b = 2;
                            }
                            else
                            {
                                b = 1;
                            }
                        }
                        else
                        {
                            b = 1;
                        }
                    }
                    //якщо *, /, мод
                    if ((Exp[cur] == "*") || (Exp[cur] == "/") || (Exp[cur] == "mod"))
                    {
                        if (Stack.Count > 0)
                        {
                            if (!((Stack[Stack.Count - 1].ToString() == "(") || (Stack[Stack.Count - 1].ToString() == "+") || (Stack[Stack.Count - 1].ToString() == "-")))
                            {
                                b = 3;
                            }
                            else
                            {
                                b = 1;
                            }
                        }
                        else
                        {
                            b = 1;
                        }
                    }
                    if ((Exp[cur] == "("))
                    {
                        b = 1;
                    }
                    if ((Exp[cur] == ")"))
                    {
                        b = 4;
                    }
                    //----------------------
                    switch (b)
                    {
                        case 1:
                            Stack.Add(Exp[cur]);
                            cur++;
                            break;
                        case 2:
                            b1 = false;
                            while (!b1)
                            {
                                FinalStack.Add(Stack[Stack.Count - 1]);
                                Stack.RemoveAt(Stack.Count - 1);
                                if (Stack.Count > 0)
                                {
                                    if (Stack[Stack.Count - 1].ToString() == "(")
                                    {
                                        Stack.Add(Exp[cur]);
                                        cur++;
                                        b1 = true;
                                    }
                                }
                                else
                                {
                                    Stack.Add(Exp[cur]);
                                    cur++;
                                    b1 = true;
                                }
                            }
                            break;
                        case 3:
                            b1 = false;
                            while (!b1)
                            {
                                FinalStack.Add(Stack[Stack.Count - 1]);
                                Stack.RemoveAt(Stack.Count - 1);
                                if (Stack.Count > 0)
                                {
                                    if ((Stack[Stack.Count - 1].ToString() == "(") || (Stack[Stack.Count - 1].ToString() == "+") || (Stack[Stack.Count - 1].ToString() == "-"))
                                    {
                                        Stack.Add(Exp[cur]);
                                        cur++;
                                        b1 = true;
                                    }
                                }
                                else
                                {
                                    Stack.Add(Exp[cur]);
                                    cur++;
                                    b1 = true;
                                }
                            }
                            break;
                        case 4:
                            b1 = false;
                            while (!b1)
                            {
                                FinalStack.Add(Stack[Stack.Count - 1]);
                                Stack.RemoveAt(Stack.Count - 1);

                                if (Stack[Stack.Count - 1].ToString() == "(")
                                {
                                    Stack.RemoveAt(Stack.Count - 1);
                                    cur++;
                                    b1 = true;
                                }
                            }
                            break;
                        default:
                            FinalStack.Clear();
                            Stack.Clear();
                            ShowMessege = true;
                            cur = Exp.Length;
                            FinalStack.Add("error 03");
                            break;
                    }
                }
                while (Stack.Count > 0)
                {
                    FinalStack.Add(Stack[Stack.Count - 1]);
                    Stack.RemoveAt(Stack.Count - 1);
                }
                System.Collections.ArrayList MyStack = new System.Collections.ArrayList(expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                MyStack = FinalStack;
                return MyStack;
            }
            catch
            {
                System.Collections.ArrayList FinalStack = new System.Collections.ArrayList();
                ShowMessege = true;
                FinalStack.Add("error 03");
                return FinalStack;
            }
        }


        public static string RunEstimate(System.Collections.ArrayList Exp)
        {
            try
            {
                int k = 0, a, b, res;
                while (Exp.Count > 1)
                {
                    if (!(("*".Equals(Exp[k])) || ("/".Equals(Exp[k])) || ("+".Equals(Exp[k])) || (("-".Equals(Exp[k])) || ("mod".Equals(Exp[k])))))
                    {
                        if ("m".Equals(Exp[k]) || ("p".Equals(Exp[k])))
                        {
                            a = int.Parse(Exp[k - 1].ToString());
                            if ("p".Equals(Exp[k]))
                            {
                                res = a;
                            }
                            else
                            {
                                res = int.Parse(Class1.IABS(a).ToString());
                                if (Class1._lastError.Length > 0)
                                {
                                    ShowMessege = true;
                                    expression = Class1._lastError;
                                    return expression;
                                }
                            }
                            Exp.RemoveAt(k);
                            Exp.RemoveAt(k - 1);

                            Exp.Insert(k - 1, res.ToString());
                            k -= 1;
                        }
                        k++;
                    }
                    else
                    {
                        try
                        {
                            a = int.Parse(Exp[k - 2].ToString());
                            b = int.Parse(Exp[k - 1].ToString());
                        }
                        catch
                        {
                            ShowMessege = true;
                            expression = "error 06";
                            return expression;
                        }

                        switch (Exp[k].ToString())
                        {
                            case "+":
                                res = Class1.Add(a, b);
                                if (Class1._lastError.Length > 0)
                                {
                                    ShowMessege = true;
                                    expression = Class1._lastError;
                                    Class1._lastError = "";
                                    return expression;
                                }
                                break;
                            case "-":
                                res = Class1.Sub(a, b);
                                if (Class1._lastError.Length > 0)
                                {
                                    ShowMessege = true;
                                    expression = Class1._lastError;
                                    Class1._lastError = "";
                                    return expression;
                                }
                                break;
                            case "*":
                                res = Class1.Mult(a, b);
                                if (Class1._lastError.Length > 0)
                                {
                                    ShowMessege = true;
                                    expression = Class1._lastError;
                                    Class1._lastError = "";
                                    return expression;
                                }
                                break;
                            case "/":
                                res = Class1.Div(a, b);
                                if (Class1._lastError.Length > 0)
                                {
                                    ShowMessege = true;
                                    expression = Class1._lastError;
                                    Class1._lastError = "";
                                    return expression;
                                }
                                break;
                            case "mod":
                                res = Class1.Mod(a, b);
                                if (Class1._lastError.Length > 0)
                                {
                                    ShowMessege = true;
                                    expression = Class1._lastError;
                                    Class1._lastError = "";
                                    return expression;
                                }
                                break;
                            default:
                                ShowMessege = true;
                                expression = "error 03";
                                return expression;
                        }
                        Exp.RemoveAt(k);
                        Exp.RemoveAt(k - 1);
                        Exp.RemoveAt(k - 2);
                        Exp.Insert(k - 2, res.ToString());
                        k -= 2;
                    }
                }
                return Exp[0].ToString();
            }
            catch
            {
                ShowMessege = true;
                expression = "error 03";
                return expression;
            }
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
