using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingWordRules
{
	public class cntEinWrdsStartB : ICountingRulesStrategy
	{

		//Requirement 2/Rule 2 : For all the words starts with “b” or “B”, count the total number of “e” or “E” in the words, save the
		//result to file “count_of_e_in_words_starting_with_b.txt”

		//The method: ruleImplementation gets  implemented with the business requirement
		public float ruleImplementation(List<string>  inputWordsList)
		{			
			var filteredList = inputWordsList.AsEnumerable().Where(lambda => lambda.StartsWith("B"));
			float totalEinFilteredList = filteredList.AsEnumerable().Where(x => x.Contains("e")).LongCount();

            //writes to file
            WriteToTextFile wt = new WriteToTextFile();
            wt.writeToFile(totalEinFilteredList, @"C:\Users\Public\TestFolder\count_of_e_in_words_starting_with_b.txt");

            return totalEinFilteredList;
            //throw new NotImplementedException();
		}

	}
}
