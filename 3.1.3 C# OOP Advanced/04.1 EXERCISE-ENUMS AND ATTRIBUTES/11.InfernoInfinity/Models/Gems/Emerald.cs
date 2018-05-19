using InfernoInfinity.Enums;

namespace InfernoInfinity.Models.Gems
{
    public class Emerald : Gem
    {
        private new const int StrengthBonus = 1;
        private new const int AgilityBonus = 4;
        private new const int VitalityBonus = 9;

        public Emerald(GemClarity clarity)
            : base(StrengthBonus, AgilityBonus, VitalityBonus, clarity)
        {
        }
    }
}
