using System;
using System.Linq;

namespace _4.JapaneseRoulette
{
    class JapaneseRoulette
    {
        static void Main()
        {
            var revolverCylinder = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var players = Console.ReadLine().Split().ToArray();

            var indexBullet = 0;

            for (int i = 0; i < revolverCylinder.Length; i++)
            {
                if (revolverCylinder[i] == 1)
                {
                    indexBullet = i;
                    break;
                }
            }

            var gotLucky = true;

            for (int i = 0; i < players.Length; i++)
            {
                var commandParams = players[i].Split(',');
                var power = int.Parse(commandParams[0]);
                var direction = commandParams[1];

                switch (direction)
                {
                    case "Right":
                        indexBullet = (indexBullet + power) % revolverCylinder.Length;
                        break;
                    case "Left":
                        if (indexBullet - power < 0)
                        {
                            indexBullet = revolverCylinder.Length - (Math.Abs(indexBullet - power) % revolverCylinder.Length);
                        }
                        else
                        {
                            indexBullet = indexBullet - power;
                        }
                        break;
                }

                if (indexBullet == 2)
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    gotLucky = false;
                    break;
                }

                indexBullet = indexBullet + 1 == revolverCylinder.Length ? 0 : indexBullet + 1;
            }

            if (gotLucky)
            {
                Console.WriteLine("Everybody got lucky!");
            }
        }
    }
}
