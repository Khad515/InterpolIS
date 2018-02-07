namespace Kartoteka
{
    partial class FSyndicate_Create
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
            this.syndicate_name_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.syndicate_date_box = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.syndicate_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syndicate_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syndicate_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.id_num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_num)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // syndicate_name_box
            // 
            this.syndicate_name_box.Location = new System.Drawing.Point(78, 22);
            this.syndicate_name_box.Name = "syndicate_name_box";
            this.syndicate_name_box.Size = new System.Drawing.Size(142, 20);
            this.syndicate_name_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата основания:";
            // 
            // syndicate_date_box
            // 
            this.syndicate_date_box.Location = new System.Drawing.Point(111, 54);
            this.syndicate_date_box.Mask = "00/00/0000";
            this.syndicate_date_box.Name = "syndicate_date_box";
            this.syndicate_date_box.Size = new System.Drawing.Size(61, 20);
            this.syndicate_date_box.TabIndex = 3;
            this.syndicate_date_box.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.syndicate_id,
            this.syndicate_name,
            this.syndicate_date});
            this.dataGridView1.Location = new System.Drawing.Point(15, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(456, 245);
            this.dataGridView1.TabIndex = 5;
            // 
            // syndicate_id
            // 
            this.syndicate_id.HeaderText = "ID";
            this.syndicate_id.Name = "syndicate_id";
            this.syndicate_id.ReadOnly = true;
            this.syndicate_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.syndicate_id.Width = 50;
            // 
            // syndicate_name
            // 
            this.syndicate_name.HeaderText = "Название";
            this.syndicate_name.Name = "syndicate_name";
            this.syndicate_name.ReadOnly = true;
            this.syndicate_name.Width = 220;
            // 
            // syndicate_date
            // 
            this.syndicate_date.HeaderText = "Дата основания";
            this.syndicate_date.Name = "syndicate_date";
            this.syndicate_date.ReadOnly = true;
            this.syndicate_date.Width = 150;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // id_num
            // 
            this.id_num.Location = new System.Drawing.Point(203, 347);
            this.id_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.id_num.Name = "id_num";
            this.id_num.Size = new System.Drawing.Size(51, 20);
            this.id_num.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Укажите ID для удаления записи";
            // 
            // FSyndicate_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.id_num);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.syndicate_date_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.syndicate_name_box);
            this.Controls.Add(this.label1);
            this.Name = "FSyndicate_Create";
            this.Text = "Создать запись";
            this.Shown += new System.EventHandler(this.FSyndicate_Create_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox syndicate_name_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox syndicate_date_box;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn syndicate_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn syndicate_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn syndicate_date;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown id_num;
        private System.Windows.Forms.Label label3;
    }
}