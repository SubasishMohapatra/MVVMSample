using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MVVMSample
{
    public class MainModel
    {
        private Person current;

        public MainModel()
        {
            Persons = new ObservableCollection<Person>();
            Persons.Add(new Person() { Name = "A", Age = 10, Gender = "Male" });
            Persons.Add(new Person() { Name = "B", Age = 20, Gender = "Female" });
            Persons.Add(new Person() { Name = "C", Age = 30, Gender = "Male" });
        }

        public ObservableCollection<Person> Persons { get; set; }

        public Person Current
        {
            get { return current; }
            set
            {
                current = value;
            }
        }

    }
}