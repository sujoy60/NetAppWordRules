using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingWordRules
{
	public class cntOfSqcWrdsStartCA : ICountingRulesStrategy
	{

		//Requirement 4/Rule 4 : For all the words starts with “c” or “C”, if the next word starts with “a” or “A”, count the number of this
		//sequence.Save the result to “count_of_sequence_of_words_starting_withs_c_and_a.txt”

		//The method: ruleImplementation gets  implemented with the business requirement

		public float ruleImplementation(List<string> inputWordsList)
		{
			int posOfWordStartWithA;
			float SqcWrdsStartCA = 0;
			foreach (string innerString in inputWordsList)
			{
				if (innerString.StartsWith("C"))
				{
					posOfWordStartWithA = inputWordsList.IndexOf(innerString);
					if (inputWordsList[posOfWordStartWithA + 1].StartsWith("A")) { SqcWrdsStartCA++; };

				}
			}

            //writes to file
            WriteToTextFile wt = new WriteToTextFile();
            wt.writeToFile(SqcWrdsStartCA, @"C:\Users\Public\TestFolder\count_of_sequence_of_words_starting_withs_c_and_a.txt");

            return SqcWrdsStartCA;

			//throw new NotImplementedException();
		}

	}
}
