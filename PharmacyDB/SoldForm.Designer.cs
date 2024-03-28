
namespace PharmacyDB
{
    partial class SoldForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPhName = new System.Windows.Forms.TextBox();
            this.comboBoxPhId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(444, 246);
            this.dataGridView1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPhName
            // 
            this.textBoxPhName.Location = new System.Drawing.Point(206, 60);
            this.textBoxPhName.Name = "textBoxPhName";
            this.textBoxPhName.ReadOnly = true;
            this.textBoxPhName.Size = new System.Drawing.Size(250, 27);
            this.textBoxPhName.TabIndex = 20;
            this.textBoxPhName.Click += new System.EventHandler(this.textBoxPhName_Click);
            // 
            // comboBoxPhId
            // 
            this.comboBoxPhId.FormattingEnabled = true;
            this.comboBoxPhId.Location = new System.Drawing.Point(206, 15);
            this.comboBoxPhId.Name = "comboBoxPhId";
            this.comboBoxPhId.Size = new System.Drawing.Size(250, 28);
            this.comboBoxPhId.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Название аптеки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Идентификатор аптеки";
            // 
            // SoldForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPhName);
            this.Controls.Add(this.comboBoxPhId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "SoldForm";
            this.Text = "SoldForm";
            this.Load += new System.EventHandler(this.SoldForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPhName;
        private System.Windows.Forms.ComboBox comboBoxPhId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}