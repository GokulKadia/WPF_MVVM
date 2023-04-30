using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_MVVM.Command;

namespace WPF_MVVM.ViewModel
{
    public class data
    {
        public string  Name { get; set; }
        public string Surname { get; set; }
    }
    public class TestViewVM
    {
        public ICommand ClickCommand { get;private set; }

        public data _selected;
        public data Selectedcmd
        {
            get { return _selected; }
            set
            {
                _selected = value;
            }
        }
        public string LName { get; set; }
        // public ObservableCollection<data> data = new ObservableCollection<data>();
        public ObservableCollection<data> data { get; set; }
        public TestViewVM()
        {
            ClickCommand = new CustomCommand(ClickCmd, null);
            data = new ObservableCollection<data>();
            data.Add(new data { Name = "Gokul",Surname="Kadia" }) ;
            LName = "Kadia Gokul";

        }
        private void ClickCmd(object obj)
        {
            data.Add(Selectedcmd);
        }

    }
}
