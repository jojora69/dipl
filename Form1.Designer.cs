
namespace DiplomSemivan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.data_groups = new System.Windows.Forms.DataGridView();
            this.data_less = new System.Windows.Forms.DataGridView();
            this.data_cabinet = new System.Windows.Forms.DataGridView();
            this.data_sotrud = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_groups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_less)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_cabinet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_sotrud)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.data_groups);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Группы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.data_less);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Предметы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.data_cabinet);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 371);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Кабинеты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.data_sotrud);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 371);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сотрудники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // data_groups
            // 
            this.data_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_groups.Dock = System.Windows.Forms.DockStyle.Left;
            this.data_groups.Location = new System.Drawing.Point(3, 3);
            this.data_groups.Name = "data_groups";
            this.data_groups.Size = new System.Drawing.Size(357, 365);
            this.data_groups.TabIndex = 0;
            // 
            // data_less
            // 
            this.data_less.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_less.Dock = System.Windows.Forms.DockStyle.Left;
            this.data_less.Location = new System.Drawing.Point(3, 3);
            this.data_less.Name = "data_less";
            this.data_less.Size = new System.Drawing.Size(357, 365);
            this.data_less.TabIndex = 1;
            // 
            // data_cabinet
            // 
            this.data_cabinet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cabinet.Dock = System.Windows.Forms.DockStyle.Left;
            this.data_cabinet.Location = new System.Drawing.Point(0, 0);
            this.data_cabinet.Name = "data_cabinet";
            this.data_cabinet.Size = new System.Drawing.Size(357, 371);
            this.data_cabinet.TabIndex = 1;
            // 
            // data_sotrud
            // 
            this.data_sotrud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_sotrud.Dock = System.Windows.Forms.DockStyle.Left;
            this.data_sotrud.Location = new System.Drawing.Point(0, 0);
            this.data_sotrud.Name = "data_sotrud";
            this.data_sotrud.Size = new System.Drawing.Size(357, 371);
            this.data_sotrud.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_groups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_less)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_cabinet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_sotrud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView data_groups;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView data_less;
        private System.Windows.Forms.DataGridView data_cabinet;
        private System.Windows.Forms.DataGridView data_sotrud;
    }
}

