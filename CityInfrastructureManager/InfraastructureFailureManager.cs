using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityInfrastructureManager
{
    public partial class InfraastructureFailureManager : Form
    {
        Login login = new Login();
        public FailureRepository _failureRepository = new FailureRepository();
        public BindingSource _tableBindingSource = new BindingSource();
        public BindingSource _countiesBindingSource = new BindingSource();
        public BindingSource _typesOfFailureBindingSource = new BindingSource();
        public BindingSource _historyOfFailuresBindingSource = new BindingSource();

        public InfraastructureFailureManager(Login login)
        {
            this.login = login;
            _tableBindingSource.DataSource = _failureRepository.GetFailures();
            _countiesBindingSource.DataSource = _failureRepository.GetComboBoxCounties();
            _typesOfFailureBindingSource.DataSource = _failureRepository.GetComboBoxTypesOfFailure();
            _historyOfFailuresBindingSource.DataSource = _failureRepository.GetHistoryOfFailures();

            InitializeComponent();
        }

        private void InfraastructureFailureManager_Load(object sender, EventArgs e)
        {
            lblUserFirstLastName.Text = login.GetUsername;
            dataGridViewFailures.DataSource = _tableBindingSource;
            dataGridViewHistoryOfFailures.DataSource = _historyOfFailuresBindingSource;
            comboBoxCounties.DataSource = _countiesBindingSource;
            comboBoxTypesOfFailure.DataSource = _typesOfFailureBindingSource;


            dataGridViewFailures.AutoGenerateColumns = false;
            dataGridViewFailures.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewHistoryOfFailures.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("C:\\Users\\Kristijan\\Documents\\Visual Studio 2015\\Projects\\CityInfrastructureManager\\Images\\edit.png");

            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFailures.Columns.Add(oEditButton);
            dataGridViewFailures.Columns[7].HeaderText = "Uredi";

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("C:\\Users\\Kristijan\\Documents\\Visual Studio 2015\\Projects\\CityInfrastructureManager\\Images\\bin.png");

            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewFailures.Columns.Add(oDeleteButton);
            dataGridViewFailures.Columns[8].HeaderText = "Obriši";
        }

        private void comboBoxCounties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string county = comboBoxCounties.SelectedValue.ToString();
            comboBoxCities.DataSource = _failureRepository.GetCitiesByCounty(county);         
        }

        private void btnInsertFailure_Click(object sender, EventArgs e)
        {
            var user = _failureRepository.GetUserByUsername(lblUserFirstLastName.Text);
            int userId = user.Id;

            string countyComboBox = comboBoxCounties.SelectedValue.ToString();
            var county = _failureRepository.GetCountyComboBoxValue(countyComboBox);
            int countyId = county.Id;

            string cityComboBox = comboBoxCities.SelectedValue.ToString();
            var city = _failureRepository.GetCityComboBoxValue(cityComboBox);
            int cityId = city.Id;

            string typeOfFailureComboBox = comboBoxTypesOfFailure.SelectedValue.ToString();
            var typeOfFailure = _failureRepository.GetTypeOfFailureComboBoxValue(typeOfFailureComboBox);
            int typeOfFailureId = typeOfFailure.Id;

            string additionalDescription = richTextBoxAdditionalDescription.Text.ToString();

            dateTimePickerBeginOfFailure.Value = DateTime.UtcNow;
            var dateTimeFrom = Convert.ToDateTime(dateTimePickerBeginOfFailure.Value);

            var failure = new Failure
            {
                Id_Username = userId,
                Id_TypeOfFailure = typeOfFailureId,
                Id_City = cityId,
                BeginOfFailure = dateTimeFrom,
                AdditionalDescription = additionalDescription
            };
            _failureRepository.AddFailure(failure);
            _tableBindingSource.DataSource = _failureRepository.GetFailures();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            //login.Closed += (s, args) => this.Close();
            login.Show();
        }

        private void dataGridViewFailures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFailures.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewFailures.Rows[e.RowIndex].Cells[0].Value.ToString());
                var id_username = Convert.ToInt32(dataGridViewFailures.Rows[e.RowIndex].Cells[1].Value.ToString());
                var id_type_of_failure = Convert.ToInt32(dataGridViewFailures.Rows[e.RowIndex].Cells[2].Value.ToString());
                var id_city = Convert.ToInt32(dataGridViewFailures.Rows[e.RowIndex].Cells[3].Value.ToString());
                var begin_of_failure = Convert.ToDateTime(dataGridViewFailures.Rows[e.RowIndex].Cells[4].Value);
                var additional_description = dataGridViewFailures.Rows[e.RowIndex].Cells[6].Value.ToString();

                var failure = new Failure
                {
                    Id = id,
                    Id_Username = id_username,
                    Id_TypeOfFailure = id_type_of_failure,
                    Id_City = id_city,
                    BeginOfFailure = begin_of_failure,
                    AdditionalDescription = additional_description
                };

                EditFailure formEditFailure = new EditFailure(failure);
                formEditFailure.Show();
            }

            if (dataGridViewFailures.CurrentCell.ColumnIndex.Equals(8) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewFailures.Rows[e.RowIndex].Cells[0].Value.ToString());
                var id_username = Convert.ToInt32(dataGridViewFailures.Rows[e.RowIndex].Cells[1].Value.ToString());
                var id_type_of_failure = Convert.ToInt32(dataGridViewFailures.Rows[e.RowIndex].Cells[2].Value.ToString());
                var id_city = Convert.ToInt32(dataGridViewFailures.Rows[e.RowIndex].Cells[3].Value.ToString());
                var begin_of_failure = Convert.ToDateTime(dataGridViewFailures.Rows[e.RowIndex].Cells[4].Value.ToString());
                var additional_description = dataGridViewFailures.Rows[e.RowIndex].Cells[6].Value.ToString();

                var failure = new Failure
                {
                    Id = id,
                    Id_Username = id_username,
                    Id_TypeOfFailure = id_type_of_failure,
                    Id_City = id_city,
                    BeginOfFailure = begin_of_failure,
                    AdditionalDescription = additional_description
                };
                _failureRepository.DeleteFailure(failure);
                _tableBindingSource.DataSource = _failureRepository.GetFailures();
                dataGridViewFailures.DataSource = _tableBindingSource;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _tableBindingSource.DataSource = _failureRepository.GetFailures();
        }

        private void btnRefresh2_Click(object sender, EventArgs e)
        {
            _historyOfFailuresBindingSource.DataSource = _failureRepository.GetHistoryOfFailures();
        }
    }
}
