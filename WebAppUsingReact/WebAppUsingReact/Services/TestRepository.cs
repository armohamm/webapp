using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppUsingReact.Entities;
using WebAppUsingReact.Models;

namespace WebAppUsingReact.Services
{
    public class TestRepository : EntityBaseRepository<Test>
    {
        public TestRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
