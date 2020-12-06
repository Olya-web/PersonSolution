using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace PersonLibrary
{
    public class ProfessionList : List<ProfessionInfo>
    {

        public static ProfessionList GetDefaultProfessionList()
        {
            ProfessionList myList = new ProfessionList();

            try
            {
                string connstring = "Data Source=DESKTOP-0OSLSBL\\SQLEXPRESS;Initial Catalog=PersonDB;Integrated Security=True";
                // Making connection with Npgsql provider
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = connstring;
                cn.Open();
                // quite complex sql statement

                SqlCommand cm = cn.CreateCommand();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "GetProfessionList";

                SqlDataReader dataReader = cm.ExecuteReader();

                for (int i = 0; dataReader.Read(); i++)
                {
                    ProfessionInfo newProfession = new ProfessionInfo();

                    newProfession.ProfessionID = (int)dataReader["ProfessionID"];
                    newProfession.ProfessionsName = dataReader["ProfessionName"].ToString();
    

                    myList.Add(newProfession);
                }


                cn.Close();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }



            return myList;
        }
    }
}