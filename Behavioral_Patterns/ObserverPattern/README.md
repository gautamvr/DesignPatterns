# Observer Pattern

The observer pattern is used to notify a set of observers on some event that has occured on the Subject. In this way, the subject can hold the functionality to change the state of it's observers based on the event.

The observers need not to poll for the state of the subject everytime. The observers would be subscribing to the event of the subject. The responsiblity would be let to the subject to let the observers know about subject's state after an event. 

In the example, we have dealt with the MRScanner having the responsiblity to invoke the function of the observers whenever a scan is completed. So when a scan is completed, the MRScanner (Subject) has the responsibility to notify it's subject through an interface or an EventHandler.

### UML Diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/ObserverPattern/ObserverPattern_UML.PNG)

## With Events:
 
The same pattern can be used effectively using events in C#. We create a delegate which would be the contract between the subject and the observers and the observer will assign it's event handler function to the delegate. The delegate is initialised in the subject as an event and the event with the specified delegate is invoked whenever scan is completed. 

### UML Diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/ObserverPattern/WithEvents/ObserverPatternWithEvents_UML.PNG)
