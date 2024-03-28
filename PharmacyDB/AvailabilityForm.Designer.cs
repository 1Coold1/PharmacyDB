
namespace PharmacyDB
{
    partial class AvailabilityForm
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
            this.textBoxMedName = new System.Windows.Forms.TextBox();
            this.comboBoxMedId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Location = new System.Drawing.Point(211, 57);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.ReadOnly = true;
            this.textBoxMedName.Size = new System.Drawing.Size(250, 27);
            this.textBoxMedName.TabIndex = 11;
            this.textBoxMedName.Click += new System.EventHandler(this.textBoxMedName_Click);
            // 
            // comboBoxMedId
            // 
            this.comboBoxMedId.FormattingEnabled = true;
            this.comboBoxMedId.Location = new System.Drawing.Point(211, 12);
            this.comboBoxMedId.Name = "comboBoxMedId";
            this.comboBoxMedId.Size = new System.Drawing.Size(250, 28);
            this.comboBoxMedId.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название лекарства";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Идентификатор лекарства";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(17, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 246);
            this.dataGridView1.TabIndex = 16;
            // 
            // AvailabilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMedName);
            this.Controls.Add(this.comboBoxMedId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AvailabilityForm";
            this.Text = "AvailabilityForm";
            this.Load += new System.EventHandler(this.AvailabilityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMedName;
        private System.Windows.Forms.ComboBox comboBoxMedId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}