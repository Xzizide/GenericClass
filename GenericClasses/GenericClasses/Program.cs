using System;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<string> stringClass = new GenericClass<string>(); //Skapar objekt med datatypen string
            stringClass.Variable = "Hello"; //Sätter T till "Hello"
            stringClass.WriteIt(stringClass.Variable); //Skriver ut T

            GenericClass<int> intClass = new GenericClass<int>(); //Skapar objekt med datatypen int
            intClass.WriteIt(5); //Skriver ut T
        }
    }

    class GenericClass<T> //Generisk klass
    {
        public T Variable
        {
            get;
            set;
        }

        public void WriteIt(T item)
        {
            Console.WriteLine(item);
        }
    }
}
