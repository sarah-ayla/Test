using System;

namespace Abstract_Class
{
    public abstract class Animal
    {
      public abstract void run();
      public abstract void speed();  
    }

    public class Dog : Animal{
        public override void run(){
            Console.WriteLine("the dog runs");
        }

        public override void speed(){
            Console.WriteLine("slowly");
        }
    }

    public class Cat : Animal{
        public override void run(){
            Console.WriteLine("the cat runs away and meows");
        }
        public override void speed(){
            Console.WriteLine("fast");
        }
    }

    class Program{
        static void Main(string[]args){
            Animal[] animals= new Animal[3];
            animals[0]=new Cat();
            animals[1]=new Dog();
            animals[2]=new Cat();

            foreach (Animal a in animals){
                a.run();
                a.speed();
            }
        }
    }
}
