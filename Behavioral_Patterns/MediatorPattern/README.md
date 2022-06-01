# Mediator Pattern

Mediator pattern is used to control the communication between various objects/components. This reduces dependencies in each class promoting a loosely coupled system.
The mediator here takes care of performing necessary actions on each components according to the state change from various other components.

In the example, the ScanWorkflowController acts as a mediator. This mediator sends the update to examdashboard component whenever a state is changed from any of the components. Similarly, when examdashboard starts the scan, it changes it's state in planscan component and examcards components.
This vastly reduces the dependency between the three components. The mediator would have dependencies for the three components, so each component is loosely coupled with other components.

### UML Diagram:

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Behavioral_Patterns/MediatorPattern/MediatorPatternUML.PNG)
