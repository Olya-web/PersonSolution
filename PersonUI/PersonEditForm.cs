using PersonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonUI
{
    public partial class PersonEditForm : Form
    {
        public PersonInfo _newPerson = new PersonInfo();
        public PersonEditForm()
        {
            InitializeComponent();
        }

        private void personEditFormCancelButtton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void personEditFormAddButton_Click(object sender, EventArgs e)
        {
            DateTime birthDate = DateTime.Today;
            _newPerson.PersonFirstName = personFirstnameValue.Text;
            _newPerson.PersonSecondName = personSecondnameValue.Text;
            DateTime.TryParse(personBirthdayValue.Text, out birthDate);
            _newPerson.PersonDateBirh = birthDate;
        }
    }
}
