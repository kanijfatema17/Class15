using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS5012.Models
{
    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public long DepartmentHeadId { get; set; }


        public DateTime Date { get; set; }

    }
}
