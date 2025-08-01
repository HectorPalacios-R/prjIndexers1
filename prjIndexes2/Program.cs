namespace prjIndexes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create one object of class Dog
            //output alkl values using it index and string index
            //create a new project for unit tests
            //Create at least 4 unit tests
            Dogs dog = new Dogs("Buddy", "Golden Retriever", 5, 30);
            Console.WriteLine("Dog Name: " + dog[0]);
            Console.WriteLine("Dog Breed: " + dog[1]);
            Console.WriteLine("Dog Age: " + dog[2]);
            Console.WriteLine("Dog Weight: " + dog[3]);
            dog[0] = "Max";
            Console.WriteLine(dog[1]);
            Console.WriteLine(dog[2]);
            Console.WriteLine(dog[3]);
            Console.WriteLine(dog[4]);
            Console.WriteLine(dog[5]);
            dog["dogname"] = "Charlie";
            dog["dogbreed"] = "Beagle";
            dog["age"] = 4;
            dog["dogweight"] = 25;
            Console.WriteLine("Dog Name: " + dog["dogname"]);
            Console.WriteLine("Dog Breed: " + dog["dogbreed"]);
            Console.WriteLine("Dog Age: " + dog["age"]);
            Console.WriteLine("Dog Weight: " + dog["dogweight"]);


        }
    }
}
