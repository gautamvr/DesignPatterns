# Factory Pattern

This is a simple and a widely used pattern which is used to create objects when the creator of the object doesn't have any idea of what object it has to create, leaving the responsibility of the creation to a seperate factory class.

The factory class will be creating the respective object as per the needs and return the newly created object. If any modification for the object needs to be done, it can done in the factory class, without affecting the class which uses the object.


In the example, we create a DBTable object using a Factory class which creates a OracleDbTable. The user of this class need not be aware of which specific class the factory creates.

## UML Diagram:
![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Creational_Patterns/FactoryPattern/FactoryPatternUML.PNG)
