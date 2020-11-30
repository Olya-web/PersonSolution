using System;

namespace PersonLibrary
{
    public class PersonInfo
    {
        private string _personFirstName ="";
        private string _personSecondName = "";
        private DateTime _personDateBirth = DateTime.Today;
        private string _personAddress = "";

        /// <summary>
        /// Prop return firstname
        /// </summary>
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
    }
}