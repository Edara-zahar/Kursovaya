
namespace Kursovaya
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.форма1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАбониментToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(476, 187);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepPink;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.добавитьАбониментToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форма1ToolStripMenuItem,
            this.форма2ToolStripMenuItem,
            this.форма3ToolStripMenuItem,
            this.форма4ToolStripMenuItem,
            this.форма5ToolStripMenuItem,
            this.форма6ToolStripMenuItem,
            this.форма7ToolStripMenuItem,
            this.форма8ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.toolStripMenuItem1.Text = "Справка";
            // 
            // форма1ToolStripMenuItem
            // 
            this.форма1ToolStripMenuItem.Name = "форма1ToolStripMenuItem";
            this.форма1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.форма1ToolStripMenuItem.Text = "Пациенты";
            this.форма1ToolStripMenuItem.Click += new System.EventHandler(this.форма1ToolStripMenuItem_Click_1);
            // 
            // форма2ToolStripMenuItem
            // 
            this.форма2ToolStripMenuItem.Name = "форма2ToolStripMenuItem";
            this.форма2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.форма2ToolStripMenuItem.Text = "Сотрудники";
            this.форма2ToolStripMenuItem.Click += new System.EventHandler(this.форма2ToolStripMenuItem_Click);
            // 
            // форма3ToolStripMenuItem
            // 
            this.форма3ToolStripMenuItem.Name = "форма3ToolStripMenuItem";
            this.форма3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.форма3ToolStripMenuItem.Text = "Расписание";
            this.форма3ToolStripMenuItem.Click += new System.EventHandler(this.форма3ToolStripMenuItem_Click);
            // 
            // форма4ToolStripMenuItem
            // 
            this.форма4ToolStripMenuItem.Name = "форма4ToolStripMenuItem";
            this.форма4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.форма4ToolStripMenuItem.Text = "Зубная карта";
            this.форма4ToolStripMenuItem.Click += new System.EventHandler(this.форма4ToolStripMenuItem_Click);
            // 
            // форма5ToolStripMenuItem
            // 
            this.форма5ToolStripMenuItem.Name = "форма5ToolStripMenuItem";
            this.форма5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.форма5ToolStripMenuItem.Text = "Зарплата";
            this.форма5ToolStripMenuItem.Click += new System.EventHandler(this.форма5ToolStripMenuItem_Click);
            // 
            // форма6ToolStripMenuItem
            // 
            this.форма6ToolStripMenuItem.Name = "форма6ToolStripMenuItem";
            this.форма6ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.форма6ToolStripMenuItem.Text = "Финансы";
            this.форма6ToolStripMenuItem.Click += new System.EventHandler(this.форма6ToolStripMenuItem_Click);
            // 
            // форма7ToolStripMenuItem
            // 
            this.форма7ToolStripMenuItem.Name = "форма7ToolStripMenuItem";
            this.форма7ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.форма7ToolStripMenuItem.Text = "Отчёт";
            this.форма7ToolStripMenuItem.Click += new System.EventHandler(this.форма7ToolStripMenuItem_Click);
            // 
            // форма8ToolStripMenuItem
            // 
            this.форма8ToolStripMenuItem.Name = "форма8ToolStripMenuItem";
            this.форма8ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.форма8ToolStripMenuItem.Text = "Маркетинг";
            this.форма8ToolStripMenuItem.Click += new System.EventHandler(this.форма8ToolStripMenuItem_Click);
            // 
            // добавитьАбониментToolStripMenuItem
            // 
            this.добавитьАбониментToolStripMenuItem.Name = "добавитьАбониментToolStripMenuItem";
            this.добавитьАбониментToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.добавитьАбониментToolStripMenuItem.Text = "Добавить сотрудника";
            this.добавитьАбониментToolStripMenuItem.Click += new System.EventHandler(this.добавитьАбониментToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 362);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Сотрудники";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem форма1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАбониментToolStripMenuItem;
    }
}