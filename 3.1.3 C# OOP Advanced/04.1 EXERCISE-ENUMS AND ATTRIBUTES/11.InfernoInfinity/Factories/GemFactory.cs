using InfernoInfinity.Enums;
using InfernoInfinity.Interfaces;
using InfernoInfinity.Models.Gems;
using System;

namespace InfernoInfinity.Factories
{
    public class GemFactory
    {
        internal IGem CreateGem(string gemType, string gemClarity)
        {
            GemClarity clarity;
            var isClarityValid = Enum.TryParse(gemClarity, out clarity);

            if (!isClarityValid)
            {
                return null;
            }

            switch (gemType)
            {
                case "Ruby":
                    return new Ruby(clarity);
                case "Emerald":
                    return new Emerald(clarity);
                case "Amethyst":
                    return new Amethyst(clarity);
                default:
                    return null;
            }
        }
    }
}
