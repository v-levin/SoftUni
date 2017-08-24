using System;
using System.Text;

namespace _5.StringCommander
{
    public class StringCommander
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            var commands = Console.ReadLine();

            var sb = new StringBuilder(inputText);

            while (commands != "end")
            {
                var commandsParts = commands.Split();
                var action = commandsParts[0];

                switch (action)
                {
                    case "Left":
                        var count = int.Parse(commandsParts[1]);
                        sb = LeftMove(sb, count);
                        break;
                    case "Right":
                        count = int.Parse(commandsParts[1]);
                        sb = MoveRight(sb, count);
                        break;
                    case "Insert":
                        var index = int.Parse(commandsParts[1]);
                        var str = commandsParts[2];
                        sb = Insert(sb, index, str);
                        break;
                    case "Delete":
                        var startIndex = int.Parse(commandsParts[1]);
                        var endIndex = int.Parse(commandsParts[2]);
                        sb = Delete(sb, startIndex, endIndex);
                        break;
                }

                commands = Console.ReadLine();
            }

            Console.WriteLine(sb.ToString());
        }

        private static StringBuilder Insert(StringBuilder sb, int index, string str)
        {
            sb.Insert(index, str);
            return sb;
        }

        private static StringBuilder Delete(StringBuilder sb, int startIndex, int endIndex)
        {
            sb.Remove(startIndex, endIndex + 1);
            return sb;
        }

        private static StringBuilder MoveRight(StringBuilder sb, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var tempChar = sb[sb.Length - 1];
                sb.Remove(sb.Length - 1, 1);
                sb.Insert(0, tempChar);
            }

            return sb;
        }

        private static StringBuilder LeftMove(StringBuilder sb, int count)
        {
            for (int i = 0; i < count; i++)
            {
                var tempChar = sb[0];
                sb.Remove(0, 1);
                sb.Insert(sb.Length, tempChar);
            }

            return sb;
        }
    }
}
