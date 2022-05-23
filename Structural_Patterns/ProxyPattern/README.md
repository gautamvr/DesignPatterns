# Proxy Pattern

Proxy pattern provides a surrogate or a placeholder which delegates the acces the actual object. The proxy here does some additional work that are intended and then sends the access to the real service object.
The proxy and the real service implements the same interface/abstract class so that the client could use the same interface but the object can created by proxy and sent across to the real service through proxy.
Any additional operations needed can be added in the proxy class.

In the example, I've created a proxy class which calculates the performance of the service call. The client uses the proxy class and the proxy sends the request to the real service class, while calculating the performance of that call. The real service has the actual business logic implementationg of the functionality

Similar way, a proxy can be used to delegate the access of the actual object by adding authentication in proxy class or performing some other operations that are needed before accessing the service object.

## UML Diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Structural_Patterns/ProxyPattern/ProxyPatternUML.PNG)
