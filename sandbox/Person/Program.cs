using System.Security.AccessControl;

class Program
{
    static void Main()
    {
        Person myPerson = new Person("Carl", "Intern", 56, 288);

        Console.WriteLine(myPerson.GetPersonInfo());


        Police myPolice = new Police("King", "Julian", 56, 288, "Fleas (that started the balck plauge)");

        Console.WriteLine(myPolice.GetPoliceInfo());


        Doctor myDoctor = new Doctor("Dr.", "Doofenshmeirtz", 150, 99, "The laser hair remover-inator");

        Console.WriteLine(myDoctor.GetDoctorInfo());

        List<Person> myPeople = new List<Person>();
        myPeople.Add(myPerson);
        myPeople.Add(myPolice);
        myPeople.Add(myDoctor);

        foreach(Person person in myPeople)
        {
            Console.WriteLine(person.GetPersonInfo());
            if (person is Doctor d)
            {
                Console.WriteLine(d.GetDoctorInfo());
            }
        }
    }
}