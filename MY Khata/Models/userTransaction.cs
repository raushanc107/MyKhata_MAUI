using System;
namespace MY_Khata.Models
{
	public class userTransaction
	{

        public string dateFormat { get {

                return date.Day+"\n"+date.ToString("MMM")+"\n"+date.Year;

            } }

        public DateTime date { get; set; }

        public double absamount
        {
            get
            {
                return Math.Abs(Balance);
            }
        }
        public Color amountColor
        {
            get
            {
                if (Balance == 0) return Colors.DarkGray;
                if (Balance > 0) return Colors.Green;
                return Colors.Red;
            }
        }

        public double Balance { get; set; }


        public string details { get; set; }

    }
}

