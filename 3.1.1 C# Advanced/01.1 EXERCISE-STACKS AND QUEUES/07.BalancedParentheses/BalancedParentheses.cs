using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.BalancedParentheses
{
    public class BalancedParentheses
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var openedParentheses = new Stack<char>();
            var openCases = new char[] { '{', '(', '[' };

            foreach (var character in inputLine)
            {
                if (openCases.Contains(character))
                {
                    openedParentheses.Push(character);
                }
                else
                {
                    if (openedParentheses.Count == 0)
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    switch (character)
                    {
                        case '}':
                            if (openedParentheses.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;

                        case ')':
                            if (openedParentheses.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;

                        case ']':
                            if (openedParentheses.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;
                            }
                            break;
                    }
                }
            }

            Console.WriteLine("YES");
        }
    }
}
