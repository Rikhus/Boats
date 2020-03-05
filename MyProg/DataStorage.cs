using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MyProg
{
    public class DataStorage
    {
        public static MyProgEntities db = new MyProgEntities();
        public static Frame mainFrame;
        public static int accID;
    }
}
