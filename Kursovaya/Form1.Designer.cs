
namespace Kursovaya
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеКлиентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(627, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepPink;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.добавлениеКлиентовToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форма1ToolStripMenuItem,
            this.форма2ToolStripMenuItem,
            this.форма3ToolStripMenuItem,
            this.форма4ToolStripMenuItem,
            this.форма5ToolStripMenuItem,
            this.форма6ToolStripMenuItem,
            this.форма7ToolStripMenuItem,
            this.форма8ToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // форма1ToolStripMenuItem
            // 
            this.форма1ToolStripMenuItem.Name = "форма1ToolStripMenuItem";
            this.форма1ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.форма1ToolStripMenuItem.Text = "Пациенты";
            this.форма1ToolStripMenuItem.Click += new System.EventHandler(this.форма1ToolStripMenuItem_Click);
            // 
            // форма2ToolStripMenuItem
            // 
            this.форма2ToolStripMenuItem.Name = "форма2ToolStripMenuItem";
            this.форма2ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.форма2ToolStripMenuItem.Text = "Сотрудники";
            this.форма2ToolStripMenuItem.Click += new System.EventHandler(this.форма2ToolStripMenuItem_Click);
            // 
            // форма3ToolStripMenuItem
            // 
            this.форма3ToolStripMenuItem.Name = "форма3ToolStripMenuItem";
            this.форма3ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.форма3ToolStripMenuItem.Text = "Расписание";
            this.форма3ToolStripMenuItem.Click += new System.EventHandler(this.форма3ToolStripMenuItem_Click);
            // 
            // форма4ToolStripMenuItem
            // 
            this.форма4ToolStripMenuItem.Name = "форма4ToolStripMenuItem";
            this.форма4ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.форма4ToolStripMenuItem.Text = "Зубная карта";
            this.форма4ToolStripMenuItem.Click += new System.EventHandler(this.форма4ToolStripMenuItem_Click);
            // 
            // форма5ToolStripMenuItem
            // 
            this.форма5ToolStripMenuItem.Name = "форма5ToolStripMenuItem";
            this.форма5ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.форма5ToolStripMenuItem.Text = "Зарплата";
            this.форма5ToolStripMenuItem.Click += new System.EventHandler(this.форма5ToolStripMenuItem_Click);
            // 
            // форма6ToolStripMenuItem
            // 
            this.форма6ToolStripMenuItem.Name = "форма6ToolStripMenuItem";
            this.форма6ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.форма6ToolStripMenuItem.Text = "Финансы";
            this.форма6ToolStripMenuItem.Click += new System.EventHandler(this.форма6ToolStripMenuItem_Click);
            // 
            // форма7ToolStripMenuItem
            // 
            this.форма7ToolStripMenuItem.Name = "форма7ToolStripMenuItem";
            this.форма7ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.форма7ToolStripMenuItem.Text = "Отчёт";
            this.форма7ToolStripMenuItem.Click += new System.EventHandler(this.форма7ToolStripMenuItem_Click);
            // 
            // форма8ToolStripMenuItem
            // 
            this.форма8ToolStripMenuItem.Name = "форма8ToolStripMenuItem";
            this.форма8ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.форма8ToolStripMenuItem.Text = "Маркетинг";
            this.форма8ToolStripMenuItem.Click += new System.EventHandler(this.форма8ToolStripMenuItem_Click);
            // 
            // добавлениеКлиентовToolStripMenuItem
            // 
            this.добавлениеКлиентовToolStripMenuItem.Name = "добавлениеКлиентовToolStripMenuItem";
            this.добавлениеКлиентовToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.добавлениеКлиентовToolStripMenuItem.Text = "Добавление пациентов";
            this.добавлениеКлиентовToolStripMenuItem.Click += new System.EventHandler(this.добавлениеКлиентовToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 413);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Пациенты";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem форма8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеКлиентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
    }
}

