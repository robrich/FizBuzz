using System;
using System.Collections.Generic;

namespace FizBuzzLib
{
    public interface IFizBuzzCalculator
    {
        /// <summary>
        /// Return a list of FizBuzz from 1 to upperBounds
        /// </summary>
        IEnumerable<string> GetAllValues(int upperBounds);
    }

    public class FizBuzzCalculator : IFizBuzzCalculator
    {
        // TODO: consider a POCO for a rule if this tuple is too confusing to users
        private readonly List<(int Number, string Answer)> rules;

        private readonly static List<(int, string)> DEFAULT_RULES = new List<(int, string)>
        {
            (3,"Fiz"),
            (5,"Buzz")
        };

        /// <summary>
        /// Create a calculator with the standard rules
        /// </summary>
        public FizBuzzCalculator() : this(DEFAULT_RULES) { }

        /// <summary>
        /// Create a calculator with user-defined rules<br />
        /// This replaces the built-in rules
        /// </summary>
        /// <param name="rules">A list of number, string response pairs. For all other values, the numbers will be returned</param>
        public FizBuzzCalculator(List<(int Number, string Answer)> rules)
        {
            this.rules = rules ?? throw new ArgumentNullException(nameof(rules));
            if (rules.Count < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(rules));
            }
        }

        /// <summary>
        /// Return a list of FizBuzz from 1 to upperBounds
        /// </summary>
        public IEnumerable<string> GetAllValues(int upperBounds)
        {
            for (int i = 1; i <= upperBounds; i++)
            {
                yield return GetValue(i);
            }
        }

        // public for testing, not part of interface
        public string GetValue(int number)
        {
            string value = "";
            foreach (var rule in this.rules)
            {
                if (number % rule.Number == 0)
                {
                    value += rule.Answer;
                }
            }
            if (string.IsNullOrEmpty(value))
            {
                value = number.ToString();
            }
            return value;
        }

    }
}
