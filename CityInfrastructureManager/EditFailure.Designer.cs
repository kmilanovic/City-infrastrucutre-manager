namespace CityInfrastructureManager
{
    partial class EditFailure
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
            this.lblFailureId = new System.Windows.Forms.Label();
            this.lblTypeOfFailureId = new System.Windows.Forms.Label();
            this.lblCityId = new System.Windows.Forms.Label();
            this.lblBeginOfFailure = new System.Windows.Forms.Label();
            this.lblEndOfFailure = new System.Windows.Forms.Label();
            this.lblAdditionalDescription = new System.Windows.Forms.Label();
            this.lblFailure = new System.Windows.Forms.Label();
            this.lblTypeOfFailure = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdditionalDescription = new System.Windows.Forms.RichTextBox();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFailureId
            // 
            this.lblFailureId.AutoSize = true;
            this.lblFailureId.Location = new System.Drawing.Point(44, 92);
            this.lblFailureId.Name = "lblFailureId";
            this.lblFailureId.Size = new System.Drawing.Size(42, 17);
            this.lblFailureId.TabIndex = 0;
            this.lblFailureId.Text = "Ispad";
            // 
            // lblTypeOfFailureId
            // 
            this.lblTypeOfFailureId.AutoSize = true;
            this.lblTypeOfFailureId.Location = new System.Drawing.Point(44, 154);
            this.lblTypeOfFailureId.Name = "lblTypeOfFailureId";
            this.lblTypeOfFailureId.Size = new System.Drawing.Size(87, 17);
            this.lblTypeOfFailureId.TabIndex = 1;
            this.lblTypeOfFailureId.Text = "Vrsta ispada";
            // 
            // lblCityId
            // 
            this.lblCityId.AutoSize = true;
            this.lblCityId.Location = new System.Drawing.Point(44, 182);
            this.lblCityId.Name = "lblCityId";
            this.lblCityId.Size = new System.Drawing.Size(40, 17);
            this.lblCityId.TabIndex = 2;
            this.lblCityId.Text = "Grad";
            // 
            // lblBeginOfFailure
            // 
            this.lblBeginOfFailure.AutoSize = true;
            this.lblBeginOfFailure.Location = new System.Drawing.Point(44, 234);
            this.lblBeginOfFailure.Name = "lblBeginOfFailure";
            this.lblBeginOfFailure.Size = new System.Drawing.Size(205, 17);
            this.lblBeginOfFailure.TabIndex = 3;
            this.lblBeginOfFailure.Text = "Datum i vrijeme početka ispada";
            // 
            // lblEndOfFailure
            // 
            this.lblEndOfFailure.AutoSize = true;
            this.lblEndOfFailure.Location = new System.Drawing.Point(44, 277);
            this.lblEndOfFailure.Name = "lblEndOfFailure";
            this.lblEndOfFailure.Size = new System.Drawing.Size(216, 17);
            this.lblEndOfFailure.TabIndex = 4;
            this.lblEndOfFailure.Text = "Datum i vrijeme završetka ispada";
            // 
            // lblAdditionalDescription
            // 
            this.lblAdditionalDescription.AutoSize = true;
            this.lblAdditionalDescription.Location = new System.Drawing.Point(44, 317);
            this.lblAdditionalDescription.Name = "lblAdditionalDescription";
            this.lblAdditionalDescription.Size = new System.Drawing.Size(92, 17);
            this.lblAdditionalDescription.TabIndex = 5;
            this.lblAdditionalDescription.Text = "Dodatan opis";
            // 
            // lblFailure
            // 
            this.lblFailure.AutoSize = true;
            this.lblFailure.Location = new System.Drawing.Point(483, 92);
            this.lblFailure.Name = "lblFailure";
            this.lblFailure.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFailure.Size = new System.Drawing.Size(16, 17);
            this.lblFailure.TabIndex = 6;
            this.lblFailure.Text = "1";
            // 
            // lblTypeOfFailure
            // 
            this.lblTypeOfFailure.AutoSize = true;
            this.lblTypeOfFailure.Location = new System.Drawing.Point(483, 154);
            this.lblTypeOfFailure.Name = "lblTypeOfFailure";
            this.lblTypeOfFailure.Size = new System.Drawing.Size(16, 17);
            this.lblTypeOfFailure.TabIndex = 7;
            this.lblTypeOfFailure.Text = "2";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(483, 182);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(16, 17);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "3";
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dateTimePickerBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBegin.Location = new System.Drawing.Point(385, 234);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerBegin.TabIndex = 9;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(385, 277);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEnd.TabIndex = 10;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // textBoxAdditionalDescription
            // 
            this.textBoxAdditionalDescription.Location = new System.Drawing.Point(385, 317);
            this.textBoxAdditionalDescription.Name = "textBoxAdditionalDescription";
            this.textBoxAdditionalDescription.Size = new System.Drawing.Size(200, 96);
            this.textBoxAdditionalDescription.TabIndex = 11;
            this.textBoxAdditionalDescription.Text = "";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Location = new System.Drawing.Point(470, 419);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(115, 43);
            this.btnSaveEdit.TabIndex = 12;
            this.btnSaveEdit.Text = "AŽURIRAJ";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(44, 123);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(58, 17);
            this.lblUser.TabIndex = 13;
            this.lblUser.Text = "Korisnik";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(483, 123);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(16, 17);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "2";
            // 
            // EditFailure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 474);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.textBoxAdditionalDescription);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerBegin);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblTypeOfFailure);
            this.Controls.Add(this.lblFailure);
            this.Controls.Add(this.lblAdditionalDescription);
            this.Controls.Add(this.lblEndOfFailure);
            this.Controls.Add(this.lblBeginOfFailure);
            this.Controls.Add(this.lblCityId);
            this.Controls.Add(this.lblTypeOfFailureId);
            this.Controls.Add(this.lblFailureId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditFailure";
            this.Text = "EditFailure";
            this.Load += new System.EventHandler(this.EditFailure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFailureId;
        private System.Windows.Forms.Label lblTypeOfFailureId;
        private System.Windows.Forms.Label lblCityId;
        private System.Windows.Forms.Label lblBeginOfFailure;
        private System.Windows.Forms.Label lblEndOfFailure;
        private System.Windows.Forms.Label lblAdditionalDescription;
        private System.Windows.Forms.Label lblFailure;
        private System.Windows.Forms.Label lblTypeOfFailure;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.RichTextBox textBoxAdditionalDescription;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblUsername;
    }
}