using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DetailsView_NestedLevel
{
    public class OrderInfo : INotifyPropertyChanged
    {
        #region private members

        private double _unitPrice;
        private int _quantiy;
       
        #endregion

        #region public properties

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
                RaisePropertyChanged("Orders");
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
                RaisePropertyChanged("Orders");
            }
        }  
        
        public string Orders
        {
            get
            {
                return this.ToString();
            }
        }
        #endregion

        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            if(UnitPrice > 0 && Quantity > 0)
                return "UnitPrice is " + UnitPrice.ToString() + " Quantity is " + Quantity.ToString();
            return "";
        }
    }
}
