using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingWordRules
{
	public class WordsRuleContext
	{
		//Dictionary to comtainthe rule nameswith the strategy. The Strategy pattern has  been used  here.

		private  Dictionary<string, ICountingRulesStrategy> _strategies = new Dictionary<string, ICountingRulesStrategy>();
		
		public WordsRuleContext()
		{
			_strategies.Add("Rule1", new AvgLgthOfWdsStartA());
			_strategies.Add("Rule2", new cntEinWrdsStartB());
			_strategies.Add("Rule3", new longestWordsStrtABC());
			_strategies.Add("Rule4", new cntOfSqcWrdsStartCA());
		}

		//Method that gets called by the client with the rule chosen.The rule is searched and the corresponding implementation
		// is executed with the data that has been pased by the client 
		public float GetAnswer(string searchType, List<string> wordsInput)
		{
			return _strategies[searchType].ruleImplementation(wordsInput);
		}
	}
}
