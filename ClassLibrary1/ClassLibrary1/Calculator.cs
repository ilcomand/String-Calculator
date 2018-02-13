using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary1
{
    public class Calculator
    {
        public int Calculate(string input)
        {
            //var separators = new[] { ',', '\n' };
            var separators = new List<char> { ',', '\n' };

            if (string.IsNullOrWhiteSpace(input)) return 0;
            input = ReplaceCrLf(input);

            if (ContainsCustomSeparator(input))
            {
                separators.Add(input[2]);
                //separators = AddSeparators(separators, input[2]);
                input = input.Substring(4);
            }

            var splittedNumbers = input.Split(separators.ToArray(), StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;
            foreach (var n in splittedNumbers)
            {
                sum += int.Parse(n);
            }
            
            return sum;
        }

        private static string ReplaceCrLf(string input)
        {
            return input.Replace("\r\n", "\n");
        }           

        private bool ContainsCustomSeparator(string numbers)
        {
            return numbers.StartsWith("//");            
        }

        private char[] AddSeparators(char[] separators, char myseparator)
        {            
            char[] separatorsNew = new char[separators.Length + 1];

            for (int i = 0; i < separators.Length; i++)
            {
                separatorsNew[i] = separators[i];
            }

            separatorsNew[separatorsNew.Length - 1] = myseparator;
            return separatorsNew;
        }
    }
}
