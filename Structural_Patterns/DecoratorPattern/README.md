# Decorator Pattern

Decorator pattern allows to extend the behaviour of an object without the use of inheritance. This is acheived using aggregation with a reference to the same interface of the object.
The decorator derived from the same interface uses a reference of the object that it's going to wrap. And with this, multiple decorators can be added on to it. So that the end object would be the original object and the decorated objects would have additional beaviours attached to it.
These decorators are responsible to call it's referenced object to which it's wrapped on to.

In the example, we extract the referencing the wrapped object to a base class (MRImageAnnotator) and it's child classes has it's own behaviour like adding a text to the image or adding geometry to the image.
The child classes call the base classes RenderImage which in turn propogates it's call to the actual image object, which then renders the image.

### UML Class diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Creational_Patterns/DecoratorPattern/DecoratorPatternUML.PNG)