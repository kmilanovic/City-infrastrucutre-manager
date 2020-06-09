namespace CityInfrastructureManager
{
    partial class InfraastructureFailureManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfraastructureFailureManager));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblInsertDateTimeFrom = new System.Windows.Forms.Label();
            this.dateTimePickerBeginOfFailure = new System.Windows.Forms.DateTimePicker();
            this.richTextBoxAdditionalDescription = new System.Windows.Forms.RichTextBox();
            this.lblInsertTypeOfFailure = new System.Windows.Forms.Label();
            this.lblInsertAdditionalDescription = new System.Windows.Forms.Label();
            this.comboBoxTypesOfFailure = new System.Windows.Forms.ComboBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.lblInsertCity = new System.Windows.Forms.Label();
            this.comboBoxCounties = new System.Windows.Forms.ComboBox();
            this.lblInsertCounty = new System.Windows.Forms.Label();
            this.btnInsertFailure = new System.Windows.Forms.Button();
            this.dataGridViewFailures = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_TypeOfFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginOfFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOfFailure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.dataGridViewHistoryOfFailures = new System.Windows.Forms.DataGridView();
            this.IdHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_UsernameHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_TypeOfFailureHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_CityHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginOfFailureHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndOfFailureHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdditionalDescriptionHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUserFirstLastName = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFailures)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryOfFailures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1457, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.lblInsertDateTimeFrom);
            this.tabPage1.Controls.Add(this.dateTimePickerBeginOfFailure);
            this.tabPage1.Controls.Add(this.richTextBoxAdditionalDescription);
            this.tabPage1.Controls.Add(this.lblInsertTypeOfFailure);
            this.tabPage1.Controls.Add(this.lblInsertAdditionalDescription);
            this.tabPage1.Controls.Add(this.comboBoxTypesOfFailure);
            this.tabPage1.Controls.Add(this.comboBoxCities);
            this.tabPage1.Controls.Add(this.lblInsertCity);
            this.tabPage1.Controls.Add(this.comboBoxCounties);
            this.tabPage1.Controls.Add(this.lblInsertCounty);
            this.tabPage1.Controls.Add(this.btnInsertFailure);
            this.tabPage1.Controls.Add(this.dataGridViewFailures);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1449, 439);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ispadi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(465, 33);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 32);
            this.btnRefresh.TabIndex = 22;
            this.btnRefresh.Text = "OSVJEŽI";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblInsertDateTimeFrom
            // 
            this.lblInsertDateTimeFrom.AutoSize = true;
            this.lblInsertDateTimeFrom.Location = new System.Drawing.Point(235, 150);
            this.lblInsertDateTimeFrom.Name = "lblInsertDateTimeFrom";
            this.lblInsertDateTimeFrom.Size = new System.Drawing.Size(205, 17);
            this.lblInsertDateTimeFrom.TabIndex = 21;
            this.lblInsertDateTimeFrom.Text = "Datum i vrijeme početka ispada";
            // 
            // dateTimePickerBeginOfFailure
            // 
            this.dateTimePickerBeginOfFailure.CustomFormat = "dd-MM-yyyy HH:mm:ss";
            this.dateTimePickerBeginOfFailure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBeginOfFailure.Location = new System.Drawing.Point(238, 172);
            this.dateTimePickerBeginOfFailure.Name = "dateTimePickerBeginOfFailure";
            this.dateTimePickerBeginOfFailure.Size = new System.Drawing.Size(202, 22);
            this.dateTimePickerBeginOfFailure.TabIndex = 20;
            // 
            // richTextBoxAdditionalDescription
            // 
            this.richTextBoxAdditionalDescription.Location = new System.Drawing.Point(20, 235);
            this.richTextBoxAdditionalDescription.Name = "richTextBoxAdditionalDescription";
            this.richTextBoxAdditionalDescription.Size = new System.Drawing.Size(184, 87);
            this.richTextBoxAdditionalDescription.TabIndex = 19;
            this.richTextBoxAdditionalDescription.Text = "";
            // 
            // lblInsertTypeOfFailure
            // 
            this.lblInsertTypeOfFailure.AutoSize = true;
            this.lblInsertTypeOfFailure.Location = new System.Drawing.Point(17, 150);
            this.lblInsertTypeOfFailure.Name = "lblInsertTypeOfFailure";
            this.lblInsertTypeOfFailure.Size = new System.Drawing.Size(137, 17);
            this.lblInsertTypeOfFailure.TabIndex = 16;
            this.lblInsertTypeOfFailure.Text = "Unesite vrstu ispada";
            // 
            // lblInsertAdditionalDescription
            // 
            this.lblInsertAdditionalDescription.AutoSize = true;
            this.lblInsertAdditionalDescription.Location = new System.Drawing.Point(17, 215);
            this.lblInsertAdditionalDescription.Name = "lblInsertAdditionalDescription";
            this.lblInsertAdditionalDescription.Size = new System.Drawing.Size(142, 17);
            this.lblInsertAdditionalDescription.TabIndex = 18;
            this.lblInsertAdditionalDescription.Text = "Unesite dodatan opis";
            // 
            // comboBoxTypesOfFailure
            // 
            this.comboBoxTypesOfFailure.FormattingEnabled = true;
            this.comboBoxTypesOfFailure.Location = new System.Drawing.Point(20, 170);
            this.comboBoxTypesOfFailure.Name = "comboBoxTypesOfFailure";
            this.comboBoxTypesOfFailure.Size = new System.Drawing.Size(184, 24);
            this.comboBoxTypesOfFailure.TabIndex = 17;
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(20, 111);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(184, 24);
            this.comboBoxCities.TabIndex = 5;
            // 
            // lblInsertCity
            // 
            this.lblInsertCity.AutoSize = true;
            this.lblInsertCity.Location = new System.Drawing.Point(17, 91);
            this.lblInsertCity.Name = "lblInsertCity";
            this.lblInsertCity.Size = new System.Drawing.Size(89, 17);
            this.lblInsertCity.TabIndex = 4;
            this.lblInsertCity.Text = "Unesite grad";
            // 
            // comboBoxCounties
            // 
            this.comboBoxCounties.FormattingEnabled = true;
            this.comboBoxCounties.Location = new System.Drawing.Point(20, 53);
            this.comboBoxCounties.Name = "comboBoxCounties";
            this.comboBoxCounties.Size = new System.Drawing.Size(184, 24);
            this.comboBoxCounties.TabIndex = 3;
            this.comboBoxCounties.SelectedIndexChanged += new System.EventHandler(this.comboBoxCounties_SelectedIndexChanged);
            // 
            // lblInsertCounty
            // 
            this.lblInsertCounty.AutoSize = true;
            this.lblInsertCounty.Location = new System.Drawing.Point(17, 33);
            this.lblInsertCounty.Name = "lblInsertCounty";
            this.lblInsertCounty.Size = new System.Drawing.Size(128, 17);
            this.lblInsertCounty.TabIndex = 2;
            this.lblInsertCounty.Text = "Odaberite županiju";
            // 
            // btnInsertFailure
            // 
            this.btnInsertFailure.Location = new System.Drawing.Point(20, 379);
            this.btnInsertFailure.Name = "btnInsertFailure";
            this.btnInsertFailure.Size = new System.Drawing.Size(144, 42);
            this.btnInsertFailure.TabIndex = 1;
            this.btnInsertFailure.Text = "UNESI ISPAD";
            this.btnInsertFailure.UseVisualStyleBackColor = true;
            this.btnInsertFailure.Click += new System.EventHandler(this.btnInsertFailure_Click);
            // 
            // dataGridViewFailures
            // 
            this.dataGridViewFailures.AllowUserToAddRows = false;
            this.dataGridViewFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ID_Username,
            this.Id_TypeOfFailure,
            this.Id_City,
            this.BeginOfFailure,
            this.EndOfFailure,
            this.AdditionalDescription});
            this.dataGridViewFailures.Location = new System.Drawing.Point(465, 83);
            this.dataGridViewFailures.Name = "dataGridViewFailures";
            this.dataGridViewFailures.RowTemplate.Height = 24;
            this.dataGridViewFailures.Size = new System.Drawing.Size(978, 350);
            this.dataGridViewFailures.TabIndex = 0;
            this.dataGridViewFailures.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFailures_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // ID_Username
            // 
            this.ID_Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID_Username.DataPropertyName = "ID_Username";
            this.ID_Username.HeaderText = "Id korisnika";
            this.ID_Username.Name = "ID_Username";
            // 
            // Id_TypeOfFailure
            // 
            this.Id_TypeOfFailure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_TypeOfFailure.DataPropertyName = "Id_TypeOfFailure";
            this.Id_TypeOfFailure.HeaderText = "Id vrste ispada";
            this.Id_TypeOfFailure.Name = "Id_TypeOfFailure";
            // 
            // Id_City
            // 
            this.Id_City.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_City.DataPropertyName = "Id_City";
            this.Id_City.HeaderText = "Id grada";
            this.Id_City.Name = "Id_City";
            // 
            // BeginOfFailure
            // 
            this.BeginOfFailure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BeginOfFailure.DataPropertyName = "BeginOfFailure";
            this.BeginOfFailure.HeaderText = "Datum i vrijeme početka ispada";
            this.BeginOfFailure.Name = "BeginOfFailure";
            // 
            // EndOfFailure
            // 
            this.EndOfFailure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndOfFailure.DataPropertyName = "EndOfFailure";
            this.EndOfFailure.HeaderText = "Datum i vrijeme završetka ispada";
            this.EndOfFailure.Name = "EndOfFailure";
            // 
            // AdditionalDescription
            // 
            this.AdditionalDescription.DataPropertyName = "AdditionalDescription";
            this.AdditionalDescription.HeaderText = "Dodatan opis";
            this.AdditionalDescription.Name = "AdditionalDescription";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRefresh2);
            this.tabPage2.Controls.Add(this.dataGridViewHistoryOfFailures);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1449, 439);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Povijest ispada";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Location = new System.Drawing.Point(19, 32);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(109, 34);
            this.btnRefresh2.TabIndex = 1;
            this.btnRefresh2.Text = "OSVJEŽI";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh2_Click);
            // 
            // dataGridViewHistoryOfFailures
            // 
            this.dataGridViewHistoryOfFailures.AllowUserToAddRows = false;
            this.dataGridViewHistoryOfFailures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistoryOfFailures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdHistory,
            this.Id_UsernameHistory,
            this.Id_TypeOfFailureHistory,
            this.Id_CityHistory,
            this.BeginOfFailureHistory,
            this.EndOfFailureHistory,
            this.AdditionalDescriptionHistory});
            this.dataGridViewHistoryOfFailures.Location = new System.Drawing.Point(19, 85);
            this.dataGridViewHistoryOfFailures.Name = "dataGridViewHistoryOfFailures";
            this.dataGridViewHistoryOfFailures.RowTemplate.Height = 24;
            this.dataGridViewHistoryOfFailures.Size = new System.Drawing.Size(1315, 348);
            this.dataGridViewHistoryOfFailures.TabIndex = 0;
            // 
            // IdHistory
            // 
            this.IdHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdHistory.DataPropertyName = "Id";
            this.IdHistory.HeaderText = "Id";
            this.IdHistory.Name = "IdHistory";
            // 
            // Id_UsernameHistory
            // 
            this.Id_UsernameHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_UsernameHistory.DataPropertyName = "Id_Username";
            this.Id_UsernameHistory.HeaderText = "Id korisnika";
            this.Id_UsernameHistory.Name = "Id_UsernameHistory";
            // 
            // Id_TypeOfFailureHistory
            // 
            this.Id_TypeOfFailureHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_TypeOfFailureHistory.DataPropertyName = "Id_TypeOfFailure";
            this.Id_TypeOfFailureHistory.HeaderText = "Id vrste ispada";
            this.Id_TypeOfFailureHistory.Name = "Id_TypeOfFailureHistory";
            // 
            // Id_CityHistory
            // 
            this.Id_CityHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id_CityHistory.DataPropertyName = "Id_City";
            this.Id_CityHistory.HeaderText = "Id grada";
            this.Id_CityHistory.Name = "Id_CityHistory";
            // 
            // BeginOfFailureHistory
            // 
            this.BeginOfFailureHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BeginOfFailureHistory.DataPropertyName = "BeginOfFailure";
            this.BeginOfFailureHistory.HeaderText = "Datum i vrijeme početka ispada";
            this.BeginOfFailureHistory.Name = "BeginOfFailureHistory";
            // 
            // EndOfFailureHistory
            // 
            this.EndOfFailureHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EndOfFailureHistory.DataPropertyName = "EndOfFailure";
            this.EndOfFailureHistory.HeaderText = "Datum i vrijeme završetka ispada";
            this.EndOfFailureHistory.Name = "EndOfFailureHistory";
            // 
            // AdditionalDescriptionHistory
            // 
            this.AdditionalDescriptionHistory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AdditionalDescriptionHistory.DataPropertyName = "AdditionalDescription";
            this.AdditionalDescriptionHistory.HeaderText = "Dodatan opis";
            this.AdditionalDescriptionHistory.Name = "AdditionalDescriptionHistory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1177, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 57);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblUserFirstLastName
            // 
            this.lblUserFirstLastName.AutoSize = true;
            this.lblUserFirstLastName.BackColor = System.Drawing.SystemColors.Control;
            this.lblUserFirstLastName.Location = new System.Drawing.Point(123, 14);
            this.lblUserFirstLastName.Name = "lblUserFirstLastName";
            this.lblUserFirstLastName.Size = new System.Drawing.Size(58, 17);
            this.lblUserFirstLastName.TabIndex = 2;
            this.lblUserFirstLastName.Text = "Korisnik";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Location = new System.Drawing.Point(19, 11);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(87, 23);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "ODJAVA";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnLogOut);
            this.bunifuGradientPanel1.Controls.Add(this.lblUserFirstLastName);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.Control;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(17, 5);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(200, 44);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // InfraastructureFailureManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1482, 535);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InfraastructureFailureManager";
            this.Text = "InfraastructureFailureManager";
            this.Load += new System.EventHandler(this.InfraastructureFailureManager_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFailures)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistoryOfFailures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.Label lblInsertCity;
        private System.Windows.Forms.ComboBox comboBoxCounties;
        private System.Windows.Forms.Label lblInsertCounty;
        private System.Windows.Forms.Button btnInsertFailure;
        private System.Windows.Forms.DataGridView dataGridViewFailures;
        private System.Windows.Forms.Label lblInsertDateTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerBeginOfFailure;
        private System.Windows.Forms.RichTextBox richTextBoxAdditionalDescription;
        private System.Windows.Forms.Label lblInsertTypeOfFailure;
        private System.Windows.Forms.Label lblInsertAdditionalDescription;
        private System.Windows.Forms.ComboBox comboBoxTypesOfFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TypeOfFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginOfFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndOfFailure;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalDescription;
        private System.Windows.Forms.Label lblUserFirstLastName;
        private System.Windows.Forms.Button btnLogOut;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.DataGridView dataGridViewHistoryOfFailures;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_UsernameHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_TypeOfFailureHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_CityHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginOfFailureHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndOfFailureHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdditionalDescriptionHistory;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnRefresh2;
    }
}