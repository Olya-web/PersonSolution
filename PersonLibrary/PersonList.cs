using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class PersonList: List<PersonInfo>
    {
        public static PersonList GetDefaultPersonList()
        {
            PersonList myList = new PersonList();

            PersonInfo _per = new PersonInfo();
            _per.PersonFirstName = "Владимир";
            _per.PersonSecondName = "Бысттров";
            _per.PersonDateBirh = DateTime.Today.AddYears(-20);

            myList.Add(_per);

                 _per = new PersonInfo();
            _per.PersonFirstName = "Игорь";
            _per.PersonSecondName = "Семенов";
            _per.PersonDateBirh = DateTime.Today.AddYears(-20).AddMonths(-2);

            myList.Add(_per);

            return myList;
        }
    }
}
