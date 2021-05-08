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

            var cat = new Cat();
            cat.Eat();            
            cat.Meow();
        }
    }
}
