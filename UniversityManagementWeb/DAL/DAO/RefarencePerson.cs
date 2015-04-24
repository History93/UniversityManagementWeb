using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityManagementWeb.DAL.DAO
{
    public class RefarencePerson
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Organization { set; get; }
        public string Designation { set; get; }
        public string Email { set; get; }
        public string ContactNumber { set; get; }
    }
}