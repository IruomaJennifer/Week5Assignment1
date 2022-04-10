using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemodel
{
    internal class Class
    {
        public string Name { get; set; }
        public List<string> Subjects { get; set; }
        public List<Student> MembersOfGrade { get; set; }
    }
}
