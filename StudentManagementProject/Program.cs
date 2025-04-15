using System;

public class Student
{
    private string name, rollNumber;
    private DateTime dateOfBirth;

    public string Name { get; set; }
    public string RollNumber { get; set; }

    public DateTime DateOfBirth
    {
        get => dateOfBirth;
        set
        {
            if (value > DateTime.Now)
            {
                throw new ArgumentException("Date of birth cannot be in the future");
            }
            dateOfBirth = value;
        }
    }

    public Student(string name, string rollNumber, DateTime dateOfBirth)
    {
        Name = name;
        RollNumber = rollNumber;
        DateOfBirth = dateOfBirth;
    }

    public void Display()
    {
        Console.WriteLine($"My Name is {Name}, roll number is {RollNumber}, my date of birth is {DateOfBirth.ToShortDateString()}, and my age is {Age}");
    }

    private int CalculateAge()
    {
        int age = DateTime.Now.Year - DateOfBirth.Year;

        // check if the birthday for this year has occurred yet
        if (DateTime.Now < DateOfBirth.AddYears(age))
        {
            // if the birthday hasn't occurred yet, decrement the age by 1
            age--;
        }
        return age;
    }

    public int Age
    {
        get { return CalculateAge(); }
    }
}

class Test
{
    public static void Main(string[] args)
    {
        try
        {
            Student st = new Student("Tamim Khan", "20", new DateTime(2023, 10, 30));
            Student stt = new Student("Hannan Khan", "40", new DateTime(1992, 07, 20));
            st.Display();
            stt.Display();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
