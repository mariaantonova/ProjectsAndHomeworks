using System;

namespace Animals
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can not be null");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative.");
                }
                this.age = value;
            }
        }
        public Gender Gender { get; set; }

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public abstract void ProduceSound();
    }
}