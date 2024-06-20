using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
      public class Class2 : DbContext
    {
        public DbSet<Class1> class1s {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-EOF1HU7\\SQLEXPRESS;Initial Catalog=sqlmoi;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
