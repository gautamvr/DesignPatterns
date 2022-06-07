# Bridge Pattern

Bridge pattern is used to seperate certain object from it's implementation. This way the implementation logic and the object's control logic can be seperated so that different combination of object and implementation can be easily handled.
This uses abstraction and implementation. The object which is exposed to the client for control layer is known as abstraction and the actual implementation logic is seperated into an implementation layer through a defined interface.

The abstraction layer uses this interface and accesses the different implementation functionalities through this reference. Various implementations can be extended from this defined interface.

In the example, we have an abstract layer, i.e. MRBaseConsole which has a reference of the implemenation interface IMRScanner.
So, this way, we can have multiple MR consoles derived from this MRBaseConsole and different concrete scanners based upon the client's requirement. The concrete scanner can be passed to the constructor of the console.

### UML Class diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Structural_Patterns/BridgePattern/BridgePatternUML.PNG)