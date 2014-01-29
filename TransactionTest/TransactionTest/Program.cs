using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Movie { Title = "Rocky II" };
            using (var ctx = new TransactionTestDbContext())
            {
                ctx.Movies.Add(m);
                ctx.SaveChanges();
            }
        }
    }
}
