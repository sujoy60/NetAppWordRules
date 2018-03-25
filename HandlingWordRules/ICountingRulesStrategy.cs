using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingWordRules
{
	public interface ICountingRulesStrategy
	{
		float ruleImplementation(List<string> wordsInput);
	}
}
