using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Api_2.Models
{
    public class CarContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
    }
}