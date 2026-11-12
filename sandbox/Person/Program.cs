using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void DisplayPersonInfo(Person person)
    {
        /*if (person is Doctor d)
        Console.WriteLine(d.GetDoctorInfo());
        else if (person is Police p)
        Console.WriteLine(p.GetPoliceInfo());
        else*/
        Console.Write($"salary: {person.GetSalary()}");

        Console.WriteLine(person.GetPersonInfo());
    }
    static void Main()
    {

        //Person myPerson = new Person("Carl", "Intern", 56, 288);

        //Console.WriteLine(myPerson.GetPersonInfo());


        Police myPolice = new Police("King", "Julian", 56, 288, "Fleas (that started the balck plauge)");

        //Console.WriteLine(myPolice.GetPoliceInfo());


        Doctor myDoctor = new Doctor("Dr.", "Doofenshmeirtz", 150, 99, "The laser hair remover-inator");

        //Console.WriteLine(myDoctor.GetDoctorInfo());

        List<Person> myPeople = new List<Person>();
        //myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);

        foreach(Person person in myPeople)
        {
            DisplayPersonInfo(person);

           /* Console.WriteLine(person.GetPersonInfo());
            if (person is Doctor d)
            {
                Console.WriteLine(d.GetDoctorInfo());
            }*/
        }

    }
}