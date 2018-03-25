using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingWordRules
{
	public class AvgLgthOfWdsStartA : ICountingRulesStrategy
	{

		//Requirement 1/Rule 1 : For all the words starts with “a” or “A”, count the average length of the words, save the result to file
		//“average_length_of_words_starting_with_a.txt”

		//The method: ruleImplementation gets  implemented with the business requirement
		public float ruleImplementation(List<string>  inputWordsList)
		{
			var filteredList = inputWordsList.AsEnumerable().Where(lambda => lambda.StartsWith("A"));
			var filteredListLength = filteredList.AsEnumerable().Sum(lambda => lambda.Length);
			float avgLength = filteredListLength / filteredList.Count();

            //writes to file
            WriteToTextFile wt = new WriteToTextFile();
            wt.writeToFile(avgLength, @"C:\Users\Public\TestFolder\average_length_of_words_starting_with_a.txt");

            return avgLength;



			//throw new NotImplementedException();
		}


	}
}
