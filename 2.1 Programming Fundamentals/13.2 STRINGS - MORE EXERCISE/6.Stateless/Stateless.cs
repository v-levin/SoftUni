using System;

namespace _6.Stateless
{
    public class Stateless
    {
        public static void Main()
        {
            var state = Console.ReadLine();

            while (state != "collapse")
            {
                var fiction = Console.ReadLine();

                while (fiction.Length > 0)
                {
                    var index = 0;
                    while (state.Contains(fiction))
                    {
                        index = state.IndexOf(fiction);
                        state = state.Remove(index, fiction.Length).Trim();
                    }

                    fiction = NewMethod(fiction);
                }

                if (state.Length > 0)
                {
                    Console.WriteLine(state);
                }
                else
                {
                    Console.WriteLine("(void)");
                }

                state = Console.ReadLine();
            }
        }

        private static string NewMethod(string fiction)
        {
            fiction = fiction.Remove(0, 1);

            if (fiction.Length > 0)
            {
                fiction = fiction.Remove(fiction.Length - 1, 1);
            }

            return fiction;
        }
    }
}
