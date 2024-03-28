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
    public partial class SellForm : Form
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public SellForm()
        {
            InitializeComponent();
            comboBoxMedId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            SqlCommand query = new SqlCommand("SELECT recipeMedicationId FROM RecipeMedications", connection);
            FillComboBox(comboBoxMedId, query);
        }

        private void textBoxPharmacyName_Click(object sender, EventArgs e)
        {
            if (comboBoxMedId.Text != "")
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                connection.Open();

                string id = comboBoxMedId.Text;
                StringBuilder query = new StringBuilder($"SELECT Directory.medicationName FROM Directory, RecipeMedications WHERE RecipeMedications.recipeMedicationId = {id} AND RecipeMedications.medicationId = Directory.medicationId");

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

                string id = comboBoxMedId.Text;
                StringBuilder query = new StringBuilder($"SELECT PharmacyMedications.pharmacyMedicationId FROM PharmacyMedications, RecipeMedications WHERE RecipeMedications.recipeMedicationId = {id} AND RecipeMedications.medicationId = PharmacyMedications.medicationId AND PharmacyMedications.medicationCount = (SELECT MAX(medicationCount) FROM PharmacyMedications, RecipeMedications WHERE RecipeMedications.recipeMedicationId = {id} AND RecipeMedications.medicationId = PharmacyMedications.medicationId)");

                SqlCommand command = new SqlCommand(query.ToString(), connection);

                string idPh = command.ExecuteScalar().ToString();

                query = new StringBuilder("INSERT INTO Sale (pharmacyMedicationId, recipeMedicationId) values(");
                query.Append($"'{idPh}',");
                query.Append($"'{id}'");
                query.Append(");");

                command = new SqlCommand(query.ToString(), connection);
                cmd = command;

                cmd.ExecuteNonQuery();

                query = new StringBuilder($"UPDATE PharmacyMedications SET medicationCount = medicationCount - 1 WHERE pharmacyMedicationId = '{idPh}'");
                command = new SqlCommand(query.ToString(), connection);
                cmd = command;

                cmd.ExecuteNonQuery();

                MessageBox.Show($"Продано лекарство аптеки с идентификатором {idPh}");

                connection.Close();

                this.Close();
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxPacientName_Click(object sender, EventArgs e)
        {
            if (comboBoxMedId.Text != "")
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
                connection.Open();

                string id = comboBoxMedId.Text;
                StringBuilder query = new StringBuilder($"SELECT Pacient.pacientName FROM Pacient, RecipeMedications, Recipe WHERE RecipeMedications.recipeMedicationId = {id} AND RecipeMedications.recipeId = Recipe.recipeId AND Recipe.pacientId = Pacient.pacientId");

                SqlCommand command = new SqlCommand(query.ToString(), connection);

                textBoxPacientName.Text = command.ExecuteScalar().ToString();

                connection.Close();
            }
        }
    }
}
