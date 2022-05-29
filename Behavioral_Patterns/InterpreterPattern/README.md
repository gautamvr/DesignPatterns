# Interpreter Pattern

Interpreter pattern is used to have a set of rules to evaluate a particular context object according to our needs. The set of rules or each evaluator can be defined seperately and applied to the context object by passing th context object to the each reqruired evaluatores.
This way the order of the evaluation for the context object is maintained.

In the example, we have added a set of evaluators for the format of date of the DateContext object. The each set of evaluators are applied in the order provided by the client code and the resultant expression for the date is displayed as per the evaluation.


### UML diagram:
![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/InterpreterPattern/InterpreterPatternUML.PNG)
