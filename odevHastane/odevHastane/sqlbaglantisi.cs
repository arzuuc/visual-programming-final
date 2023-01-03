using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace odevHastane
{
    class sqlbaglantisi
    {
        public MySqlConnection baglanti()
        {
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=hastanedb;Uid=root;Pwd='';");
            baglan.Open();
            return baglan;
        }
    }
}
