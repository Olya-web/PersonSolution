using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonLibrary;

namespace PersonUI
{
    public partial class PersonForm : Form
    {
        PersonList _personList = new PersonList();
        public PersonForm()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Added event handler when clicked on button load data, and it's laod persons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadPersonsButton_Click(object sender, EventArgs e)
        {
            RefreshPersons();
        }

        /// <summary>
        /// Handler when form laoded, it's add two persons to empty list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonForm_Load(object sender, EventArgs e)
        {
            RefreshPersons();

        }

        /// <summary>
        /// Clear data before and load new which updated
        /// </summary>
        void RefreshPersons()
        {
            personsListBox.Items.Clear();
            _personList = PersonList.GetDefaultPersonList();
            foreach (PersonInfo _person in _personList)
            {
                personsListBox.Items.Add(_person.PersonFullName + " " + _person.PersonAge + " лет");
            }
        }

        /// <summary>
        /// Add new person method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewPersonButton_Click(object sender, EventArgs e)
        {
            PersonEditForm newForm = new PersonEditForm();
            if(newForm.ShowDialog() == DialogResult.OK)
            {
                 _personList.Add(newForm._newPerson);
            }
            RefreshPersons();
        }
    }
}
