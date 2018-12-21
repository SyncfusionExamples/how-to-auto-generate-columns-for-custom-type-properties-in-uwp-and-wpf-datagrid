using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class CustomerInfo
    {
        public int CustomerID { get; set; }
        public override string ToString()
        {
            return "The CustomerID is" + CustomerID.ToString();
        }
    }
}
