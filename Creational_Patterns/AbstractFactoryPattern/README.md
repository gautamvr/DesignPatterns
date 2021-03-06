# Abstract Factory Pattern

This pattern provides the creational strategy through the abstract layer without having to know about the concrete creator class.

It internally uses the factory pattern. The factories here are also abstracted so that when a new requirements is added, a seperate factory could also be added, while the data layer uses only the abstract of the factory.

The example added deals with creating a Data Access Layer through Abstract Factory pattern for 2 types of Databases. If any other types of database needs to be added, only it's respective concrete class can be added. (The Data Access Layer need not be touched)

## UML Diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Creational_Patterns/AbstractFactoryPattern/AbstractFactoryPattern_DataAccessLayer.PNG)
