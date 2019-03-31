using System;
using System.Collections;
using System.Linq;
using System.Text.RegularExpressions;

namespace chackparenthesis
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("input parenthesis string:");
            string strParenthesis = Console.ReadLine();
            bool result = CheckString(strParenthesis);
            if (result)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.ReadLine();
        }

        public static bool CheckString(string exp)
        {
            bool result = true;
            char[] strParenthesisToChar = exp.ToCharArray();
            Stack stack = new Stack();

            foreach (char simvolChar in strParenthesisToChar)
            {
                string simvol = simvolChar.ToString();
                if (simvol == "[" || simvol == "{" || simvol == "(")
                    stack.Push(simvol);
                else if (stack.Count > 0)
                {
                    if (simvol == "]")
                    {
                        if (stack.Peek().ToString() == "[")
                            stack.Pop();
                        else
                            result = false;
                    }
                    else if (simvol == "}")
                    {
                        if (stack.Peek().ToString() == "{")
                            stack.Pop();
                        else
                            result = false;
                    }
                    else if (simvol == ")")
                    {
                        if (stack.Peek().ToString() == "(")
                            stack.Pop();
                        else
                            result = false;
                    }
                }
                else
                    result = false;
            }
            return result;
        }
    }
}