using System;

namespace PolimorfizmApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new("Burek");
            Cat cat = new("Puszek");

            dog.Bark();
            cat.Meow();

            dog.ShowInfo();
            cat.ShowInfo();

            static void InfoAboutDog(Dog d)
            {
                d.ShowInfo();
            }

            static void InfoAbout(Animal a)
            {
                a.ShowInfo();
            }
        }
    }
}
