using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PharmacyDB
{
    public partial class RequestForm : Form
    {
        SqlConnection connection = null;
        SqlCommand cmd = null;

        private void FillComboBox(ComboBox cb, SqlCommand query)
        {
            try
            {
                cmd = query;
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                connection.Open();

                cb.Items.Clear();

                var res = cmd.ExecuteReader();
                StringBuilder val = new StringBuilder();

                while (res.Read())
                {
                    for (int i = 0; i < res.FieldCount; i++)
                    {
                        val.Append(res.GetValue(i).ToString() + " ");
                        cb.Items.Add(val);
                        val.Clear();
                    }
                }
                //connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public RequestForm()
        {
            InitializeComponent();
            comboBoxMedId.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPharmacyId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            SqlCommand query = new SqlCommand("SELECT pharmacyId FROM Pharmacy", connection);
            FillComboBox(comboBoxPharmacyId, query);

            query = new SqlCommand("SELECT medicationId FROM Directory", connection);
            FillComboBox(comboBoxMedId, query);
        }



        private void textBoxPharmacyName_Click(object sender, EventArgs e)
        {
            if (comboBoxPharmacyId.Text != "")
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                connection.Open();

                string id = comboBoxPharmacyId.Text;
                StringBuilder query = new StringBuilder($"SELECT pharmacyName FROM Pharmacy WHERE pharmacyId = {id}");

                SqlCommand command = new SqlCommand(query.ToString(), connection);

                textBoxPharmacyName.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
        }

        private void textBoxMedName_Click(object sender, EventArgs e)
        {
            if (comboBoxMedId.Text != "")
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                connection.Open();

                string id = comboBoxMedId.Text;
                StringBuilder query = new StringBuilder($"SELECT medicationName FROM Directory WHERE medicationId = {id}");

                SqlCommand command = new SqlCommand(query.ToString(), connection);

                textBoxMedName.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            try
            {
                if (comboBoxPharmacyId.Text != "" && comboBoxMedId.Text != "" && textBoxCount.Text != "" && (dateTimePickerStart.Value <= dateTimePickerEnd.Value) && dateTimePickerStart.Value <= DateTime.Now)
                {
                    StringBuilder query = new StringBuilder("INSERT INTO Request (pharmacyId, requestDate, medicationId, medicationRequestCount) values(");
                    query.Append($"'{comboBoxPharmacyId.Text}',");
                    query.Append($"'{DateTime.Now}',");
                    query.Append($"'{comboBoxMedId.Text}',");
                    query.Append($"'{textBoxCount.Text}'");
                    query.Append(");");

                    SqlCommand command = new SqlCommand(query.ToString(), connection);
                    cmd = command;

                    cmd.ExecuteNonQuery();

                    query = new StringBuilder($"SELECT MAX(requestId) FROM Request");

                    command = new SqlCommand(query.ToString(), connection);

                    string requestId = command.ExecuteScalar().ToString();

                    query = new StringBuilder("INSERT INTO PharmacyMedications (pharmacyId, medicationId, medicationStartDate, medicationEndDate, medicationCount, requestId) values(");
                    query.Append($"'{comboBoxPharmacyId.Text}',");
                    query.Append($"'{comboBoxMedId.Text}',");
                    query.Append($"'{dateTimePickerStart.Value}',");
                    query.Append($"'{dateTimePickerEnd.Value}',");
                    query.Append($"'{textBoxCount.Text}',");
                    query.Append($"'{requestId}'");
                    query.Append(");");

                    command = new SqlCommand(query.ToString(), connection);
                    cmd = command;

                    cmd.ExecuteNonQuery();

                    connection.Close();

                    MessageBox.Show("Запрос успешно выполнен");

                    this.Close();
                }
                else MessageBox.Show("Поля заполнены неверно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

    }
}
