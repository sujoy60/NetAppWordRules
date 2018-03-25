using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingWordRules
{
	#region Context

	public class Context
	{
		#region Members

		private static Dictionary<countingRules, ICountingRulesStrategy> _strategies = new Dictionary<countingRules, ICountingRulesStrategy>();

		#endregion

		#region Ctor

		public static Context()
		{
			_strategies.Add(countingRules.Rule1, new AvgLgthOfWdsStartA());
			_strategies.Add(countingRules.Rule2, new cntEinWrdsStartB());
			_strategies.Add(countingRules.Rule3, new longestWordsStrtABC());
		}

		#endregion

		#region Methods

		public static void ruleImplementation(countingRules title)
		{
			_strategies[title].ruleImplementation();
		}

		#endregion
	}

	#endregion
}
