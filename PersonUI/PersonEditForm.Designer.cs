
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
            this.personNameLabel = new System.Windows.Forms.Label();
            this.personFirstnameValue = new System.Windows.Forms.TextBox();
            this.personSecondnameValue = new System.Windows.Forms.TextBox();
            this.personSecondNameLabel = new System.Windows.Forms.Label();
            this.personBirthdayLabel = new System.Windows.Forms.Label();
            this.personBirthdayValue = new System.Windows.Forms.DateTimePicker();
            this.personEditFormAddButton = new System.Windows.Forms.Button();
            this.personEditFormCancelButtton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // personNameLabel
            // 
            this.personNameLabel.AutoSize = true;
            this.personNameLabel.Location = new System.Drawing.Point(15, 26);
            this.personNameLabel.Name = "personNameLabel";
            this.personNameLabel.Size = new System.Drawing.Size(29, 13);
            this.personNameLabel.TabIndex = 0;
            this.personNameLabel.Text = "Имя";
            // 
            // personFirstnameValue
            // 
            this.personFirstnameValue.Location = new System.Drawing.Point(122, 26);
            this.personFirstnameValue.Name = "personFirstnameValue";
            this.personFirstnameValue.Size = new System.Drawing.Size(200, 20);
            this.personFirstnameValue.TabIndex = 1;
            // 
            // personSecondnameValue
            // 
            this.personSecondnameValue.Location = new System.Drawing.Point(122, 70);
            this.personSecondnameValue.Name = "personSecondnameValue";
            this.personSecondnameValue.Size = new System.Drawing.Size(200, 20);
            this.personSecondnameValue.TabIndex = 3;
            // 
            // personSecondNameLabel
            // 
            this.personSecondNameLabel.AutoSize = true;
            this.personSecondNameLabel.Location = new System.Drawing.Point(15, 73);
            this.personSecondNameLabel.Name = "personSecondNameLabel";
            this.personSecondNameLabel.Size = new System.Drawing.Size(56, 13);
            this.personSecondNameLabel.TabIndex = 2;
            this.personSecondNameLabel.Text = "Фамилия";
            // 
            // personBirthdayLabel
            // 
            this.personBirthdayLabel.AutoSize = true;
            this.personBirthdayLabel.Location = new System.Drawing.Point(15, 122);
            this.personBirthdayLabel.Name = "personBirthdayLabel";
            this.personBirthdayLabel.Size = new System.Drawing.Size(86, 13);
            this.personBirthdayLabel.TabIndex = 4;
            this.personBirthdayLabel.Text = "Дата рождения";
            // 
            // personBirthdayValue
            // 
            this.personBirthdayValue.Location = new System.Drawing.Point(122, 116);
            this.personBirthdayValue.Name = "personBirthdayValue";
            this.personBirthdayValue.Size = new System.Drawing.Size(200, 20);
            this.personBirthdayValue.TabIndex = 5;
            // 
            // personEditFormAddButton
            // 
            this.personEditFormAddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.personEditFormAddButton.Location = new System.Drawing.Point(18, 208);
            this.personEditFormAddButton.Name = "personEditFormAddButton";
            this.personEditFormAddButton.Size = new System.Drawing.Size(105, 30);
            this.personEditFormAddButton.TabIndex = 6;
            this.personEditFormAddButton.Text = "OK";
            this.personEditFormAddButton.UseVisualStyleBackColor = true;
            this.personEditFormAddButton.Click += new System.EventHandler(this.personEditFormAddButton_Click);
            // 
            // personEditFormCancelButtton
            // 
            this.personEditFormCancelButtton.Location = new System.Drawing.Point(187, 208);
            this.personEditFormCancelButtton.Name = "personEditFormCancelButtton";
            this.personEditFormCancelButtton.Size = new System.Drawing.Size(105, 30);
            this.personEditFormCancelButtton.TabIndex = 6;
            this.personEditFormCancelButtton.Text = "Отмена";
            this.personEditFormCancelButtton.UseVisualStyleBackColor = true;
            this.personEditFormCancelButtton.Click += new System.EventHandler(this.personEditFormCancelButtton_Click);
            // 
            // PersonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.personEditFormCancelButtton);
            this.Controls.Add(this.personEditFormAddButton);
            this.Controls.Add(this.personBirthdayValue);
            this.Controls.Add(this.personBirthdayLabel);
            this.Controls.Add(this.personSecondnameValue);
            this.Controls.Add(this.personSecondNameLabel);
            this.Controls.Add(this.personFirstnameValue);
            this.Controls.Add(this.personNameLabel);
            this.Name = "PersonEditForm";
            this.Text = "PersonEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label personNameLabel;
        private System.Windows.Forms.TextBox personFirstnameValue;
        private System.Windows.Forms.TextBox personSecondnameValue;
        private System.Windows.Forms.Label personSecondNameLabel;
        private System.Windows.Forms.Label personBirthdayLabel;
        private System.Windows.Forms.DateTimePicker personBirthdayValue;
        private System.Windows.Forms.Button personEditFormAddButton;
        private System.Windows.Forms.Button personEditFormCancelButtton;
    }
}