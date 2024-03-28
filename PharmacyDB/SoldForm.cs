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
    public partial class SoldForm : Form
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
        public SoldForm()
        {
            InitializeComponent();
            comboBoxPhId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            string id = comboBoxPhId.Text;
            dataAdapter = new SqlDataAdapter($"SELECT Pacient.pacientName, Directory.medicationName FROM Pacient, Sale, Directory, PharmacyMedications, RecipeMedications, Recipe  WHERE PharmacyMedications.pharmacyId = {id} AND Sale.pharmacyMedicationId = PharmacyMedications.pharmacyMedicationId AND Sale.recipeMedicationId = RecipeMedications.recipeMedicationId AND RecipeMedications.recipeId = Recipe.recipeId AND Recipe.pacientId = Pacient.pacientId AND PharmacyMedications.medicationId = RecipeMedications.medicationId AND PharmacyMedications.medicationId = Directory.medicationId", connection);
            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBoxPhName_Click(object sender, EventArgs e)
        {
            if (comboBoxPhId.Text != "")
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                connection.Open();

                string id = comboBoxPhId.Text;
                StringBuilder query = new StringBuilder($"SELECT pharmacyName FROM Pharmacy WHERE pharmacyId = {id}");

                SqlCommand command = new SqlCommand(query.ToString(), connection);

                textBoxPhName.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
        }

        private void SoldForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            SqlCommand query = new SqlCommand("SELECT pharmacyId FROM Pharmacy", connection);
            FillComboBox(comboBoxPhId, query);
        }
    }
}
