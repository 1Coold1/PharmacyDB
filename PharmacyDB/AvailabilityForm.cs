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
    public partial class AvailabilityForm : Form
    {

        SqlConnection connection = null;
        SqlDataAdapter dataAdapter = null;
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public AvailabilityForm()
        {
            InitializeComponent();
            comboBoxMedId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            string id = comboBoxMedId.Text;
            //dataAdapter = new SqlDataAdapter($"SELECT pharmacyId, medicationCount FROM PharmacyMedications WHERE medicationId = {id}", connection);
            //dataAdapter = new SqlDataAdapter($"SELECT Pharmacy.pharmacyId, Pharmacy.pharmacyName FROM Pharmacy INNER JOIN PharmacyMedications ON Pharmacy.pharmacyId = PharmacyMedications.pharmacyId WHERE medicationId = {id}", connection);
            dataAdapter = new SqlDataAdapter($"SELECT PharmacyMedications.pharmacyId, Pharmacy.pharmacyName, PharmacyMedications.medicationCount FROM PharmacyMedications, Pharmacy WHERE medicationId = {id} AND Pharmacy.pharmacyId = PharmacyMedications.pharmacyId", connection);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

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

        private void AvailabilityForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            SqlCommand query = new SqlCommand("SELECT medicationId FROM Directory", connection);
            FillComboBox(comboBoxMedId, query);
        }
    }
}
