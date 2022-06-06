# Flyweight Pattern

This pattern is a structural pattern that is mainly used to distribute the resource of an object across various objects so that less memory is consumed, and there by performance is increased.
It includes a flyweight class which has the intrinsic states that can be shared across various objects and a context class which has extrensic states. So, the flyweight class with shared states can be provided by a factory only when a new type of object is needed, else it provides the same object that has the same data.

In the example, we have ImageType as the flywieght class that has the intrinsic states such as colour matrix and image size stored in it, as these are common across most of the image objects.
And since the colour matrix occupies a lot of space, creating a separate colour matrix for each image slice object occupies so much RAM.

The actual behaviour of the object would be taken care by the flywieght class as that is the one being reused. The actual call is invoked through the main object class.

### UML Class diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Structural_Patterns/FlyweightPattern/FlywieghtPatternUML.PNG)