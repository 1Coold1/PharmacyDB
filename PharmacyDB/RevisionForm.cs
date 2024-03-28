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
    public partial class RevisionForm : Form
    {
        SqlConnection connection = null;
        SqlDataAdapter dataAdapter = null;
        SqlCommand cmd = null;
        public RevisionForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            string date = DateTime.Today.ToString("yyyy-MM-dd");
            StringBuilder query = new StringBuilder($"DELETE FROM PharmacyMedications WHERE medicationEndDate < '{date}'");

            SqlCommand command = new SqlCommand(query.ToString(), connection);
            cmd = command;

            cmd.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("Элемент успешно удален");

            this.Close();
        }

        private void RevisionForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            string date = DateTime.Today.ToString("yyyy-MM-dd");
            dataAdapter = new SqlDataAdapter($"SELECT Pharmacy.pharmacyName, Directory.medicationName, medicationEndDate, medicationCount FROM PharmacyMedications, Directory, Pharmacy WHERE medicationEndDate < '{date}' AND PharmacyMedications.medicationId = Directory.medicationId AND PharmacyMedications.pharmacyId = Pharmacy.pharmacyId", connection);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
