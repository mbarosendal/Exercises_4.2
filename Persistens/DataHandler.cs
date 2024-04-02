using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Persistens
{
    public class DataHandler
    {
        public string DataFileName { get; }
            
        // Constructor that sets the name of the file to be read/written.
        public DataHandler(string dataFileName)
        {
            DataFileName = dataFileName;
        }

        // Method to WRITE files with information on a SINGLE person.
        public void SavePerson(Person person)
        {
            using (StreamWriter writer = new StreamWriter(DataFileName))
            {
                writer.WriteLine(person.MakeTitle());
            }
        }

        // Method to WRITE files with information on a MULTIPLE person.
        public void SavePersons(Person[] persons)
        {
            using (StreamWriter writer = new StreamWriter(DataFileName))
            {
                foreach (Person person in persons)
                {              
                    writer.WriteLine(person.MakeTitle());
                }
            }
        }

        // Method to READ files with information on a SINGLE person.
        public Person LoadPerson()
        {
            using (StreamReader reader = new StreamReader(DataFileName))
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(';');

                // Parse each piece of information from the file from each index of the array directly into a new Person object.
                return new Person(parts[0], DateTime.Parse(parts[1]), double.Parse(parts[2]),bool.Parse(parts[3]), int.Parse(parts[4]));
            }
        }      

        // Method to READ files with information on MULTIPLE persons.
        public Person[] LoadPersons()
        {
            List<Person> personsList = new List<Person>();

            using (StreamReader reader = new StreamReader(DataFileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');

                    // Create a new Person object and add the value of each index from the array to the personsList-list.
                    personsList.Add(new Person(parts[0], DateTime.Parse(parts[1]), double.Parse(parts[2]), bool.Parse(parts[3]), int.Parse(parts[4])));
                }
            }

            // Convert the list to an array and return it.
            return personsList.ToArray();
        }
    }
}

