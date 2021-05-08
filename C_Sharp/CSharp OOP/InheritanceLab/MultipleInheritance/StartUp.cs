using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var Dog = new Dog();
            Dog.Bark();
            Dog.Eat();

            var animal = new Animal();
            animal.Eat();

            var puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
