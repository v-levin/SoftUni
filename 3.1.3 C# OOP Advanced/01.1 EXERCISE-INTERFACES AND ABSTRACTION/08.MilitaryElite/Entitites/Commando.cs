using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilitaryElite.Interfaces;

namespace MilitaryElite.Entitites
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, string corps, IList<IMission> missions) : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public IList<IMission> Missions { get; private set; }

        public void CompleteMission()
        {
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{base.ToString()}" + Environment.NewLine);
            sb.AppendLine("Missions:");
            sb.AppendLine($"  {string.Join(Environment.NewLine + "  ", this.Missions)}");

            return sb.ToString().Trim();
        }
    }
}
