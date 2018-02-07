namespace Kartoteka
{
    partial class FReports
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
            this.button1 = new System.Windows.Forms.Button();
            this.reports_list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.word_radio = new System.Windows.Forms.RadioButton();
            this.excel_radio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.report_info_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reports_list
            // 
            this.reports_list.FormattingEnabled = true;
            this.reports_list.Items.AddRange(new object[] {
            "по росту",
            "по весу",
            "по росту и весу",
            "по дате рождения",
            "по религии",
            "по национальности",
            "по синдикату"});
            this.reports_list.Location = new System.Drawing.Point(12, 34);
            this.reports_list.Name = "reports_list";
            this.reports_list.Size = new System.Drawing.Size(200, 290);
            this.reports_list.TabIndex = 1;
            this.reports_list.SelectedIndexChanged += new System.EventHandler(this.reports_list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите отчет:";
            // 
            // word_radio
            // 
            this.word_radio.AutoSize = true;
            this.word_radio.Location = new System.Drawing.Point(486, 338);
            this.word_radio.Name = "word_radio";
            this.word_radio.Size = new System.Drawing.Size(51, 17);
            this.word_radio.TabIndex = 3;
            this.word_radio.TabStop = true;
            this.word_radio.Text = "Word";
            this.word_radio.UseVisualStyleBackColor = true;
            // 
            // excel_radio
            // 
            this.excel_radio.AutoSize = true;
            this.excel_radio.Location = new System.Drawing.Point(420, 338);
            this.excel_radio.Name = "excel_radio";
            this.excel_radio.Size = new System.Drawing.Size(51, 17);
            this.excel_radio.TabIndex = 4;
            this.excel_radio.TabStop = true;
            this.excel_radio.Text = "Excel";
            this.excel_radio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание:";
            // 
            // report_info_lbl
            // 
            this.report_info_lbl.AutoSize = true;
            this.report_info_lbl.Location = new System.Drawing.Point(243, 57);
            this.report_info_lbl.Name = "report_info_lbl";
            this.report_info_lbl.Size = new System.Drawing.Size(69, 13);
            this.report_info_lbl.TabIndex = 6;
            this.report_info_lbl.Text = "<Описание>";
            // 
            // FReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 373);
            this.Controls.Add(this.report_info_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.excel_radio);
            this.Controls.Add(this.word_radio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reports_list);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "FReports";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.FReports_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox reports_list;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton word_radio;
        private System.Windows.Forms.RadioButton excel_radio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label report_info_lbl;
    }
}