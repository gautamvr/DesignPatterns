# Facade Pattern

This pattern is used to hide all the complex interactions in a subsubsystem and provide the basic interface which handles all the complex interaction across different components in a subsystem.

In our example, we have a facade class, ScanController which is the one that's exposed to the client. The ScanController controls the flow logic and the interactions across various components such as ImageGenerator,ImageDataStore,ExamcardManager,ImageAnnotator,ScanTimer, etc.
So here, the client does not need to be aware of all these interactions. This way if the interaction or some core functionality needs to be changed, it could be changed without the client being aware of.

## UML Diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Structural_Patterns/FacadePattern/FacadePatternUML.PNG)
