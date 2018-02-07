namespace Kartoteka
{
    partial class FPreson_Syndicate
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
            this.label1 = new System.Windows.Forms.Label();
            this.bandit_name_lbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bandit_id_lbl = new System.Windows.Forms.Label();
            this.Add_radio = new System.Windows.Forms.RadioButton();
            this.Delete_radio = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // bandit_name_lbl
            // 
            this.bandit_name_lbl.AutoSize = true;
            this.bandit_name_lbl.Location = new System.Drawing.Point(50, 49);
            this.bandit_name_lbl.Name = "bandit_name_lbl";
            this.bandit_name_lbl.Size = new System.Drawing.Size(41, 13);
            this.bandit_name_lbl.TabIndex = 1;
            this.bandit_name_lbl.Text = "<Имя>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id:";
            // 
            // bandit_id_lbl
            // 
            this.bandit_id_lbl.AutoSize = true;
            this.bandit_id_lbl.Location = new System.Drawing.Point(53, 19);
            this.bandit_id_lbl.Name = "bandit_id_lbl";
            this.bandit_id_lbl.Size = new System.Drawing.Size(28, 13);
            this.bandit_id_lbl.TabIndex = 3;
            this.bandit_id_lbl.Text = "<Id>";
            // 
            // Add_radio
            // 
            this.Add_radio.AutoSize = true;
            this.Add_radio.Location = new System.Drawing.Point(15, 105);
            this.Add_radio.Name = "Add_radio";
            this.Add_radio.Size = new System.Drawing.Size(75, 17);
            this.Add_radio.TabIndex = 4;
            this.Add_radio.TabStop = true;
            this.Add_radio.Text = "Добавить";
            this.Add_radio.UseVisualStyleBackColor = true;
            // 
            // Delete_radio
            // 
            this.Delete_radio.AutoSize = true;
            this.Delete_radio.Location = new System.Drawing.Point(108, 105);
            this.Delete_radio.Name = "Delete_radio";
            this.Delete_radio.Size = new System.Drawing.Size(68, 17);
            this.Delete_radio.TabIndex = 5;
            this.Delete_radio.TabStop = true;
            this.Delete_radio.Text = "Удалить";
            this.Delete_radio.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(15, 168);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(66, 20);
            this.maskedTextBox1.TabIndex = 8;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // FPreson_Syndicate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 266);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Delete_radio);
            this.Controls.Add(this.Add_radio);
            this.Controls.Add(this.bandit_id_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bandit_name_lbl);
            this.Controls.Add(this.label1);
            this.Name = "FPreson_Syndicate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление\\удаление записи";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FPreson_Syndicate_FormClosing);
            this.Load += new System.EventHandler(this.FPreson_Syndicate_Load);
            this.Shown += new System.EventHandler(this.FPreson_Syndicate_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label bandit_name_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label bandit_id_lbl;
        private System.Windows.Forms.RadioButton Add_radio;
        private System.Windows.Forms.RadioButton Delete_radio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}