using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDHTNLHELPERS.Models
{
    public class Department
    {

        public int id { get; set; }

        public string name { get; set; }

        public virtual ICollection<Employee> emps { get; set; } =
            new HashSet<Employee>();
    }
}