
namespace PharmacyDB
{
    partial class SellForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMedId = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPacientName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Location = new System.Drawing.Point(280, 57);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.ReadOnly = true;
            this.textBoxMedName.Size = new System.Drawing.Size(250, 27);
            this.textBoxMedName.TabIndex = 14;
            this.textBoxMedName.Click += new System.EventHandler(this.textBoxPharmacyName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Название лекарства рецепта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Идентификатор лекарства рецепта";
            // 
            // comboBoxMedId
            // 
            this.comboBoxMedId.FormattingEnabled = true;
            this.comboBoxMedId.Location = new System.Drawing.Point(280, 16);
            this.comboBoxMedId.Name = "comboBoxMedId";
            this.comboBoxMedId.Size = new System.Drawing.Size(250, 28);
            this.comboBoxMedId.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPacientName
            // 
            this.textBoxPacientName.Location = new System.Drawing.Point(280, 106);
            this.textBoxPacientName.Name = "textBoxPacientName";
            this.textBoxPacientName.ReadOnly = true;
            this.textBoxPacientName.Size = new System.Drawing.Size(250, 27);
            this.textBoxPacientName.TabIndex = 18;
            this.textBoxPacientName.Click += new System.EventHandler(this.textBoxPacientName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Имя покупателя";
            // 
            // SellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 239);
            this.Controls.Add(this.textBoxPacientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxMedName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMedId);
            this.Name = "SellForm";
            this.Text = "SellForm";
            this.Load += new System.EventHandler(this.SellForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMedId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPacientName;
        private System.Windows.Forms.Label label3;
    }
}