using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementWeb.DAL.DAO
{
    public class Student
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string UserName { set; get; }
        public string Password { set;get; }
        public double Cgpa { set; get; }
    }
}