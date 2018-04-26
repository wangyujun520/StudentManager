using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class ScoreList
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private int studentId;
        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        private int cSharp;
        public int CSharp
        {
            get { return cSharp; }
            set { cSharp = value; }
        }

        private int sQLServerDB;
        public int SQLServerDB
        {
            get { return sQLServerDB; }
            set { sQLServerDB = value; }
        }

        private DateTime updateTime;
        public DateTime UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
    }
}
