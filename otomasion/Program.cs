using Automation;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Personals> Personal = new List<Personals>();

        Personal.Add(new Personals("amin", "User", 235));
        //Personal.Add(new Personals("amir","User",-10));
        Personal.Add(new Personals("aman", "Admin", 238));
        Personal.Add(new Personals("amar", "User", 250));
        Personal.Add(new Personals("Gigi", "User", 290));
        Personal.Add(new Personals("raheb", "User", 180));
        Personal.Add(new Personals("anahita", "Admin", 146));

        List<Messages> Messages = new List<Messages>();
        Messages.Add(new Messages("Ehsasy", "Happy BirthDay", "2024,12,25", "02:50"));
        Messages.Add(new Messages("Dastoory", "farda ghazay hame ra bayad hesab kony", "2024,03,25", "22:00"));
        Messages.Add(new Messages("Khabary", "farda ghaza naiarid mehmoon Company hastim", "2024,02,25", "22:50"));
        Messages.Add(new Messages("Dastoory", "farda company saat 7AM baz mishavad", "2022,02,25", "02:02"));

        var Admin = Personal.Where(a => a.Post == "Admin");
        var AdminMessage = Messages.First(m => m.Text == "farda ghazay hame ra bayad hesab kony");

        var UserMessage = Messages.First(um => um.Text == "farda ghaza naiarid mehmoon Company hastim");
        foreach (var admin in Admin)
        {
            Console.WriteLine($"{admin.Name} : {UserMessage.Text} , {AdminMessage.Text}");
        }

        Console.WriteLine("************************************************************************************");

        var User = Personal.Where(u => u.Post == "User");


        foreach (var user in User)
        {
            Console.WriteLine($"{user.Name} : {UserMessage.Text}");
        }
        Console.ReadLine();
    }
}


//{ "farda nahar nayavarid", "nahar ro shoma bayad hesab konid" };

//Console.WriteLine(contained);


//List<student> students = new List<student>();
//students.Add(new student("Ali", 24, 50));
//students.Add(new student("Arash", 22, 20));
//students.Add(new student("Amir", 20, 80));
//students.Add(new student("Amir", 21, 10));
//students.Add(new student("Amin", 29, 60));

//var Result = students.OrderBy(x => x.Name).ThenBy(x => x.Age).ToList();
//var Result = students.Where(x => x.Age > 22);
//var Result = students.Where(x => x.Age > 22).Select(x => x.Name);

//foreach (var student in Result) 
//{
//    //Console.WriteLine($"{student.Name}__{student.Age}__{student.Donation}");
//    Console.WriteLine(student); 
//}
//Console.ReadLine();