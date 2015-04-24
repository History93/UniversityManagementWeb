using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementWeb.DAL.DAO
{
    public class Faculty:Admin
    {
        public int Id { set; get; }
        public string FacultyName { set; get; }
        public string FacultyCode { set; get; }
        public string FacultyEmail { set; get; }
        
    }
}