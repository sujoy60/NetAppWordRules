using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HandlingWordRules;

namespace ClientForWordApp
{
	//This is the client program .The Words rule program is called from here.
	class Program
	{
		static void Main(string[] args)
		{
			//This is the list of words that is provided for testing
			List<string> data = new List<string> {"Chad","Australia" ,"Chinese", "Arab", "Indian", "African", "Canadian", "Azerbaijani", "Egyptian" ,"Bile","Beleize","Beligium", "Mozambique" };

			WordsRuleContext sortingContext = new WordsRuleContext();

			float result = 0;
			
			//For all the words starts with “a” or “A”, count the average length of the words, save the result to file
			//“average_length_of_words_starting_with_a.txt”
			result = sortingContext.GetAnswer("Rule1", data);

			//For all the words starts with “b” or “B”, count the total number of “e” or “E” in the words, save the
			//result to file “count_of_e_in_words_starting_with_b.txt”
			result = sortingContext.GetAnswer("Rule2", data);

			//For all the words starts with “a” or “b” or “c”, get the longest length of the words.Save the result to
			//file “longest_words_starting_with_abc.txt”
			result = sortingContext.GetAnswer("Rule3", data);

			//For all the words starts with “c” or “C”, if the next word starts with “a” or “A”, count the number of this
			//sequence.Save the result to “count_of_sequence_of_words_starting_withs_c_and_a.txt”
			result = sortingContext.GetAnswer("Rule4", data);
			



		}


	}
}
