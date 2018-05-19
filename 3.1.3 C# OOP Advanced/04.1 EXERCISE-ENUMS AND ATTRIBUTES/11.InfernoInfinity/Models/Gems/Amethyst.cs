using InfernoInfinity.Enums;

namespace InfernoInfinity.Models.Gems
{
    public class Amethyst : Gem
    {
        private new const int StrengthBonus = 2;
        private new const int AgilityBonus = 8;
        private new const int VitalityBonus = 4;

        public Amethyst(GemClarity clarity)
            : base(StrengthBonus, AgilityBonus, VitalityBonus, clarity)
        {
        }
    }
}
