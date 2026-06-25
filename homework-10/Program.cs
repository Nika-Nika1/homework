using homework_10;

var employee1 = new Employee("Luka","Yaryarashvili",2009, Country.USA, Gender.Male, Contacts.Mail);
Console.WriteLine(employee1.GetAge());
var employee2 = new Employee("Nika","Lursmanashvili",2011,Country.USA, Gender.Male, Contacts.Instagram);
var employee3 = new Employee("Nika","Sheyiladze",1990, Country.Germany, Gender.Male, Contacts.Number);
var employee4 = new Employee("Jora","Kapanadze",2000 ,Country.Germany, Gender.Male, Contacts.Fax);
var employee5 = new Employee("Nini","Xelashvili",1945, Country.Spain, Gender.Male,  Contacts.Mail);
var employee6 = new Employee("Lukito","Nonashvili",2010, Country.Spain, Gender.Male,Contacts.Number);
var employee7 = new Employee("Mariam","Beridze",2005, Country.Canada, Gender.Female, Contacts.Mail);
var employee8 = new Employee("Giorgi","Abashidze",35, Country.Canada, Gender.Male, Contacts.Number);

var employees = new Employee[] {employee1, employee2, employee3, employee4, employee5, employee6, employee7,employee8};
Console.WriteLine(employees.Length);


void GetEmployee(Employee[] employeees,Country country)
{
    
    foreach (var employee in employeees)
    {
        if (employee.Country == country)
        {
            Console.WriteLine($"NAME: {employee.Name}, SURNAME: {employee.Surname}, AGE: {employee.GetAge()}, COUNTRY: {employee.Country}, GENDER: {employee.Gender}, CONTACTS: {employee.Contacts}");
        }
    }
}

GetEmployee(employees,Country.Spain);

