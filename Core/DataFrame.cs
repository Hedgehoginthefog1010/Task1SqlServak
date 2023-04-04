using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp10.Model;

namespace WpfApp10.Core
{
    internal class DataFrame
    {
        public static Frame MineFrame { get; set; }
        public static TaskBDOEntities db { get; set; }
    }
}
