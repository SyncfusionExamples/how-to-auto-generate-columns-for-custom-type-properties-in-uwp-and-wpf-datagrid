using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class ShipperDetails : NotificationObject
    {
        private int _ShipperID;

        private string _CompanyName;

        public int ShipperID
        {
            get
            {
                return _ShipperID;
            }
            set
            {
                _ShipperID = value;
                RaisePropertyChanged("ShipperID");
            }
        }

        public string CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                _CompanyName = value;
                RaisePropertyChanged("CompanyName");
            }
        }
        public override string ToString()
        {
            return "This is ShippersInfo class";
        }
    }
}
