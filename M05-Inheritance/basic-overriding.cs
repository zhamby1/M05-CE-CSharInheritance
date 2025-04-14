// //class called vehicle...there are many things that can be a vehicle (plane, boat, car, etc...)
// //we have to create an 'is-a' relationship - is a car a vehicle.  YES
// //create a class called vehicle and create a derived/child/sub  class called car

// //base class
// class Vehicle{
//     public string brand = "Ford";
    
//     //method to make a sound
//     //we need to make vehicle_sound a virtual method.
//     //this means it is not a "true" or concrete method...thus can be overrided.
//     //the virtual method CAN have default behavior
//     //this is a form of polymorphism
//     //this means that two things can do the same thing or have the same behavior, but the way they do it is different
//     public virtual void vehicle_sound(){
//         Console.WriteLine("Beeeep");

//     }
// }

// //derived or child class..grabs everything the vehicle class can and adds or changes something
// class Car : Vehicle{
//     //in this example we are just adding data..no methods yet
//     public string modelName = "Mustang";

//     //we need to override the car classes vehicle_sound method to make the car honk honk
//     //here we are actually changing what vehicle_sound is doing...we are not overloading
//     public override void vehicle_sound(){
//         Console.WriteLine("honk honk");
//     }
// }

// class Program{
//     public static void Main(string[] args){
//         //instance of vehicle
//         Vehicle myvehicle = new Vehicle();
//         //instance of car
//         Car mycar = new Car();

//         //we can use the same methods and properties/fields in both the parent and child but make them do different things
//         myvehicle.vehicle_sound();
//         mycar.vehicle_sound();

//         //they also contain the same brand
//         Console.WriteLine(myvehicle.brand);
//         Console.WriteLine(mycar.brand);

//         //the difference is the car has a model name
//         Console.WriteLine(mycar.modelName);
//     }
// }