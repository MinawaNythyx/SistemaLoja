using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.Codes
{
    class DBLoginConnect
    {
        SqlConnection cnn;
        SqlCommand cmd;
        SqlDataReader dRd;
        string sqlString;
        private string dataFilePath;
        private string ConnectionString
        {
            get { return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dataFilePath + @";Integrated Security=True; Connection Timeout=30"; }
        }

        public DBLoginConnect()
        {
            dataFilePath = Environment.CurrentDirectory + @"\LojaDB.mdf";
        }

        public bool LoginCnn(string lgn, string sen)
        {
            sqlString = "SELECT * FROM Usuario WHERE NameUser = '" + lgn + "' AND Pass = '" + sen +"'";
            ConnectionDBase(sqlString);

            while (dRd.Read())
            {
                if(lgn == dRd.GetValue(1).ToString())
                {
                    if(sen == dRd.GetValue(2).ToString())
                    {
                        CloseConection();
                        return true;
                    }
                    else
                    {
                        CloseConection();
                        return false;
                    }
                }
                else
                {
                    CloseConection();
                    return false;
                }
            }
            CloseConection();
            return false;
        }

        private void ConnectionDBase(string sqlStr)
        {
            cnn = new SqlConnection(ConnectionString);
            cnn.Open();
            cmd = new SqlCommand(sqlStr, cnn);
            dRd = cmd.ExecuteReader();
        }
        private void CloseConection()
        {
            dRd.Close();
            cmd.Dispose();
            cnn.Close();
        }
    }
}
