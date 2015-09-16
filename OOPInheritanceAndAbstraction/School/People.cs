using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class People : School
{
    private string name;

    public People(string name)
    {
        this.Name = name;
    }

    public string Name
    {
        get {return this.name;}
        set
        {
            if(string.IsNullOrEmpty(value))
	        {
                throw new ArgumentException("Name can't be null or empty.", "name");
	        }
            this.name = value;
        }
    }

    public override string ToString()
    {
        return this.Name;
    }
}

