﻿
namespace PersonUI
{
    partial class PersonEditForm
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
            System.Windows.Forms.Label personDateBirhLabel;
            System.Windows.Forms.Label personFirstNameLabel;
            System.Windows.Forms.Label professionIDLabel;
            this.personEditFormAddButton = new System.Windows.Forms.Button();
            this.personEditFormCancelButtton = new System.Windows.Forms.Button();
            this.personInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personDateBirhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.personFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.professionlistbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.professionIDComboBox = new System.Windows.Forms.ComboBox();
            personDateBirhLabel = new System.Windows.Forms.Label();
            personFirstNameLabel = new System.Windows.Forms.Label();
            professionIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionlistbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personDateBirhLabel
            // 
            personDateBirhLabel.AutoSize = true;
            personDateBirhLabel.Location = new System.Drawing.Point(28, 42);
            personDateBirhLabel.Name = "personDateBirhLabel";
            personDateBirhLabel.Size = new System.Drawing.Size(120, 17);
            personDateBirhLabel.TabIndex = 6;
            personDateBirhLabel.Text = "Person Date Birh:";
            // 
            // personFirstNameLabel
            // 
            personFirstNameLabel.AutoSize = true;
            personFirstNameLabel.Location = new System.Drawing.Point(28, 84);
            personFirstNameLabel.Name = "personFirstNameLabel";
            personFirstNameLabel.Size = new System.Drawing.Size(129, 17);
            personFirstNameLabel.TabIndex = 7;
            personFirstNameLabel.Text = "Person First Name:";
            // 
            // personEditFormAddButton
            // 
            this.personEditFormAddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.personEditFormAddButton.Location = new System.Drawing.Point(31, 311);
            this.personEditFormAddButton.Margin = new System.Windows.Forms.Padding(4);
            this.personEditFormAddButton.Name = "personEditFormAddButton";
            this.personEditFormAddButton.Size = new System.Drawing.Size(140, 37);
            this.personEditFormAddButton.TabIndex = 6;
            this.personEditFormAddButton.Text = "OK";
            this.personEditFormAddButton.UseVisualStyleBackColor = true;
            this.personEditFormAddButton.Click += new System.EventHandler(this.personEditFormAddButton_Click);
            // 
            // personEditFormCancelButtton
            // 
            this.personEditFormCancelButtton.Location = new System.Drawing.Point(237, 311);
            this.personEditFormCancelButtton.Margin = new System.Windows.Forms.Padding(4);
            this.personEditFormCancelButtton.Name = "personEditFormCancelButtton";
            this.personEditFormCancelButtton.Size = new System.Drawing.Size(140, 37);
            this.personEditFormCancelButtton.TabIndex = 6;
            this.personEditFormCancelButtton.Text = "Отмена";
            this.personEditFormCancelButtton.UseVisualStyleBackColor = true;
            this.personEditFormCancelButtton.Click += new System.EventHandler(this.personEditFormCancelButtton_Click);
            // 
            // personInfoBindingSource
            // 
            this.personInfoBindingSource.DataSource = typeof(PersonLibrary.PersonInfo);
            // 
            // personDateBirhDateTimePicker
            // 
            this.personDateBirhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personInfoBindingSource, "PersonDateBirh", true));
            this.personDateBirhDateTimePicker.Location = new System.Drawing.Point(154, 38);
            this.personDateBirhDateTimePicker.Name = "personDateBirhDateTimePicker";
            this.personDateBirhDateTimePicker.Size = new System.Drawing.Size(351, 22);
            this.personDateBirhDateTimePicker.TabIndex = 7;
            // 
            // personFirstNameTextBox
            // 
            this.personFirstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personInfoBindingSource, "PersonFirstName", true));
            this.personFirstNameTextBox.Location = new System.Drawing.Point(154, 84);
            this.personFirstNameTextBox.Name = "personFirstNameTextBox";
            this.personFirstNameTextBox.Size = new System.Drawing.Size(351, 22);
            this.personFirstNameTextBox.TabIndex = 8;
            // 
            // professionlistbindingSource
            // 
            this.professionlistbindingSource.DataSource = typeof(PersonLibrary.PersonList);
            // 
            // professionIDLabel
            // 
            professionIDLabel.AutoSize = true;
            professionIDLabel.Location = new System.Drawing.Point(52, 145);
            professionIDLabel.Name = "professionIDLabel";
            professionIDLabel.Size = new System.Drawing.Size(96, 17);
            professionIDLabel.TabIndex = 8;
            professionIDLabel.Text = "Profession ID:";
            // 
            // professionIDComboBox
            // 
            this.professionIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.personInfoBindingSource, "ProfessionID", true));
            this.professionIDComboBox.DataSource = this.professionlistbindingSource;
            this.professionIDComboBox.DisplayMember = "ProfessionName";
            this.professionIDComboBox.FormattingEnabled = true;
            this.professionIDComboBox.Location = new System.Drawing.Point(154, 142);
            this.professionIDComboBox.Name = "professionIDComboBox";
            this.professionIDComboBox.Size = new System.Drawing.Size(351, 24);
            this.professionIDComboBox.TabIndex = 9;
            this.professionIDComboBox.ValueMember = "ProfessionID";
            // 
            // PersonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(professionIDLabel);
            this.Controls.Add(this.professionIDComboBox);
            this.Controls.Add(personFirstNameLabel);
            this.Controls.Add(this.personFirstNameTextBox);
            this.Controls.Add(personDateBirhLabel);
            this.Controls.Add(this.personDateBirhDateTimePicker);
            this.Controls.Add(this.personEditFormCancelButtton);
            this.Controls.Add(this.personEditFormAddButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonEditForm";
            this.Text = "PersonEditForm";
            this.Load += new System.EventHandler(this.PersonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionlistbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button personEditFormAddButton;
        private System.Windows.Forms.Button personEditFormCancelButtton;
        private System.Windows.Forms.BindingSource personInfoBindingSource;
        private System.Windows.Forms.DateTimePicker personDateBirhDateTimePicker;
        private System.Windows.Forms.TextBox personFirstNameTextBox;
        private System.Windows.Forms.BindingSource professionlistbindingSource;
        private System.Windows.Forms.ComboBox professionIDComboBox;
    }
}