# Prototype Pattern

This pattern is used for creating expensive object creations. Since the object creations take a lot of time (maybe due to database calls or some API calls), we create a prototype of the objects and use the clone of those objects whenever we want to create new objects.
We then change the attributes of the cloned objects seperately.

In the example of creating a DICOM image, we have first load the prototype of the respective Image (MR image, CT Image or DXR image) and then use the clone of those objects and change it's attribute according to the needs.

## UML Diagram:
![alt-text](https://github.com/gautamvr/DesignPatterns/blob/main/Creational_Patterns/PrototypePattern/PrototypePattern_UML.PNG)
