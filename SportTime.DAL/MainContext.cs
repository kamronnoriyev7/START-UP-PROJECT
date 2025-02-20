using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportTime.DAL
{
   public  class MainContext : DbContext
    {

        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
        }
    }
}
