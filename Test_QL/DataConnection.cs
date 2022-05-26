using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_QL
{
    internal class DataConnection
    {
        string chuoiKetNoi = "Data Source=DESKTOP-30ITQPH\\SQLEXPRESS;" + "Initial Cattalog = QLSV;" + "Intergrated Security = True";
        SqlConnection Cnn = null;
    }
}
