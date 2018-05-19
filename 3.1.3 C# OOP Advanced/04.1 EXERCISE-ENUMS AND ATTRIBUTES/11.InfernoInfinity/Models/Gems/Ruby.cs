using InfernoInfinity.Enums;

namespace InfernoInfinity.Models.Gems
{
    public class Ruby : Gem
    {
        private new const int StrengthBonus = 7;
        private new const int AgilityBonus = 2;
        private new const int VitalityBonus = 5;

        public Ruby(GemClarity clarity)
            : base(StrengthBonus, AgilityBonus, VitalityBonus, clarity)
        {
        }
    }
}
