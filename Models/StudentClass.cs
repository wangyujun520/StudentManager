using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    [Serializable]
    public class StudentClass
    {
        private int classId;
        public int ClassId
        {
            get { return classId; }
            set { classId = value; }
        }

        private string className;
        public string ClassName
        {
            get { return className; }
            set { className = value; }
        }
    }
}
