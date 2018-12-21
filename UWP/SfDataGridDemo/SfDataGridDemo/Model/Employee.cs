using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class NotificationObject : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class BaseEmployee : NotificationObject
    {
        private int _EmployeeID;
        [Range(1007, 1009, ErrorMessage = "EmployeeID can hold value between 1007 and 1009")]

        public int EmployeeID
        {
            get { return this._EmployeeID; }
            set
            {
                this._EmployeeID = value;
                this.RaisePropertyChanged("EmployeeID");
            }
        }
    }

    public class Employee : BaseEmployee
    {

        #region private members

        private int _orderId;
        private string _city;
        private OrderInfo _OrderInfo;
        private ShipperDetails[] shippersInfo;

        #endregion

        # region public properties
        public int OrderID
        {
            get { return this._orderId; }
            set
            {
                this._orderId = value;
                this.RaisePropertyChanged("OrderID");
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                RaisePropertyChanged("City");
            }
        }

        public OrderInfo OrderInfo
        {
            get
            {
                return _OrderInfo;
            }
            set
            {
                _OrderInfo = value;
                RaisePropertyChanged("OrderInfo");
            }
        }
        public ShipperDetails[] ShippersInfo
        {
            get
            {
                return shippersInfo;
            }
            set
            {
                shippersInfo = value;
                RaisePropertyChanged("ShippersInfo");
            }
        }

        #endregion

    }
}
