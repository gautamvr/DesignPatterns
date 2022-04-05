# Builder Pattern

**Use case :**
Developing an application for displaying the reports. The reports we need to display either in Excel or in PDF format. That means, we have two types of representation of reports. Each report needs to be built in a series of steps like adding header, content, footer etc.

So we have created a builder class which will do each of the steps in building the report. And we have a buildDirector class which directs on which order the report has to be built.

**UML Diagram:**

![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Creational_Patterns/BuilderPattern/BuilderPattern_UML.png)
