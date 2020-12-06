
namespace PersonUI
{
    partial class PersonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loadPersonsButton = new System.Windows.Forms.Button();
            this.addNewPersonButton = new System.Windows.Forms.Button();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.changePerson = new System.Windows.Forms.Button();
            this.personListDataGridView = new System.Windows.Forms.DataGridView();
            this.personListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.personListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loadPersonsButton
            // 
            this.loadPersonsButton.Location = new System.Drawing.Point(16, 245);
            this.loadPersonsButton.Margin = new System.Windows.Forms.Padding(4);
            this.loadPersonsButton.Name = "loadPersonsButton";
            this.loadPersonsButton.Size = new System.Drawing.Size(189, 64);
            this.loadPersonsButton.TabIndex = 1;
            this.loadPersonsButton.Text = "Загрузить";
            this.loadPersonsButton.UseVisualStyleBackColor = true;
            this.loadPersonsButton.Click += new System.EventHandler(this.loadPersonsButton_Click);
            // 
            // addNewPersonButton
            // 
            this.addNewPersonButton.Location = new System.Drawing.Point(225, 245);
            this.addNewPersonButton.Margin = new System.Windows.Forms.Padding(4);
            this.addNewPersonButton.Name = "addNewPersonButton";
            this.addNewPersonButton.Size = new System.Drawing.Size(207, 63);
            this.addNewPersonButton.TabIndex = 2;
            this.addNewPersonButton.Text = "Добавить";
            this.addNewPersonButton.UseVisualStyleBackColor = true;
            this.addNewPersonButton.Click += new System.EventHandler(this.addNewPersonButton_Click);
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(663, 244);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(204, 64);
            this.deletePersonButton.TabIndex = 4;
            this.deletePersonButton.Text = "Удалить";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // changePerson
            // 
            this.changePerson.Location = new System.Drawing.Point(440, 245);
            this.changePerson.Name = "changePerson";
            this.changePerson.Size = new System.Drawing.Size(204, 63);
            this.changePerson.TabIndex = 5;
            this.changePerson.Text = "Изменить";
            this.changePerson.UseVisualStyleBackColor = true;
            this.changePerson.Click += new System.EventHandler(this.changePerson_Click);
            // 
            // personListDataGridView
            // 
            this.personListDataGridView.AllowUserToAddRows = false;
            this.personListDataGridView.AllowUserToDeleteRows = false;
            this.personListDataGridView.AutoGenerateColumns = false;
            this.personListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.personListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1});
            this.personListDataGridView.DataSource = this.personListBindingSource;
            this.personListDataGridView.Location = new System.Drawing.Point(16, 3);
            this.personListDataGridView.Name = "personListDataGridView";
            this.personListDataGridView.ReadOnly = true;
            this.personListDataGridView.RowHeadersWidth = 51;
            this.personListDataGridView.RowTemplate.Height = 24;
            this.personListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personListDataGridView.Size = new System.Drawing.Size(872, 220);
            this.personListDataGridView.TabIndex = 5;
            // 
            // personListBindingSource
            // 
            this.personListBindingSource.DataSource = typeof(PersonLibrary.PersonInfo);
            // 
            // professionListBindingSource
            // 
            this.professionListBindingSource.DataSource = typeof(PersonLibrary.ProfessionInfo);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PersonID";
            this.dataGridViewTextBoxColumn4.HeaderText = "PersonID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProfessionID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProfessionID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PersonFirstName";
            this.dataGridViewTextBoxColumn5.HeaderText = "PersonFirstName";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PersonSecondName";
            this.dataGridViewTextBoxColumn9.HeaderText = "PersonSecondName";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PersonFullName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Полное имя";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PersonDateBirh";
            this.dataGridViewTextBoxColumn7.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PersonAge";
            this.dataGridViewTextBoxColumn6.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProfessionName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Профессия";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 469);
            this.Controls.Add(this.personListDataGridView);
            this.Controls.Add(this.changePerson);
            this.Controls.Add(this.deletePersonButton);
            this.Controls.Add(this.addNewPersonButton);
            this.Controls.Add(this.loadPersonsButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonForm";
            this.Text = "Сотрудники компании";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadPersonsButton;
        private System.Windows.Forms.Button addNewPersonButton;
        private System.Windows.Forms.BindingSource personListBindingSource;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Button changePerson;
        private System.Windows.Forms.BindingSource professionListBindingSource;
        private System.Windows.Forms.DataGridView personListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}

