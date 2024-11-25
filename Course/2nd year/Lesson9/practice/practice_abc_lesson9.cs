using System;

namespace PersonAndEmployeeApp
{
    //Практика А
    //Определение класса Person
    public class Person
    {
        public string Name { get; set; }
        private int age;

        //Конструктор
        public Person(string name, int age)
        {
            Name = name;
            SetAge(age);
        }

        //Практика В
        //Метод для установки возраста с проверкой
        public void SetAge(int age)
        {
            if (age < 0)
            {
                Console.WriteLine("Возраст не может быть отрицательным.");
            }
            else
            {
                this.age = age;
            }
        }

        //Метод Introduce
        public void Introduce()
        {
            Console.WriteLine($"Привет, мое имя {Name}.");
        }
    }


    //Практика С
    //Класс Employee, наследуемый от Person
    public class Employee : Person
    {
        public string Position { get; set; }

        public Employee(string name, int age, string position) : base(name, age)
        {
            Position = position;
        }

        public void IntroduceWithPosition()
        {
            Console.WriteLine($"Привет, мое имя {Name}, я работаю на должности {Position}.");
        }
    }
}
