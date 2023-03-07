using FirebirdSql.Data.FirebirdClient;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CSharpConsole.Samples.Statements
{
    class Jumps
    {

        public void ReturnStatement(string[] args)
        {
            Console.WriteLine(Add(1, 2));


            try
            {
                TryCatch(args);


            }
            catch (Exception)
            {
            }
        }

        public void TryCatch(string[] args)
        {
            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Two numbers required");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Divide(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }           
            finally
            {
                Console.WriteLine("Good bye!");
            }

            using (var conn = new SqlConnection(""))
            {
                conn.Open();
                //
                //throw
                //

            }

            //var conn1 = new SqlConnection("");
            //var conn1 = new OracleConnection("");
            var conn1 = new FbConnection("");
            try
            {
                conn1.Open();
                
            }
            finally
            {
                conn1.Dispose(); 
            }

        }

        public void YieldStatement(string[] args)
        {
            foreach (int i in Range(-10, 10))
            {
                Console.WriteLine(i);
            }
        }


        private IEnumerable<int> Range(int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                yield return i;
            }
            yield break;
        }

        private double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException();
            return x / y;
        }

        private int Add(int a, int b)
        {
            return a + b;
        }
    }
}
