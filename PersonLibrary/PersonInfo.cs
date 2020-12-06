using System;
using System.Data;
using System.Data.SqlClient;

namespace PersonLibrary
{
    public class PersonInfo
    {
        private string _personFirstName ="";
        private string _personSecondName = "";
        private DateTime _personDateBirth = DateTime.Today;
        private string _personAddress = "";
        private int _personID = 0;
        private int _professionID = 0;
        private string _professionName = "";
        private string _email = "";


        /// <summary>
        /// email prop
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        /// <summary>
        /// profession id prop
        /// </summary>
        public int ProfessionID
        {
            get
            {
                return _professionID;
            }
            set
            {
                _professionID = value;
            }
        }
        /// <summary>
        /// profession name prop
        /// </summary>
        public string ProfessionName
        {
            get
            {
                return _professionName;
            }
            set
            {
                _professionName = value;
            }
        }

        /// <summary>
        /// Prop returns person id
        /// </summary>
        public int PersonID
        {
            get
            {
                return _personID;
            }
            set
            {
                _personID = value;
            }
        }

        /// <summary>
        /// Prop return firstname
        /// </summary>
        /// 
        public string PersonFirstName
        {
            get => _personFirstName;
            set
            {
                _personFirstName = value;
            }
        }

        /// <summary>
        /// Returns integer value of Person years old
        /// </summary>
        public int PersonAge
        {
            get => DateTime.Today.Year - _personDateBirth.Year;
            set
            {
              
            }
        }

        /// <summary>
        /// Returns person birhday date
        /// </summary>
        public DateTime PersonDateBirh
        {
            get => _personDateBirth;
            set
            {
                _personDateBirth = value;
            }
        }


        /// <summary>
        /// Returns first name plus second name of Person
        /// </summary>
        public string PersonFullName
        {
            get => _personFirstName + " " + _personSecondName;
            set
            {
            }
        }

        /// <summary>
        /// Returns person second name
        /// </summary>
        public string PersonSecondName
        {
            get => _personSecondName;
            set
            {
                _personSecondName = value;
            }
        }
        /// <summary>
        /// Insert person into database method
        /// </summary>
        public void InsertNewPerson()
        {
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
                cm.CommandText = "InsertPerson";

                cm.Parameters.Add(new SqlParameter("@PersonDateBirth", _personDateBirth));
                cm.Parameters.Add(new SqlParameter("@PersonFirstName", _personFirstName));
                cm.Parameters.Add(new SqlParameter("@PersonSecondName", _personSecondName));
                cm.Parameters.Add(new SqlParameter("@ProfessionID", _professionID));
                cm.Parameters.Add(new SqlParameter("@Email", _email));

                cm.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }
        /// <summary>
        /// Delete person from db
        /// </summary>

        public void DeletePerson()
        {
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
                cm.CommandText = "DeletePerson";

                cm.Parameters.Add(new SqlParameter("@PersonID", _personID));

                cm.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }

        /// <summary>
        /// Update Person in database
        /// </summary>
        public void UpdatePerson()
        {
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
                cm.CommandText = "UpdatePerson";

                cm.Parameters.Add(new SqlParameter("@PersonID", _personID));
                cm.Parameters.Add(new SqlParameter("@PersonDateBirth", _personDateBirth));
                cm.Parameters.Add(new SqlParameter("@PersonFirstName", _personFirstName));
                cm.Parameters.Add(new SqlParameter("@PersonSecondName", _personSecondName));
                cm.Parameters.Add(new SqlParameter("@ProfessionID", _professionID));
                cm.Parameters.Add(new SqlParameter("@Email", _email));

                cm.ExecuteNonQuery();

                cn.Close();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }

        /// <summary>
        /// Returns person from database
        /// </summary>
        /// <param name="personID">Accept person id integer</param>
        public void GetPerson(int personID)
        {

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
                cm.CommandText = "GetPerson";

                cm.Parameters.Add(new SqlParameter("@PersonID", personID));

                SqlDataReader dataReader = cm.ExecuteReader();

                for (int i = 0; dataReader.Read(); i++)
                {
                    _personID = (int)dataReader["PersonID"];
                   _personFirstName = dataReader["PersonFirstName"].ToString();
                    _personSecondName = dataReader["PersonSecondName"].ToString();
                    _personDateBirth = (DateTime)dataReader["PersonDateBirth"];
                    _professionID = (int)dataReader["ProfessionID"];
                    _professionName = dataReader["ProfessionName"].ToString();
                    _email = dataReader["email"].ToString();
                }


                cn.Close();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                throw;
            }
        }
    }
}