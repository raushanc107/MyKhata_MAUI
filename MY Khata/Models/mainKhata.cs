using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_Khata.Models
{
    public class mainKhata
    {
        public Color BalanceColor { get
            {
                if (Balance == 0) return Colors.DarkGray;
                if (Balance > 0) return Colors.Green; 
                return Colors.Red;
            }
        }
        public double Balance { get {

                return toGive + toTake;
            
            } }

        public double toGive { get {
                return users.Where(e => e.Balance < 0).Sum(e=>e.Balance);
            } }
        public double toTake
        {
            get
            {
                return users.Where(e => e.Balance > 0).Sum(e => e.Balance);
            }
        }


        public List<User> users { get; set; }

        public mainKhata()
        {
            users = new List<User>();
        }

    }
}
