using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;

namespace InfernoInfinity.Models.Gems
{
    public class Gem : IGem
    {
        public Gem(int strengthBonus, int agilityBonus, int vitalityBonus, GemClarity clarity)
        {
            this.StrengthBonus = strengthBonus;
            this.AgilityBonus = agilityBonus;
            this.VitalityBonus = vitalityBonus;
            this.Clarity = clarity;
        }

        public int StrengthBonus { get; private set; }

        public int AgilityBonus { get; private set; }

        public int VitalityBonus { get; private set; }

        public GemClarity Clarity { get; private set; }
    }
}
