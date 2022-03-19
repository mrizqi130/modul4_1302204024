using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204024
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class SimpleDataBase<T, Date>
    {
        private List<T> storedData;
        private List<Date> inputDates;

        public SimpleDataBase()
        {

        }

        public void AddNewData(T data)
        {
            dynamic data1;
            data1 = data;
            this.storedData = data1;
            data1 = DateTime.Now;
            this.inputDates = data1;
        }

        public void PrintAllData()
        {

        }
    }
}
