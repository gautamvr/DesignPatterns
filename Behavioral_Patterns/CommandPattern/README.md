# Command Pattern

Command pattern is used in cases of when a specific command is to be sent as an object. This way, the command object can be stored for undo operations etc.
This pattern allows for other interesting use case like passing commands as method arguments, store them inside other objects, switch linked commands at runtime, etc.

In the given example, we have used this command pattern to perform some action when planning on MRPlanViewer so that the actions can be sent as a command object by the respective command classes. The MRPlanViewer can store these commands in the command stack and use it for Undo behaviour.
### UML diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/CommandPattern/CommandPatternUML.PNG)
