using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class Students
    {
        private int studentId;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        private string studentName;
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        private string gender;
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        private string studentIdNo;
        public string StudentIdNo
        {
            get { return studentIdNo; }
            set { studentIdNo = value; }
        }

        private string cardNo;
        public string CardNo
        {
            get { return cardNo; }
            set { cardNo = value; }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        private string studentAddress;
        public string StudentAddress
        {
            get { return studentAddress; }
            set { studentAddress = value; }
        }

        private int classId;
        public int ClassId
        {
            get { return classId; }
            set { classId = value; }
        }
    }
}
