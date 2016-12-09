using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMSample
{
    public class MainViewModel : BaseViewModel
    {
        private Person current;
        private ICommand updateCommand;

        public MainViewModel()
        {
            updateCommand = new RelayCommand(Update, null);
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
                OnPropertyChanged("Current");
            }
        }

        public ICommand UpdateCommand
        {
            get { return updateCommand; }
        }

        public void Update(object name)
        {
            var newName = (string)name;
            Persons.First(x => string.Compare(x.Name, Current.Name, false) == 0).Name = newName;
            OnPropertyChanged("Persons");
        }

    }
}
