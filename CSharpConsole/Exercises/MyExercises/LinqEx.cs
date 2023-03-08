using CSharpConsole.Exercises.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Exercises.MyExercises
{
    internal class LinqEx
    {

        public void TestLinq()
        {
            var records = CreateCollection.GetUsers().Where(e => e != null);

            var a = records.Where(u => u.IsActive).Select(u => u.Name);

            var active = from u in records 
                         where u.IsActive 
                         select u.Name;


            records.Any();

            records.Where(e => e != null).Count();


            records.Where(e => e.Name.StartsWith("M"));

            records.OrderBy(e => e.Name).Take(5);

            records.OrderBy(e => e.Name).Skip(5).Take(5);

            records.Distinct().Select(e => e.Name);

            records.GroupBy(e => e.Name).Where(gr => gr.Count() > 1)
                .Select(gr => gr.Key);

            records.OfType<SuperUser>();
            records.OfType<SuperUser>().Where(e => e.IsAdmin && e.IsActive);


            records.OfType<SuperUser>()
                .First(e => e.IsAdmin);
            //.FirstOrDefault();

            records
                .GroupBy(e => e.Name)
                .ToDictionary(u => u.Key, u => u.Count());

            records.ToArray();
        }
    }
}
