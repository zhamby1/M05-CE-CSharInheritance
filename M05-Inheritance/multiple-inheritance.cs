// //another cool reason why we would want to use inheritance is due to how strongly typed language work
// //remember when making arrays or other things, they have to be of the same type

// //lets say we have a class called Animal, and we have a pig and dog derived class

// class Animal{
//     public string animalName = "Animal";
//     public virtual void animalSound(){
//         Console.WriteLine("This animal makes a sound");
//     }
// }

// //dog class
// class Dog : Animal{
//     public string dogName = "Dog";
//     public override void animalSound()
//     {
//         Console.WriteLine("bark bark");
//     }

// }

// //pig class

// class Pig : Animal{
//     public string pigName = "Pig";
//     public override void animalSound()
//     {
//         Console.WriteLine("oink oink");
//     }

// }

// class Program{
//     public static void Main(string[] args){

//         //pig instance
//         Pig mypig = new Pig();
//         //dog instance
//         Dog mydog = new Dog();

//         //inheritance is an 'is-a' relationship.  Sop technically a pig and a dog are both animals.
//         //This is important because we can organize child classes using the parent/base class as a type

//         Animal[] animalArray = new Animal[3];
//         animalArray = [mydog,mypig];

//         foreach(Animal animal in animalArray){
//             animal.animalSound();
//         }

//         //you could also create a typed variable of Animal and create a new instance of the child/derived class
//         Animal mydog2 = new Dog();
//         Animal mypig2 = new Pig();

        
       
//     }
// }