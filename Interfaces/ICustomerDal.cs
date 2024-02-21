using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql Add");
        }

        public void Delete()
        {
            Console.WriteLine("sql delete");
        }

        public void Update()
        {
            Console.WriteLine("sql update");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle Add");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle delete");
        }

        public void Update()
        {
            Console.WriteLine("oracle update");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
