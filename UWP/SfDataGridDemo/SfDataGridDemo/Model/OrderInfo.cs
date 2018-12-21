using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class OrderInfo : INotifyPropertyChanged
    {
        #region private members

        private double _unitPrice;
        private int _quantiy;
        private CustomerInfo customerInfo;


        #endregion

        #region public properties

        public CustomerInfo CustomerInfo
        {
            get
            {
                return customerInfo;
            }
            set
            {
                customerInfo = value;
                RaisePropertyChanged("CustomerInfo");

            }
        }
        public double UnitPrice
        {
            get
            {
                return _unitPrice;
            }
            set
            {
                _unitPrice = value;
                RaisePropertyChanged("UnitPrice");
            }
        }
        public int Quantity
        {
            get
            {
                return _quantiy;
            }
            set
            {
                _quantiy = value;
                RaisePropertyChanged("Quantity");
            }
        }




        //public string Orders
        //{
        //    get
        //    {
        //        return this.ToString();
        //    }
        //}
        #endregion

        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            if (UnitPrice > 0 && Quantity > 0)
                return "UnitPrice is " + UnitPrice.ToString() + " Quantity is " + Quantity.ToString();
            return "";
        }
    }
}
