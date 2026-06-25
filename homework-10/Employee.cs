using System.Runtime.InteropServices.JavaScript;

namespace homework_10;

public  class Employee
{

    public Employee(string name,string surname,int age,Country country,Gender gender,Contacts contacts)
    {
        Name = name;
        Surname = surname;
        DateOfBirth = age;
        Country = country;
        Gender = gender;
        Contacts = contacts;
    }

    
    public string Name { get; set; }
    public string Surname { get; set; }
    public int DateOfBirth { get; set; }
    public Country Country { get; set; }
    public Gender Gender { get; set; }
    
    public Contacts Contacts { get; set; }
    public int GetAge()
    {
        var ThisYear = DateTime.UtcNow.Year;
        return ThisYear - DateOfBirth;
    }
    
}

public enum Country
{
    USA,
    Canada,
    Germany,
    Spain
}

public enum Gender
{
    Male,
    Female
}

public enum Contacts
{
    Number,
    Instagram,
    Mail,
    Fax,
}