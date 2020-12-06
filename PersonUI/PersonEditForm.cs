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

        /// <summary>
        /// Close the form on click discard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personEditFormCancelButtton_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// On press ok add push date to the _newPerson prop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personEditFormAddButton_Click(object sender, EventArgs e)
        {
            if(_newPerson.PersonID > 0)
            {
                _newPerson.UpdatePerson();
            }
            else
            {
                _newPerson.InsertNewPerson();
            }
        }

        private void PersonEditForm_Load(object sender, EventArgs e)
        {
            ProfessionList _professionList = ProfessionList.GetDefaultProfessionList();
            professionlistbindingSource.DataSource = _professionList;

            personInfoBindingSource.DataSource = _newPerson;
        }
    }
}
