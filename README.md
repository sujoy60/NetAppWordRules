This is a .NET application using Strategy Pattern with a search pattern to evaluate an array of strings . The rules are implemented as part of a strategy pattern interface ICountingRulesStrategy. So, all the algorithms have been isolated into separate classes in order to have the ability to select different algorithm at runtime. And, strategy design pattern is best for this type of case.
This repository has the rules logic in the project : HandlingWordRules .The client application : ClientForWordApp calls the HandlingWordRules
project.
The HandlingWordRules project has the GetAnswer method  consumes the request from the client. This request is received by a dictionary "_strategies" defined 
in the class. The "_strategies" instantiates the relevant rule that is requested by the client.
The HandlingWordRules project has the "WordsRuleContext" class that defines a dictionary "_strategies" which has the key value pair of string and strategy representing the rules interface.



