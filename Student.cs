public class Student : IPerson, IEmployee
{
    public string name;
    public int age;
    public string country;
    public int phone;
    public string address;
    public string city;
    public string job;
    
    public string experience;

    public Student (string name, int age, string country, int phone, string address, string city, string job, string experience)
    {
        this.name = name;
        this.age = age;
        this.country = country;
        this.phone = phone;
        this.address = address;
        this.city = city;
        this.job = job;        
        this.experience = experience;
    }

    public void showAge()
    {
        Console.WriteLine($"My age is {age} years old");
    }
    public void showCountry()
    {
        Console.WriteLine($"I live in {country}");
    }
    public void showPhone()
    {
        Console.WriteLine($"My phone number is {phone}");
    }
    public void showAddress()
    {
        Console.WriteLine($"My adress is {address}");
    }
    public void showCity()
    {
        Console.WriteLine($"I live in {city}");
    }
    public void showExperience()
    {
        Console.WriteLine($"I have {experience} of experience");
    }
    public void showJob()
    {
        Console.WriteLine($"My current job is {job}");
    }    
}