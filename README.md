# Week3Interfaces

Exercise: 
You are required to redesign the solution you came up with for Lab 1 to use an interface. Rather than having a ThreeDShape superclass and a Sphere subclass you should define a IHasVolume interface and make the Sphere class implement it. 
The program will have one interface and one class:
IHasVolume interface
1.	The interface should have a method which calculates the volume of an item 
Sphere class
1.	The Sphere class should implement the HasVolume interface.
2.	The class should have field and matching read-write property for the radius of the sphere.
3.	Implement appropriate constructors for the class.
4.	Implement appropriate properties for the class.
5.	Implement a method to calculate the volume of the sphere i.e. PI * radius * radius * radius. This method is required since the class implements the IHasVolume interface.
6.	Override the ToString() method inherited from Object, make it display information about the sphere.
7.	Test the class. Call the method to calculate the volume of a sphere polymorphically via a reference of type IHasVolume. Display details of the sphere object. 
8.	Make a collection of spheres and call various methods.
