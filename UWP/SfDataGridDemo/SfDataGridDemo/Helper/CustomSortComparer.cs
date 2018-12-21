
using Syncfusion.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class CustomComparer : IComparer<object>, ISortDirection
    {
        public Syncfusion.Data.Comparer _comparer;
        public CustomComparer()
        {
            this._comparer = Syncfusion.Data.Comparer.Default;
        }
        public int Compare(object x, object y)
        {
            object item1;
            object item2;
            if (x.GetType() == typeof(Employee))
            {
                item1 = ((Employee)x).OrderInfo;
                item2 = ((Employee)y).OrderInfo;
            }

            //While sorting groups

            else if (x.GetType() == typeof(Group))
            {

                //Calculating the group key length
                item1 = ((Group)x).Key.ToString();
                item2 = ((Group)y).Key.ToString();
            }

            else
            {
                item1 = x.ToString();
                item2 = y.ToString();
            }


            var num = this._comparer.Compare(item1.ToString(), item2.ToString());
            if (this.SortDirection == ListSortDirection.Descending)
            {
                num = -num;
            }
            return num;
        }

        private ListSortDirection _SortDirection;

        /// <summary>
        /// Gets or sets the property that denotes the sort direction.
        /// </summary>
        /// <remarks>
        /// SortDirection gets updated only when sorting the groups. For other cases, SortDirection is always ascending.
        /// </remarks>

        public ListSortDirection SortDirection
        {
            get { return _SortDirection; }
            set { _SortDirection = value; }
        }
    }
}
