using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Configuration;

namespace PharmacyDB
{
    public partial class MainForm : Form
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

                while(res.Read())
                {
                    for (int i=0;i<res.FieldCount;i++)
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

        private void ClearBox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker3.Value = DateTime.Today;
            checkBox1.Checked = false;
        }

        private void DisableBox()
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Enabled = false;
            checkBox1.Enabled = false;

            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonUpdate.Enabled = false;
        }

        private void EnableBox()
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            dateTimePicker3.Enabled = true;
            checkBox1.Enabled = true;

            buttonAdd.Enabled = true;
            buttonDelete.Enabled = true;
            buttonUpdate.Enabled = true;
        }

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            toolStripComboBox1.SelectedIndex = 0;
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
/*            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM Pacient", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Имя пациента";
            textBox1.Visible = true;
            comboBox1.Visible = false;
            label2.Text = "Дата рождения пациента";
            textBox2.Visible = false;
            dateTimePicker1.Visible = true;
            comboBox2.Visible = false;
            label3.Text = "Основной диагноз";
            textBox3.Visible = true;
            textBox3.Text = "";
            comboBox3.Visible = false;
            dateTimePicker2.Visible = false;
            label4.Text = "Сопутствующий диагноз";
            textBox4.Visible = true;
            textBox4.Text = "";
            dateTimePicker3.Visible = false;
            label5.Text = "Наличие льготы";
            textBox5.Visible = false;
            checkBox1.Visible = true;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                EnableBox();
                toolStripMenuItem1.Visible = true;
            }
            if (toolStripComboBox1.SelectedIndex == 1)
            {
                DisableBox();
                toolStripMenuItem1.Visible = true;
            }
            if (toolStripComboBox1.SelectedIndex == 2)
            {
                DisableBox();
                toolStripMenuItem1.Visible = false;
            }
        }

        private void toolStripMenuItemRequest_Click(object sender, EventArgs e)
        {
            RequestForm requestForm = new RequestForm();
            requestForm.ShowDialog();
        }

        private void toolStripMenuItemAvailability_Click(object sender, EventArgs e)
        {
            AvailabilityForm availabilityForm = new AvailabilityForm();
            availabilityForm.ShowDialog();
        }

        private void toolStripMenuItemSold_Click(object sender, EventArgs e)
        {
            SoldForm soldForm = new SoldForm();
            soldForm.ShowDialog();
        }

        private void toolStripMenuItemSell_Click(object sender, EventArgs e)
        {
            SellForm sellForm = new SellForm();
            sellForm.ShowDialog();
        }

        private void toolStripMenuItemRevision_Click(object sender, EventArgs e)
        {
            RevisionForm revisionForm = new RevisionForm();
            revisionForm.ShowDialog();
        }

        private void radioButtonPacient_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM Pacient", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Имя пациента";
            textBox1.Visible = true;
            textBox1.Text = "";
            comboBox1.Visible = false;
            label2.Text = "Дата рождения пациента";
            textBox2.Visible = false;
            dateTimePicker1.Visible = true;
            comboBox2.Visible = false;
            label3.Text = "Основной диагноз";
            textBox3.Visible = true;
            textBox3.Text = "";
            comboBox3.Visible = false;
            dateTimePicker2.Visible = false;
            label4.Text = "Сопутствующий диагноз";
            textBox4.Visible = true;
            textBox4.Text = "";
            dateTimePicker3.Visible = false;
            label5.Text = "Наличие льготы";
            textBox5.Visible = false;
            checkBox1.Visible = true;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void radioButtonPharmacy_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM Pharmacy", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Название аптеки";
            textBox1.Visible = true;
            textBox1.Text = "";
            comboBox1.Visible = false;
            label2.Text = "Адрес аптеки";
            textBox2.Visible = true;
            textBox2.Text = "";
            dateTimePicker1.Visible = false;
            comboBox2.Visible = false;
            label3.Text = "Идентификатор типа аптеки";
            textBox3.Visible = false;
            dateTimePicker2.Visible = false;
            comboBox3.Visible = true;
            SqlCommand query = new SqlCommand("SELECT typeId FROM PharmacyType",connection);
            FillComboBox(comboBox3, query);
            label4.Text = "";
            textBox4.Visible = false;
            dateTimePicker3.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            checkBox1.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void radioButtonDirectory_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM Directory", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Название лекарства";
            textBox1.Visible = true;
            textBox1.Text = "";
            comboBox1.Visible = false;
            label2.Text = "";
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox2.Visible = false;
            label3.Text = "";
            textBox3.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker2.Visible = false;
            label4.Text = "";
            textBox4.Visible = false;
            dateTimePicker3.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            checkBox1.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void radioButtonRecipe_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM Recipe", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Идентификатор пациента";
            textBox1.Visible = false;
            comboBox1.Visible = true;
            SqlCommand query = new SqlCommand("SELECT pacientId FROM Pacient", connection);
            FillComboBox(comboBox1, query);
            label2.Text = "";
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox2.Visible = false;
            label3.Text = "";
            textBox3.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker2.Visible = false;
            label4.Text = "";
            textBox4.Visible = false;
            dateTimePicker3.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            checkBox1.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";

        }

        private void radioBurronRecipeMedications_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM RecipeMedications", connection);

            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Идентификатор рецепта";
            textBox1.Visible = false;
            comboBox1.Visible = true;
            SqlCommand query = new SqlCommand("SELECT recipeId FROM Recipe", connection);
            FillComboBox(comboBox1, query);
            label2.Text = "Идентификатор лекарства";
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox2.Visible = true;
            SqlCommand query1 = new SqlCommand("SELECT medicationId FROM Directory", connection);
            FillComboBox(comboBox2, query1);
            label3.Text = "";
            textBox3.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker2.Visible = false;
            label4.Text = "";
            textBox4.Visible = false;
            dateTimePicker3.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            checkBox1.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";

        }

        private void radioButtonPharmacyMedications_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM PharmacyMedications", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Идентификатор аптеки";
            textBox1.Visible = false;
            comboBox1.Visible = true;
            SqlCommand query = new SqlCommand("SELECT pharmacyId FROM Pharmacy", connection);
            FillComboBox(comboBox1, query);
            label2.Text = "Идентификатор лекарства";
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox2.Visible = true;
            SqlCommand query1 = new SqlCommand("SELECT medicationId FROM Directory", connection);
            FillComboBox(comboBox2, query1);
            label3.Text = "Дата изготовления";
            textBox3.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker2.Visible = true;
            label4.Text = "Срок годности";
            textBox4.Visible = false;
            dateTimePicker3.Visible = true;
            label5.Text = "Количество лекарства";
            textBox5.Visible = true;
            textBox5.Text = "";
            checkBox1.Visible = false;
            label6.Text = "Идентификатор запроса";
            textBox6.Visible = false;
            comboBox4.Visible = true;
            SqlCommand query2 = new SqlCommand("SELECT requestId FROM Request", connection);
            FillComboBox(comboBox4, query2);

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";

        }

        private void radioButtonPharmacyType_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM PharmacyType", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Тип аптеки";
            textBox1.Visible = true;
            textBox1.Text = "";
            comboBox1.Visible = false;
            label2.Text = "";
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox2.Visible = false;
            label3.Text = "";
            textBox3.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker2.Visible = false;
            label4.Text = "";
            textBox4.Visible = false;
            dateTimePicker3.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            checkBox1.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void radioButtonPseudony_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM Pseudony", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Идентификатор лекарства";
            textBox1.Visible = false;
            comboBox1.Visible = true;
            SqlCommand query = new SqlCommand("SELECT medicationId FROM Directory", connection);
            FillComboBox(comboBox1, query);
            label2.Text = "Псевдоним лекарства";
            textBox2.Visible = true;
            textBox2.Text = "";
            dateTimePicker1.Visible = false;
            comboBox2.Visible = false;
            label3.Text = "";
            textBox3.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker2.Visible = false;
            label4.Text = "";
            textBox4.Visible = false;
            dateTimePicker3.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            checkBox1.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void radioButtonSale_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM Sale", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Идентификатор лекарства аптеки";
            textBox1.Visible = false;
            comboBox1.Visible = true;
            SqlCommand query = new SqlCommand("SELECT pharmacyMedicationId FROM PharmacyMedications", connection);
            FillComboBox(comboBox1, query);
            label2.Text = "Идентификатор лекарства рецепта";
            textBox2.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox2.Visible = true;
            SqlCommand query1 = new SqlCommand("SELECT recipeMedicationId FROM RecipeMedications", connection);
            FillComboBox(comboBox2, query1);
            label3.Text = "";
            textBox3.Visible = false;
            comboBox3.Visible = false;
            dateTimePicker2.Visible = false;
            label4.Text = "";
            textBox4.Visible = false;
            dateTimePicker3.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            checkBox1.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void radioButtonRequest_CheckedChanged(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            dataAdapter = new SqlDataAdapter("SELECT *  FROM Request", connection);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds);

            dataGridView1.DataSource = 0;
            dataGridView1.DataSource = ds.Tables[0];

            label1.Text = "Идентификатор аптеки";
            textBox1.Visible = false;
            comboBox1.Visible = true;
            SqlCommand query = new SqlCommand("SELECT pharmacyId FROM Pharmacy", connection);
            FillComboBox(comboBox1, query);
            label2.Text = "Дата запроса";
            textBox2.Visible = false;
            dateTimePicker1.Visible = true;
            comboBox2.Visible = false;
            label3.Text = "Идентификатор лекарства";
            textBox3.Visible = false;
            comboBox3.Visible = true;
            dateTimePicker2.Visible = false;
            SqlCommand query1 = new SqlCommand("SELECT medicationId FROM Directory", connection);
            FillComboBox(comboBox3, query1);
            label4.Text = "Количество заказанного лекарства";
            textBox4.Visible = true;
            textBox4.Text = "";
            dateTimePicker3.Visible = false;
            label5.Text = "";
            textBox5.Visible = false;
            checkBox1.Visible = false;
            label6.Text = "";
            textBox6.Visible = false;
            comboBox4.Visible = false;

            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            try
            {
                if (radioButtonPacient.Checked)
                {
                    if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && dateTimePicker1.Value <= DateTime.Now)
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO Pacient (pacientName, pacientDate, pacientDiagnosisMain, pacientDiagnosisConcomitant, pacientBenefit) values(");
                        query.Append($"'{textBox1.Text}',");
                        query.Append($"'{dateTimePicker1.Value}',");
                        query.Append($"'{textBox3.Text}',");
                        query.Append($"'{textBox4.Text}',");
                        query.Append($"'{checkBox1.Checked}'");
                        //if (checkBox1.Checked) query.Append("'TRUE'");
                        //else query.Append("'FALSE'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        //cmd.CommandText = query.ToString();
                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonPharmacy.Checked)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && comboBox3.Text != "")
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO Pharmacy (pharmacyName, pharmacyAdress, pharmacyTypeId) values(");
                        query.Append($"'{textBox1.Text}',");
                        query.Append($"'{textBox2.Text}',");
                        query.Append($"'{comboBox3.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonDirectory.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO Directory (medicationName) values(");
                        query.Append($"'{textBox1.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonRecipe.Checked)
                {
                    if (comboBox1.Text != "")
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO Recipe (pacientId) values(");
                        query.Append($"'{comboBox1.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonRecipeMedications.Checked)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "")
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO RecipeMedications (recipeId, medicationId) values(");
                        query.Append($"'{comboBox1.Text}',");
                        query.Append($"'{comboBox2.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonPharmacyMedications.Checked)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "" && (dateTimePicker2.Value <= dateTimePicker3.Value) && textBox5.Text != "" && comboBox4.Text != "" && dateTimePicker2.Value <= DateTime.Now)
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO PharmacyMedications (pharmacyId, medicationId, medicationStartDate, medicationEndDate, medicationCount, requestId) values(");
                        query.Append($"'{comboBox1.Text}',");
                        query.Append($"'{comboBox2.Text}',");
                        query.Append($"'{dateTimePicker2.Value}',");
                        query.Append($"'{dateTimePicker3.Value}',");
                        query.Append($"'{textBox5.Text}',");
                        query.Append($"'{comboBox4.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonPharmacyType.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO PharmacyType (typeName) values(");
                        query.Append($"'{textBox1.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonPseudony.Checked)
                {
                    if (comboBox1.Text != "" && textBox2.Text != "")
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO Pseudony (medId, pseudonyName) values(");
                        query.Append($"'{comboBox1.Text}',");
                        query.Append($"'{textBox2.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonSale.Checked)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "")
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO Sale (pharmacyMedicationId, recipeMedicationId) values(");
                        query.Append($"'{comboBox1.Text}',");
                        query.Append($"'{comboBox2.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonRequest.Checked)
                {
                    if (comboBox1.Text != "" && dateTimePicker1.Value <= DateTime.Now && comboBox3.Text != "" && textBox4.Text != "")
                    {
                        StringBuilder query = new StringBuilder("INSERT INTO Request (pharmacyId, requestDate, medicationId, medicationRequestCount) values(");
                        query.Append($"'{comboBox1.Text}',");
                        query.Append($"'{dateTimePicker1.Value}',");
                        query.Append($"'{comboBox3.Text}',");
                        query.Append($"'{textBox4.Text}'");
                        query.Append(");");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно добавлен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбрана строка для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selRow = dataGridView1.SelectedRows[0].Cells[0].FormattedValue.ToString();

                if (radioButtonPacient.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM Pacient WHERE pacientId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonPharmacy.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM Pharmacy SET WHERE pharmacyId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonDirectory.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM Directory WHERE medicationId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonRecipe.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM Recipe WHERE recipeId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonRecipeMedications.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM RecipeMedications WHERE recipeMedicationId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonPharmacyMedications.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM PharmacyMedications WHERE pharmacyMedicationId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonPharmacyType.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM PharmacyType WHERE typeId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonPseudony.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM Pseudony WHERE pseudonymId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonSale.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM Sale WHERE saleId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

                if (radioButtonRequest.Checked)
                {
                        StringBuilder query = new StringBuilder($"DELETE FROM Request WHERE requestId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно удален");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);
            connection.Open();

            try
            {
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Не выбрана строка для изменения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selRow = dataGridView1.SelectedRows[0].Cells[0].FormattedValue.ToString();

                if (radioButtonPacient.Checked)
                {
                    if (textBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && dateTimePicker1.Value <= DateTime.Now)
                    {
                        StringBuilder query = new StringBuilder("UPDATE Pacient SET ");
                        query.Append($"pacientName = '{textBox1.Text}',");
                        query.Append($"pacientDate = '{dateTimePicker1.Value}',");
                        query.Append($"pacientDiagnosisMain = '{textBox3.Text}',");
                        query.Append($"pacientDiagnosisConcomitant = '{textBox4.Text}',");
                        query.Append($"pacientBenefit = '{checkBox1.Checked}'");
                        query.Append($"WHERE pacientId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonPharmacy.Checked)
                {
                    if (textBox1.Text != "" && textBox2.Text != "" && comboBox3.Text != "")
                    {
                        StringBuilder query = new StringBuilder("UPDATE Pharmacy SET ");
                        query.Append($"pharmacyName = '{textBox1.Text}',");
                        query.Append($"pharmacyAdress = '{textBox2.Text}',");
                        query.Append($"pharmacyTypeId = '{comboBox3.Text}'");
                        query.Append($"WHERE pharmacyId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonDirectory.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        StringBuilder query = new StringBuilder("UPDATE Directory SET ");
                        query.Append($"medicationName = '{textBox1.Text}'");
                        query.Append($"WHERE medicationId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonRecipe.Checked)
                {
                    if (comboBox1.Text != "")
                    {
                        StringBuilder query = new StringBuilder("UPDATE Recipe SET ");
                        query.Append($"pacientId = '{comboBox1.Text}'");
                        query.Append($"WHERE recipeId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonRecipeMedications.Checked)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "")
                    {
                        StringBuilder query = new StringBuilder("UPDATE RecipeMedications SET ");
                        query.Append($"recipeId = '{comboBox1.Text}',");
                        query.Append($"medicationId = '{comboBox2.Text}'");
                        query.Append($"WHERE recipeMedicationId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonPharmacyMedications.Checked)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "" && (dateTimePicker2.Value <= dateTimePicker3.Value) && textBox5.Text != "" && comboBox4.Text != "" && dateTimePicker2.Value <= DateTime.Now)
                    {
                        StringBuilder query = new StringBuilder("UPDATE PharmacyMedications SET ");
                        query.Append($"pharmacyId = '{comboBox1.Text}',");
                        query.Append($"medicationId = '{comboBox2.Text}',");
                        query.Append($"medicationStartDate = '{dateTimePicker2.Value}',");
                        query.Append($"medicationEndDate = '{dateTimePicker3.Value}',");
                        query.Append($"medicationCount = '{textBox5.Text}',");
                        query.Append($"requestId = '{comboBox4.Text}'");
                        query.Append($"WHERE pharmacyMedicationId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonPharmacyType.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        StringBuilder query = new StringBuilder("UPDATE PharmacyType SET ");
                        query.Append($"typeName = '{textBox1.Text}'");
                        query.Append($"WHERE typeId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonPseudony.Checked)
                {
                    if (comboBox1.Text != "" && textBox2.Text != "")
                    {
                        StringBuilder query = new StringBuilder("UPDATE Pseudony SET ");
                        query.Append($"medId = '{comboBox1.Text}',");
                        query.Append($"pseudonyName = '{textBox2.Text}'");
                        query.Append($"WHERE pseudonymId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonSale.Checked)
                {
                    if (comboBox1.Text != "" && comboBox2.Text != "")
                    {
                        StringBuilder query = new StringBuilder("UPDATE Sale SET ");
                        query.Append($"pharmacyMedicationId = '{comboBox1.Text}',");
                        query.Append($"recipeMedicationId = '{comboBox2.Text}'");
                        query.Append($"WHERE saleId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (radioButtonRequest.Checked)
                {
                    if (comboBox1.Text != "" && dateTimePicker1.Value <= DateTime.Now && comboBox3.Text != "" && textBox4.Text != "")
                    {
                        StringBuilder query = new StringBuilder("UPDATE Request SET ");
                        query.Append($"pharmacyId = '{comboBox1.Text}',");
                        query.Append($"requestDate = '{dateTimePicker1.Value}',");
                        query.Append($"medicationId = '{comboBox3.Text}',");
                        query.Append($"medicationRequestCount = '{textBox4.Text}'");
                        query.Append($"WHERE requestId = '{selRow}'");

                        SqlCommand command = new SqlCommand(query.ToString(), connection);
                        cmd = command;

                        cmd.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Элемент успешно изменен");
                        ClearBox();

                        DataSet ds = new DataSet();

                        dataAdapter.Fill(ds);

                        dataGridView1.DataSource = ds.Tables[0];
                    }
                    else MessageBox.Show("Поля не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButtonPacient.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    textBox1.Text = row.Cells[1].Value.ToString();
                    dateTimePicker1.Text = row.Cells[2].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                    if (row.Cells[5].Value.ToString() == "True")
                    checkBox1.Checked = true;
                    else checkBox1.Checked = false;
                }
            }

            if (radioButtonPharmacy.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    textBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                    comboBox3.Text = row.Cells[3].Value.ToString();
                }
            }

            if (radioButtonDirectory.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    textBox1.Text = row.Cells[1].Value.ToString();
                }
            }

            if (radioButtonRecipe.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    comboBox1.Text = row.Cells[1].Value.ToString();
                }
            }

            if (radioButtonRecipeMedications.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    comboBox1.Text = row.Cells[1].Value.ToString();
                    comboBox2.Text = row.Cells[2].Value.ToString();
                }
            }

            if (radioButtonPharmacyMedications.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    comboBox1.Text = row.Cells[1].Value.ToString();
                    comboBox2.Text = row.Cells[2].Value.ToString();
                    dateTimePicker2.Text = row.Cells[3].Value.ToString();
                    dateTimePicker3.Text = row.Cells[4].Value.ToString();
                    textBox5.Text = row.Cells[5].Value.ToString();
                    comboBox4.Text = row.Cells[6].Value.ToString();
                }
            }

            if (radioButtonPharmacyType.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    textBox1.Text = row.Cells[1].Value.ToString();
                }
            }

            if (radioButtonPseudony.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    comboBox1.Text = row.Cells[1].Value.ToString();
                    textBox2.Text = row.Cells[2].Value.ToString();
                }
            }

            if (radioButtonSale.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    comboBox1.Text = row.Cells[1].Value.ToString();
                    comboBox2.Text = row.Cells[2].Value.ToString();
                }
            }

            if (radioButtonRequest.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    comboBox1.Text = row.Cells[1].Value.ToString();
                    dateTimePicker1.Text = row.Cells[2].Value.ToString();
                    comboBox3.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[4].Value.ToString();
                }
            }
        }
    }
}
