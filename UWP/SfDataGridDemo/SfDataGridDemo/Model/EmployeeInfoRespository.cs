using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class EmployeeInfoRespository : INotifyPropertyChanged
    {
        public EmployeeInfoRespository()
        {
            _comboBoxItemsSource = new List<string>();
            _comboBoxItemsSource.Add("Chennai");
            _comboBoxItemsSource.Add("Mumbai");
            _comboBoxItemsSource.Add("Delhi");
            _comboBoxItemsSource.Add("Bangalore");
            _comboBoxItemsSource.Add("Hyderabad");
            _comboBoxItemsSource.Add("Goa");
            _comboBoxItemsSource.Add("Mysore");
            _comboBoxItemsSource.Add("Trichy");
            _comboBoxItemsSource.Add("Madurai");
            _comboBoxItemsSource.Add("Ahmedabad");
            _comboBoxItemsSource.Add("Mohali");
            _comboBoxItemsSource.Add("Nagpur");
            _comboBoxItemsSource.Add("Patna");
        }

        int tem = 1;
        int comboitem = 0;
        string dateString = "5/1/1991 8:30:52 AM";

        public ObservableCollection<Employee> GetEmployeesDetails(int count)
        {
            var employees = new ObservableCollection<Employee>();
            for (int i = 1; i < count; i++)
            {
                employees.Add(GetEmployee(i));
            }
            return employees;
        }

        public Employee GetEmployee(int i)
        {
            DateTime birthdate = Convert.ToDateTime(dateString);
            comboitem++;
            tem++;
            if (tem > 40)
                tem = 0;
            if (comboitem > 9)
                comboitem = 0;
            var employee = new Employee()
            {
                EmployeeID = 1000 + i,
                OrderID = i,
                City = _comboBoxItemsSource.ElementAt(comboitem),
                OrderInfo = new OrderInfo() { Quantity = i + 10, UnitPrice = 20 + i, CustomerInfo = new CustomerInfo() { CustomerID = 10 + i } },
                ShippersInfo = new ShipperDetails[1]
            };
            employee.ShippersInfo[0] = new ShipperDetails();
            employee.ShippersInfo[0].ShipperID = i;

            return employee;
        }

        private List<string> _comboBoxItemsSource;

        public List<string> ComboBoxItemsSource
        {
            get { return _comboBoxItemsSource; }
            set { _comboBoxItemsSource = value; RaisePropertyChanged("ComboBoxItemsSource"); }
        }

        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
