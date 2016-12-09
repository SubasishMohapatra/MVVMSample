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
        private MainModel model;
        private ICommand updateCommand;

        public MainViewModel()
        {
            updateCommand = new RelayCommand(Update, null);
            Model = new MainModel();
        }

        public MainModel Model
        {
            get { return model; }
            set { model = value; }
        }

        public ICommand UpdateCommand
        {
            get { return updateCommand; }
        }

        public void Update(object name)
        {
            var newName = (string)name;
            model.Persons.First(x => string.Compare(x.Name, model.Current.Name, false) == 0).Name = newName;
            OnPropertyChanged("Model");
        }
    }
}
