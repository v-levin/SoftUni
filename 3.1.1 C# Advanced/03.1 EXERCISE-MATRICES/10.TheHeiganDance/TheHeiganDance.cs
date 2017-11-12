using System;

namespace _10.TheHeiganDance
{
    public class TheHeiganDance
    {
        public static void Main()
        {
            var playerRow = 7;
            var playerCol = 7;

            var playerHP = 18500;
            var hegianHP = 3000000D;

            var isHitByCloud = false;
            var spell = string.Empty;

            var playerDamage = double.Parse(Console.ReadLine());

            while (true)
            {
                if (isHitByCloud)
                {
                    playerHP -= 3500;
                    isHitByCloud = false;
                }

                hegianHP -= playerDamage;

                if (IsGameOver(playerRow, playerCol, playerHP, hegianHP, spell))
                {
                    break;
                }

                var attackParams = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                spell = attackParams[0];
                var hitRow = int.Parse(attackParams[1]);
                var hitCol = int.Parse(attackParams[2]);

                if (IsCellReached(playerRow, playerCol, hitRow, hitCol) && IsPlayerHit(ref playerRow, ref playerCol, hitRow, hitCol))
                {
                    switch (spell)
                    {
                        case "Cloud":
                            playerHP -= 3500;
                            isHitByCloud = true;
                            break;
                        case "Eruption":
                            playerHP -= 6000;
                            break;
                    }
                }

                if (IsGameOver(playerRow, playerCol, playerHP, hegianHP, spell))
                {
                    break;
                }
            }
        }

        private static bool IsGameOver(int playerRow, int playerCol, int playerHP, double hegianHP, string spell)
        {
            if (playerHP <= 0 || hegianHP <= 0)
            {
                if (spell == "Cloud")
                {
                    spell = "Plague Cloud";
                }

                if (playerHP > 0)
                {
                    Console.WriteLine($"Heigan: Defeated!\nPlayer: {playerHP}");
                }
                else if (hegianHP > 0)
                {
                    Console.WriteLine($"Heigan: {hegianHP:F2}\nPlayer: Killed by {spell}");
                }
                else
                {
                    Console.WriteLine($"Heigan: Defeated!\nPlayer: Killed by {spell}");
                }

                Console.WriteLine($"Final position: {playerRow}, {playerCol}");

                return true;
            }

            return false;
        }

        private static bool IsCellReached(int playerRow, int playerCol, int hitRow, int hitCol)
        {
            return (playerRow >= hitRow - 1) && (playerRow <= hitRow + 1) && (playerCol >= hitCol - 1) && (playerCol <= hitCol + 1);
        }

        private static bool IsPlayerHit(ref int playerRow, ref int playerCol, int hitRow, int hitCol)
        {
            if (playerRow > 0 && !IsCellReached(playerRow - 1, playerCol, hitRow, hitCol))
            {
                playerRow--;
                return false;
            }

            if (playerCol + 1 < 15 && !IsCellReached(playerRow, playerCol + 1, hitRow, hitCol))
            {
                playerCol++;
                return false;
            }

            if (playerRow + 1 < 15 && !IsCellReached(playerRow + 1, playerCol, hitRow, hitCol))
            {
                playerRow++;
                return false;
            }

            if (playerCol > 0 && !IsCellReached(playerRow, playerCol - 1, hitRow, hitCol))
            {
                playerCol--;
                return false;
            }

            return true;
        }
    }
}
