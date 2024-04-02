
// Fejl, der fiksede programmet:
// 1) Du skrev først direkte til backing fields (f.eks. name) i stedet for til setters (f.eks. Name) i Person.cs. (derfor at den ikke ændrede komma til punktum!)
// 2) Du kastede ArgumentExceptions i stedet for bare Exceptions i Person.cs setters.
// 3) Du fjernede al formatering af DateTime og Height, og det hjalp åbenbart? Du fjernede f.eks. dette fra MakeTitle():
//                              return $"{Name};{BirthDate.ToString("dd-MM-yyyy HH':'mm':'ss")};{Height.ToString("0.0", CultureInfo.InvariantCulture)};{IsMarried};{NoOfChildren}";
// og skrev i stedet for bare:  return $"{Name};{BirthDate};{Height};{IsMarried};{NoOfChildren}";

using System;
using Persistens;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);

        DataHandler handler = new DataHandler("Data.txt");
        handler.SavePerson(person);

        Console.WriteLine("Writing Person: ");
        Console.WriteLine(person.MakeTitle());

        Console.ReadLine();
    }
}
