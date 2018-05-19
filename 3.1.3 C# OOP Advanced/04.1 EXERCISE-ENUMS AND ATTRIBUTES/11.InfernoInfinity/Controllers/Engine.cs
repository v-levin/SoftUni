using InfernoInfinity.Factories;
using InfernoInfinity.IO;
using System.Linq;

namespace InfernoInfinity.Controllers
{
    public class Engine
    {
        private InputReader reader;
        private OutputWriter writer;
        private WeaponManager manager;
        private GemFactory gemFactory;

        public Engine()
        {
            this.reader = new InputReader();
            this.writer = new OutputWriter();
            this.manager = new WeaponManager();
            this.gemFactory = new GemFactory();
        }

        public void Run()
        {
            var command = this.reader.ReadLine().Split(';');

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Create":
                        this.CreateWeapon(command.Skip(1).ToArray());
                        break;
                    case "Add":
                        this.AddGemToWeapon(command.Skip(1).ToArray());
                        break;
                    case "Remove":
                        this.RemoveGemFromWeapon(command.Skip(1).ToArray());
                        break;
                    case "Print":
                        var weaponName = command[1];
                        var weapon = this.manager.GetWeapon(weaponName);
                        this.writer.WriteLine(weapon.ToString());
                        break;
                    default:
                        break;
                }

                command = this.reader.ReadLine().Split(';');
            }
        }

        private void RemoveGemFromWeapon(string[] cmd)
        {
            var weaponName = cmd[0];
            var socketIndex = int.Parse(cmd[1]);

            this.manager.RemoveGemFromWeapon(weaponName, socketIndex);
        }

        private void AddGemToWeapon(string[] cmd)
        {
            var weaponName = cmd[0];
            var socketIndex = int.Parse(cmd[1]);
            var gemArgs = cmd[2].Split();
            var gemType = gemArgs[1];
            var gemClarity = gemArgs[0];

            var gem = this.gemFactory.CreateGem(gemType, gemClarity);

            if (gem == null)
            {
                return;
            }

            this.manager.AddGemToWeapon(weaponName, socketIndex, gem);
        }

        private void CreateWeapon(string[] cmd)
        {
            var weaponName = cmd[1];
            var weaponArgs = cmd[0].Split();
            var weaponType = weaponArgs[1];
            var weaponRarity = weaponArgs[0];

            this.manager.CreateWeapon(weaponName, weaponType, weaponRarity);
        }
    }
}
