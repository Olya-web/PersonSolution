using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PersonLibrary
{
    public class PersonList: List<PersonInfo>
    {
      
        public static PersonList GetDefaultPersonList()
        {
            PersonList myList = new PersonList();

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
                cm.CommandText = "GetPersonList";

                SqlDataReader dataReader = cm.ExecuteReader();

                for (int i = 0; dataReader.Read(); i++)
                {
                    PersonInfo newPerson = new PersonInfo();

                    newPerson.PersonID = (int)dataReader["PersonID"];
                    newPerson.PersonFirstName = dataReader["PersonFirstName"].ToString();
                    newPerson.PersonSecondName = dataReader["PersonSecondName"].ToString();
                    newPerson.PersonDateBirh = (DateTime)dataReader["PersonDateBirth"];
                    myList.Add(newPerson);
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
