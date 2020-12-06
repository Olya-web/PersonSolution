using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonLibrary
{
    public class ProfessionInfo
    {
        private int _professionID = 0;
        private string _professionName = "";

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

        public string ProfessionsName
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
    }
}