using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingWordRules
{
	public class longestWordsStrtABC : ICountingRulesStrategy
	{
		//Requirement 3/Rule 3 : For all the words starts with “a” or “b” or “c”, get the longest length of the words. Save the result to
		//file “longest_words_starting_with_abc.txt”

		//The method: ruleImplementation gets  implemented with the business requirement
		public float ruleImplementation(List<string>  inputWordsList)
		{
			var filteredList = inputWordsList.AsEnumerable().Where(lambda => lambda.StartsWith("A") || lambda.StartsWith("B") || lambda.StartsWith("C"));
			float longestWordLength = filteredList.Max(n => n.Length);

            //writes to file
            WriteToTextFile wt = new WriteToTextFile();
            wt.writeToFile(longestWordLength, @"C:\Users\Public\TestFolder\longest_words_starting_with_abc.txt");


            return longestWordLength;

			//throw new NotImplementedException();
		}

	}
}
