
namespace PharmacyDB
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAvailability = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSold = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSell = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemRevision = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonRequest = new System.Windows.Forms.RadioButton();
            this.radioButtonSale = new System.Windows.Forms.RadioButton();
            this.radioButtonPseudony = new System.Windows.Forms.RadioButton();
            this.radioButtonPharmacyType = new System.Windows.Forms.RadioButton();
            this.radioButtonPharmacyMedications = new System.Windows.Forms.RadioButton();
            this.radioButtonRecipeMedications = new System.Windows.Forms.RadioButton();
            this.radioButtonRecipe = new System.Windows.Forms.RadioButton();
            this.radioButtonDirectory = new System.Windows.Forms.RadioButton();
            this.radioButtonPharmacy = new System.Windows.Forms.RadioButton();
            this.radioButtonPacient = new System.Windows.Forms.RadioButton();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(911, 576);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1523, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Admin",
            "Salesman",
            "Customer"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRequest,
            this.toolStripMenuItemAvailability,
            this.toolStripMenuItemSold,
            this.toolStripMenuItemSell,
            this.toolStripMenuItemRevision});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 28);
            this.toolStripMenuItem1.Text = "Запрос";
            // 
            // toolStripMenuItemRequest
            // 
            this.toolStripMenuItemRequest.Name = "toolStripMenuItemRequest";
            this.toolStripMenuItemRequest.Size = new System.Drawing.Size(247, 26);
            this.toolStripMenuItemRequest.Text = "Поставка лекарства";
            this.toolStripMenuItemRequest.Click += new System.EventHandler(this.toolStripMenuItemRequest_Click);
            // 
            // toolStripMenuItemAvailability
            // 
            this.toolStripMenuItemAvailability.Name = "toolStripMenuItemAvailability";
            this.toolStripMenuItemAvailability.Size = new System.Drawing.Size(247, 26);
            this.toolStripMenuItemAvailability.Text = "Наличие лекарств";
            this.toolStripMenuItemAvailability.Click += new System.EventHandler(this.toolStripMenuItemAvailability_Click);
            // 
            // toolStripMenuItemSold
            // 
            this.toolStripMenuItemSold.Name = "toolStripMenuItemSold";
            this.toolStripMenuItemSold.Size = new System.Drawing.Size(247, 26);
            this.toolStripMenuItemSold.Text = "Проданные лекарства";
            this.toolStripMenuItemSold.Click += new System.EventHandler(this.toolStripMenuItemSold_Click);
            // 
            // toolStripMenuItemSell
            // 
            this.toolStripMenuItemSell.Name = "toolStripMenuItemSell";
            this.toolStripMenuItemSell.Size = new System.Drawing.Size(247, 26);
            this.toolStripMenuItemSell.Text = "Продать лекарство";
            this.toolStripMenuItemSell.Click += new System.EventHandler(this.toolStripMenuItemSell_Click);
            // 
            // toolStripMenuItemRevision
            // 
            this.toolStripMenuItemRevision.Name = "toolStripMenuItemRevision";
            this.toolStripMenuItemRevision.Size = new System.Drawing.Size(247, 26);
            this.toolStripMenuItemRevision.Text = "Ревизия лекарств";
            this.toolStripMenuItemRevision.Click += new System.EventHandler(this.toolStripMenuItemRevision_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonRequest);
            this.groupBox1.Controls.Add(this.radioButtonSale);
            this.groupBox1.Controls.Add(this.radioButtonPseudony);
            this.groupBox1.Controls.Add(this.radioButtonPharmacyType);
            this.groupBox1.Controls.Add(this.radioButtonPharmacyMedications);
            this.groupBox1.Controls.Add(this.radioButtonRecipeMedications);
            this.groupBox1.Controls.Add(this.radioButtonRecipe);
            this.groupBox1.Controls.Add(this.radioButtonDirectory);
            this.groupBox1.Controls.Add(this.radioButtonPharmacy);
            this.groupBox1.Controls.Add(this.radioButtonPacient);
            this.groupBox1.Location = new System.Drawing.Point(958, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 347);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите таблицу";
            // 
            // radioButtonRequest
            // 
            this.radioButtonRequest.AutoSize = true;
            this.radioButtonRequest.Location = new System.Drawing.Point(7, 306);
            this.radioButtonRequest.Name = "radioButtonRequest";
            this.radioButtonRequest.Size = new System.Drawing.Size(83, 24);
            this.radioButtonRequest.TabIndex = 9;
            this.radioButtonRequest.Text = "Request";
            this.radioButtonRequest.UseVisualStyleBackColor = true;
            this.radioButtonRequest.CheckedChanged += new System.EventHandler(this.radioButtonRequest_CheckedChanged);
            // 
            // radioButtonSale
            // 
            this.radioButtonSale.AutoSize = true;
            this.radioButtonSale.Location = new System.Drawing.Point(7, 275);
            this.radioButtonSale.Name = "radioButtonSale";
            this.radioButtonSale.Size = new System.Drawing.Size(58, 24);
            this.radioButtonSale.TabIndex = 8;
            this.radioButtonSale.Text = "Sale";
            this.radioButtonSale.UseVisualStyleBackColor = true;
            this.radioButtonSale.CheckedChanged += new System.EventHandler(this.radioButtonSale_CheckedChanged);
            // 
            // radioButtonPseudony
            // 
            this.radioButtonPseudony.AutoSize = true;
            this.radioButtonPseudony.Location = new System.Drawing.Point(7, 244);
            this.radioButtonPseudony.Name = "radioButtonPseudony";
            this.radioButtonPseudony.Size = new System.Drawing.Size(93, 24);
            this.radioButtonPseudony.TabIndex = 7;
            this.radioButtonPseudony.Text = "Pseudony";
            this.radioButtonPseudony.UseVisualStyleBackColor = true;
            this.radioButtonPseudony.CheckedChanged += new System.EventHandler(this.radioButtonPseudony_CheckedChanged);
            // 
            // radioButtonPharmacyType
            // 
            this.radioButtonPharmacyType.AutoSize = true;
            this.radioButtonPharmacyType.Location = new System.Drawing.Point(7, 213);
            this.radioButtonPharmacyType.Name = "radioButtonPharmacyType";
            this.radioButtonPharmacyType.Size = new System.Drawing.Size(125, 24);
            this.radioButtonPharmacyType.TabIndex = 6;
            this.radioButtonPharmacyType.Text = "PharmacyType";
            this.radioButtonPharmacyType.UseVisualStyleBackColor = true;
            this.radioButtonPharmacyType.CheckedChanged += new System.EventHandler(this.radioButtonPharmacyType_CheckedChanged);
            // 
            // radioButtonPharmacyMedications
            // 
            this.radioButtonPharmacyMedications.AutoSize = true;
            this.radioButtonPharmacyMedications.Location = new System.Drawing.Point(7, 182);
            this.radioButtonPharmacyMedications.Name = "radioButtonPharmacyMedications";
            this.radioButtonPharmacyMedications.Size = new System.Drawing.Size(175, 24);
            this.radioButtonPharmacyMedications.TabIndex = 5;
            this.radioButtonPharmacyMedications.Text = "PharmacyMedications";
            this.radioButtonPharmacyMedications.UseVisualStyleBackColor = true;
            this.radioButtonPharmacyMedications.CheckedChanged += new System.EventHandler(this.radioButtonPharmacyMedications_CheckedChanged);
            // 
            // radioButtonRecipeMedications
            // 
            this.radioButtonRecipeMedications.AutoSize = true;
            this.radioButtonRecipeMedications.Location = new System.Drawing.Point(7, 151);
            this.radioButtonRecipeMedications.Name = "radioButtonRecipeMedications";
            this.radioButtonRecipeMedications.Size = new System.Drawing.Size(156, 24);
            this.radioButtonRecipeMedications.TabIndex = 4;
            this.radioButtonRecipeMedications.Text = "RecipeMedications";
            this.radioButtonRecipeMedications.UseVisualStyleBackColor = true;
            this.radioButtonRecipeMedications.CheckedChanged += new System.EventHandler(this.radioBurronRecipeMedications_CheckedChanged);
            // 
            // radioButtonRecipe
            // 
            this.radioButtonRecipe.AutoSize = true;
            this.radioButtonRecipe.Location = new System.Drawing.Point(7, 120);
            this.radioButtonRecipe.Name = "radioButtonRecipe";
            this.radioButtonRecipe.Size = new System.Drawing.Size(75, 24);
            this.radioButtonRecipe.TabIndex = 3;
            this.radioButtonRecipe.Text = "Recipe";
            this.radioButtonRecipe.UseVisualStyleBackColor = true;
            this.radioButtonRecipe.CheckedChanged += new System.EventHandler(this.radioButtonRecipe_CheckedChanged);
            // 
            // radioButtonDirectory
            // 
            this.radioButtonDirectory.AutoSize = true;
            this.radioButtonDirectory.Location = new System.Drawing.Point(7, 89);
            this.radioButtonDirectory.Name = "radioButtonDirectory";
            this.radioButtonDirectory.Size = new System.Drawing.Size(91, 24);
            this.radioButtonDirectory.TabIndex = 2;
            this.radioButtonDirectory.Text = "Directory";
            this.radioButtonDirectory.UseVisualStyleBackColor = true;
            this.radioButtonDirectory.CheckedChanged += new System.EventHandler(this.radioButtonDirectory_CheckedChanged);
            // 
            // radioButtonPharmacy
            // 
            this.radioButtonPharmacy.AutoSize = true;
            this.radioButtonPharmacy.Location = new System.Drawing.Point(7, 58);
            this.radioButtonPharmacy.Name = "radioButtonPharmacy";
            this.radioButtonPharmacy.Size = new System.Drawing.Size(94, 24);
            this.radioButtonPharmacy.TabIndex = 1;
            this.radioButtonPharmacy.Text = "Pharmacy";
            this.radioButtonPharmacy.UseVisualStyleBackColor = true;
            this.radioButtonPharmacy.CheckedChanged += new System.EventHandler(this.radioButtonPharmacy_CheckedChanged);
            // 
            // radioButtonPacient
            // 
            this.radioButtonPacient.AutoSize = true;
            this.radioButtonPacient.Checked = true;
            this.radioButtonPacient.Location = new System.Drawing.Point(7, 27);
            this.radioButtonPacient.Name = "radioButtonPacient";
            this.radioButtonPacient.Size = new System.Drawing.Size(77, 24);
            this.radioButtonPacient.TabIndex = 0;
            this.radioButtonPacient.TabStop = true;
            this.radioButtonPacient.Text = "Pacient";
            this.radioButtonPacient.UseVisualStyleBackColor = true;
            this.radioButtonPacient.CheckedChanged += new System.EventHandler(this.radioButtonPacient_CheckedChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(958, 456);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(272, 29);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(958, 386);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(272, 29);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(958, 421);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(272, 29);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1261, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя пациента";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1258, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 27);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1258, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 27);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1261, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Дата рождения пациента";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1261, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 27);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1261, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Основной диагноз";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1258, 243);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(253, 27);
            this.textBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1261, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Сопутствующий диагноз";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1258, 305);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(253, 27);
            this.textBox5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1261, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Наличие льготы";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1258, 367);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(253, 27);
            this.textBox6.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1261, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Идентификатор запроса";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1261, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1389, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(1261, 187);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(250, 28);
            this.comboBox3.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1258, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1258, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 28);
            this.comboBox2.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1261, 187);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker2.TabIndex = 23;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(1261, 243);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker3.TabIndex = 24;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(1258, 367);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(250, 28);
            this.comboBox4.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 621);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "База данных Аптека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonRequest;
        private System.Windows.Forms.RadioButton radioButtonSale;
        private System.Windows.Forms.RadioButton radioButtonPseudony;
        private System.Windows.Forms.RadioButton radioButtonPharmacyType;
        private System.Windows.Forms.RadioButton radioButtonPharmacyMedications;
        private System.Windows.Forms.RadioButton radioButtonRecipeMedications;
        private System.Windows.Forms.RadioButton radioButtonRecipe;
        private System.Windows.Forms.RadioButton radioButtonDirectory;
        private System.Windows.Forms.RadioButton radioButtonPharmacy;
        private System.Windows.Forms.RadioButton radioButtonPacient;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRequest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAvailability;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSold;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSell;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRevision;
    }
}

