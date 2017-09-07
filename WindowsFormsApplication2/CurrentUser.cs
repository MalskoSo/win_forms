using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class CurrentUser
    {
        public static CurrentUser instance;
        private CurrentUser() { } 
        public Client currentClient;

        public static CurrentUser getInstance()
        {
            if(instance == null)
            {
                instance = new CurrentUser();
            }
            return instance;
        }
    }
}
