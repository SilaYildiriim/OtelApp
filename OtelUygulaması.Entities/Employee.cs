using OtelUygulaması.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.Entities
{
    public class Employee:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

    }
}
