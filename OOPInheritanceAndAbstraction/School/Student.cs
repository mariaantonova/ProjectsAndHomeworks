using System;

class Student : People
{
    private int classNumber;

    public Student(string name, int classNumber)
        :base(name)
    {
        this.classNumber = classNumber;
    }

    public int ClassNumber
    {
        get { return this.classNumber; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("ClassNumber can't be negative or zero.");
            }
            this.classNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + " - No" + this.classNumber;
    }
}