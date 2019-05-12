using _3.DependencyInversion.Strategies;
using System.Collections.Generic;

namespace _3.DependencyInversion
{
    public class PrimitiveCalculator
    {
        private IStrategy _strategy;
        private IDictionary<char, IStrategy> _strategies;
        
        public PrimitiveCalculator(IStrategy strategy, IDictionary<char, IStrategy> strategies)
        {
            _strategy = strategy;
            _strategies = strategies;
        }

        public void ChangeStrategy(char @operator)
        {
            _strategy = _strategies[@operator];
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
        {
            return _strategy.Calculate(firstOperand, secondOperand);
        }
    }
}
