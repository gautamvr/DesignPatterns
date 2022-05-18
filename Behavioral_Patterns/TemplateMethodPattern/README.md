# Template Method Pattern

This pattern is used to load a method with preloaded template and let the subclasses add the main logic for the core functionalities. Here, the template method invokes  other abstracted functions and performs various operations, regardless of the implementation of it's abstract functions.

In this example, we have created for Database accessor which has a template method for the set of operations that are needed to be done irrespective of the implementation. The sub-class, MSSQLDbAccessor implements all the core functionalities of the abstracted functions to it's own need.

So, in this case if the DB accessor is needed to be changed to a different DB, the sub-classes can only be changed and the implementation for the new DB functionalities can be added, while the main flow of the Database accessor remains intact. <strong>(Open for extension and closed for modification)</strong>

## UML Diagram :

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/TemplateMethodPattern/TemplateMethodPatternUML.PNG)
