using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_Khata.Models
{
    public class User
    {
        public string logo { get{
                string[] s = Name.ToUpper().Split(" ");
                return s[0][0] + "" + s[s.Length - 1][0];
            } }
        public string Name { get; set; }

        public double absamount { get {
                return Math.Abs(Balance);
            } }
        public Color amountColor { get {
                if (Balance == 0) return Colors.DarkGray;
                if (Balance > 0) return Colors.Green;
                return Colors.Red;
            } }

        public double Balance { get {
                return transactions.Sum(e => e.Balance);

            } }


        public List<userTransaction> transactions;

        public User()
        {
            transactions = new List<userTransaction>();
        }





    }
}
