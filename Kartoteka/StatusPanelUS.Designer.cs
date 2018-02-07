namespace Kartoteka
{
    partial class StatusPanelUS
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusPanelUS));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.екатеринаСамойленкоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.михаилМищенкоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иванюкСергейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.викторПекарьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 18);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(313, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            this.statusStrip1.Click += new System.EventHandler(this.statusStrip1_Click);
            this.statusStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.statusStrip1_KeyDown);
            this.statusStrip1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.statusStrip1_KeyPress);
            this.statusStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.statusStrip1_MouseDown);
            this.statusStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.statusStrip1_MouseMove);
            this.statusStrip1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.statusStrip1_PreviewKeyDown);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "NumLock\\CapsLock";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(28, 17);
            this.toolStripStatusLabel2.Text = "Num";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel3.Text = "Caps";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(109, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Click += new System.EventHandler(this.toolStripStatusLabel4_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.иванюкСергейToolStripMenuItem,
            this.михаилМищенкоToolStripMenuItem,
            this.екатеринаСамойленкоToolStripMenuItem,
            this.викторПекарьToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // екатеринаСамойленкоToolStripMenuItem
            // 
            this.екатеринаСамойленкоToolStripMenuItem.Name = "екатеринаСамойленкоToolStripMenuItem";
            this.екатеринаСамойленкоToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.екатеринаСамойленкоToolStripMenuItem.Text = "Екатерина Самойленко";
            // 
            // михаилМищенкоToolStripMenuItem
            // 
            this.михаилМищенкоToolStripMenuItem.Name = "михаилМищенкоToolStripMenuItem";
            this.михаилМищенкоToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.михаилМищенкоToolStripMenuItem.Text = "Михаил Мищенко";
            // 
            // иванюкСергейToolStripMenuItem
            // 
            this.иванюкСергейToolStripMenuItem.Name = "иванюкСергейToolStripMenuItem";
            this.иванюкСергейToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.иванюкСергейToolStripMenuItem.Text = "Сергей Иванюк";
            this.иванюкСергейToolStripMenuItem.Click += new System.EventHandler(this.иванюкСергейToolStripMenuItem_Click);
            // 
            // викторПекарьToolStripMenuItem
            // 
            this.викторПекарьToolStripMenuItem.Name = "викторПекарьToolStripMenuItem";
            this.викторПекарьToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.викторПекарьToolStripMenuItem.Text = "Виктор Пекарь";
            // 
            // StatusPanelUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Name = "StatusPanelUS";
            this.Size = new System.Drawing.Size(313, 40);
            this.Load += new System.EventHandler(this.StatusPanelUS_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StatusPanelUS_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem иванюкСергейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem михаилМищенкоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem екатеринаСамойленкоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem викторПекарьToolStripMenuItem;
    }
}
