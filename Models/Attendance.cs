using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Attendance
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string cardNo;
        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }

        private DateTime dTime;
        public DateTime DTime
        {
            get { return dTime; }
            set { dTime = value; }
        }
    }
}
