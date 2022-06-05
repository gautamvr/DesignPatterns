# Visitor Pattern

This pattern is used for performing certain operations on different objects on which they operate. They use double dispatch mechanism to delegently access the overloaded functions using their respective object types.
This allows the objects to use dynamic binding on the overloaded functions, which is usually done by static binding.

In the example, each derived class of the type DIImage has a function implementation of Accept() which takes in the parameter of the PlanningTool. The planning tool has the respective implementations for each derived types seperately. Since these overloaded functions are called from it's respective class types, the appropriate functions would be used for the invocations.
(In contrast to static binding when the functions are called by using a base type of ImageType - Only the plan function of base type would be called as it is decided during compile time)'

### UML class diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/VisitorPattern/VisitorPatternUML.PNG)


[Note : In C#, This behaviour can be tackled by passing the image parameter type with dynamic keyword in the planningTool function call. That way, the appropriate function overload would be called at runtime rather than assigning the base type function in compile time. Visitor pattern might not be needed in that case, but the risks with dynamic keyword are to be noted.]
