using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Entitites
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps, IList<IRepair> parts) : base(id, firstName, lastName, salary, corps)
        {
            this.Parts = parts;
        }

        public IList<IRepair> Parts { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Repairs:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Parts)}");

            return sb.ToString().Trim();
        }
    }
}
