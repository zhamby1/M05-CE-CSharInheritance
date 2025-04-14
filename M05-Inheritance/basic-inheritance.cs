// //class called vehicle...there are many things that can be a vehicle (plane, boat, car, etc...)
// //we have to create an 'is-a' relationship - is a car a vehicle.  YES
// //create a class called vehicle and create a derived/child/sub  class called car

// //base class
// class Vehicle{
//     public string brand = "Ford";
    
//     //method to make a sound
//     public void vehicle_sound(){
//         Console.WriteLine("Beeeep");

//     }
// }

// //derived or child class..grabs everything the vehicle class can and adds or changes something
// class Car : Vehicle{
//     //in this example we are just adding data..no methods yet
//     public string modelName = "Mustang";
// }

// class Program{
//     public static void Main(string[] args){
//         //instance of vehicle
//         Vehicle myvehicle = new Vehicle();
//         //instance of car
//         Car mycar = new Car();

//         //we can use the same methods and properties/fields in both the parent and child
//         myvehicle.vehicle_sound();
//         mycar.vehicle_sound();

//         //they also contain the same brand
//         Console.WriteLine(myvehicle.brand);
//         Console.WriteLine(mycar.brand);

//         //the difference is the car has a model name
//         Console.WriteLine(mycar.modelName);
//     }
// }