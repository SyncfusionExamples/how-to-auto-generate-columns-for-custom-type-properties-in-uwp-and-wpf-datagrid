using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Collections.ObjectModel;
using System.Collections;
using Syncfusion.Data.Extensions;
using System.Data;
using System.Windows.Input;


namespace DetailsView_NestedLevel
{
    public class ViewModel : INotifyPropertyChanged
    {
        ObservableCollection<Employee> source;
        protected EmployeeInfoRespository repository;
        protected int Count = 10;

        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public ViewModel()
            : base()
        {
            repository = new EmployeeInfoRespository();
            source = repository.GetEmployeesDetails(Count);
           
        }

        public ObservableCollection<Employee> Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                RaisePropertyChanged("Source");
            }
        }
    }
}

