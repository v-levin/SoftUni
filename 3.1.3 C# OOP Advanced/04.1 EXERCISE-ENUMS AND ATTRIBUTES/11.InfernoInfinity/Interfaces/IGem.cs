using InfernoInfinity.Enums;

namespace InfernoInfinity.Interfaces
{
    public interface IGem
    {
        int StrengthBonus { get; }

        int AgilityBonus { get; }

        int VitalityBonus { get; }

        GemClarity Clarity { get; }
    }
}
