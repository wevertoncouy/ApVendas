using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema.DAL
{
   public class DataContextFactory
    {
        private static sistemaDataContext dataContext;
       public static sistemaDataContext DbContext
        {
            get
            {
                if (dataContext == null)
                    dataContext = new sistemaDataContext();
                return dataContext;
            }

        }

        public static object DataContext { get; set; }
    }
}
