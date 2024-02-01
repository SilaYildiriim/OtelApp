using Microsoft.EntityFrameworkCore;
using OtelUygulaması.Core;
using OtelUygulaması.Dal.IRepositories;
using OtelUygulaması.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtelUygulaması.Dal.Repositories
{
    public class EmployeeRepositories : BaseRepository<Employee>, IEmployeeRepositories
    {
        public EmployeeRepositories(DbContext db=null) : base(db?? new OtelUygulamasıDBContext())
        {
            
        }
    }
}
