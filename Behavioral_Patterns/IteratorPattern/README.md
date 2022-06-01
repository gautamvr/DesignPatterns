# Iterator Pattern

Iterator pattern provides the ability to traverse through a defined collection without exposing its underlying resources or the data structure.

In this example, the collection class ScanImageCollection is made to iterate through the images that are added by the client, but the iteration logic can be pre defined according to the use case which lets the client use the iterator without having to check the datastructure of the collection.
This case, if the iteration logic is to be changed later, only the iterator can be modified without affecting collection or the client class.

### UML Class diagram:
![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/IteratorPattern/IteratorPatternUML.PNG)
