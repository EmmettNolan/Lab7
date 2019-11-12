using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Expense
    {
        //Properties
        public decimal Amount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Category { get; set; }

        //Constructors

        //Methods
        public override string ToString()
        {
            return $"{Category} {Amount:c} on {ExpenseDate.ToShortDateString()}";
        }
    }
}
