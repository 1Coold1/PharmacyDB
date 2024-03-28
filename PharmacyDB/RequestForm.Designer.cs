
namespace PharmacyDB
{
    partial class RequestForm
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
            this.comboBoxPharmacyId = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxMedId = new System.Windows.Forms.ComboBox();
            this.textBoxPharmacyName = new System.Windows.Forms.TextBox();
            this.textBoxMedName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxPharmacyId
            // 
            this.comboBoxPharmacyId.FormattingEnabled = true;
            this.comboBoxPharmacyId.Location = new System.Drawing.Point(206, 12);
            this.comboBoxPharmacyId.Name = "comboBoxPharmacyId";
            this.comboBoxPharmacyId.Size = new System.Drawing.Size(250, 28);
            this.comboBoxPharmacyId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Идентификатор аптеки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название аптеки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Идентификатор лекарства";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название лекарства";
            // 
            // comboBoxMedId
            // 
            this.comboBoxMedId.FormattingEnabled = true;
            this.comboBoxMedId.Location = new System.Drawing.Point(206, 97);
            this.comboBoxMedId.Name = "comboBoxMedId";
            this.comboBoxMedId.Size = new System.Drawing.Size(250, 28);
            this.comboBoxMedId.TabIndex = 5;
            // 
            // textBoxPharmacyName
            // 
            this.textBoxPharmacyName.Location = new System.Drawing.Point(206, 57);
            this.textBoxPharmacyName.Name = "textBoxPharmacyName";
            this.textBoxPharmacyName.ReadOnly = true;
            this.textBoxPharmacyName.Size = new System.Drawing.Size(250, 27);
            this.textBoxPharmacyName.TabIndex = 6;
            this.textBoxPharmacyName.Click += new System.EventHandler(this.textBoxPharmacyName_Click);
            // 
            // textBoxMedName
            // 
            this.textBoxMedName.Location = new System.Drawing.Point(206, 142);
            this.textBoxMedName.Name = "textBoxMedName";
            this.textBoxMedName.ReadOnly = true;
            this.textBoxMedName.Size = new System.Drawing.Size(250, 27);
            this.textBoxMedName.TabIndex = 7;
            this.textBoxMedName.Click += new System.EventHandler(this.textBoxMedName_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Количество лекарства";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(206, 182);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(250, 27);
            this.textBoxCount.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата производства";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Срок годности";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(206, 217);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerStart.TabIndex = 12;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(206, 253);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerEnd.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Выполнить запрос";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMedName);
            this.Controls.Add(this.textBoxPharmacyName);
            this.Controls.Add(this.comboBoxMedId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxPharmacyId);
            this.Name = "RequestForm";
            this.Text = "RequestForm";
            this.Load += new System.EventHandler(this.RequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPharmacyId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxMedId;
        private System.Windows.Forms.TextBox textBoxPharmacyName;
        private System.Windows.Forms.TextBox textBoxMedName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button button1;
    }
}