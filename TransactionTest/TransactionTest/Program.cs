using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace TransactionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Movie { Title = "Rocky V" };
            using (var transScope = new TransactionScope())
            {
                using (var ctx = new TransactionTestDbContext())
                using (var trans = ctx.Database.BeginTransaction())
                {
                    ctx.Movies.Add(m);
                    ctx.SaveChanges();
                    trans.Commit();
                }
                // transScope.Complete(); // no commit is a rollback
            }
        }
    }
}
