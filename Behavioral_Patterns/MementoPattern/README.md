# Mememnto Pattern

This pattern let's one store the state of an object and restore it's state without having to reveal about it's internal properties and not violating Encapusaltion.


In the example, we have the imageParameters class which has the image data and it is being changed on each Image Processing function call. Now we can store the image data through a ImageMemento which is stored in the historyHandler class which has the list of mementos that are stored.
The store behaviour is handled inside imageParameters class as it has full access to it's internal properties, which will store it in an imageMemento. These properties need not be made public just to store it.
And ImageMemento has the functionality to restore the data which calls the ImageParameter's SetImageData function call which is only accessible to the Memento class.

### UML class diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/MementoPatern/MementoPatternUML.PNG)
