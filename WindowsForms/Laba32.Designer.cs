
namespace WindowsForms
{
    partial class Laba32
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridAuction = new System.Windows.Forms.DataGridView();
            this.add_ac = new System.Windows.Forms.Button();
            this.delete_ac = new System.Windows.Forms.Button();
            this.update_ac = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuction)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 488);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.update_ac);
            this.tabPage1.Controls.Add(this.delete_ac);
            this.tabPage1.Controls.Add(this.add_ac);
            this.tabPage1.Controls.Add(this.dataGridAuction);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(585, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Аукционы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спецификации";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Вещи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пользователи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 412);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Журнал";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridAuction
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridAuction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridAuction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridAuction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridAuction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAuction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridAuction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAuction.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridAuction.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridAuction.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridAuction.Location = new System.Drawing.Point(3, 3);
            this.dataGridAuction.Name = "dataGridAuction";
            this.dataGridAuction.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridAuction.RowHeadersWidth = 51;
            this.dataGridAuction.RowTemplate.Height = 24;
            this.dataGridAuction.Size = new System.Drawing.Size(579, 398);
            this.dataGridAuction.TabIndex = 19;
            // 
            // add_ac
            // 
            this.add_ac.Dock = System.Windows.Forms.DockStyle.Left;
            this.add_ac.Location = new System.Drawing.Point(3, 401);
            this.add_ac.Name = "add_ac";
            this.add_ac.Size = new System.Drawing.Size(210, 46);
            this.add_ac.TabIndex = 1;
            this.add_ac.Text = "Добавить";
            this.add_ac.UseVisualStyleBackColor = true;
            this.add_ac.Click += new System.EventHandler(this.add_ac_Click);
            // 
            // delete_ac
            // 
            this.delete_ac.Dock = System.Windows.Forms.DockStyle.Left;
            this.delete_ac.Location = new System.Drawing.Point(213, 401);
            this.delete_ac.Name = "delete_ac";
            this.delete_ac.Size = new System.Drawing.Size(169, 46);
            this.delete_ac.TabIndex = 20;
            this.delete_ac.Text = "Удалить";
            this.delete_ac.UseVisualStyleBackColor = true;
            this.delete_ac.Click += new System.EventHandler(this.delete_ac_Click);
            // 
            // update_ac
            // 
            this.update_ac.Dock = System.Windows.Forms.DockStyle.Left;
            this.update_ac.Location = new System.Drawing.Point(382, 401);
            this.update_ac.Name = "update_ac";
            this.update_ac.Size = new System.Drawing.Size(202, 46);
            this.update_ac.TabIndex = 21;
            this.update_ac.Text = "Обновить";
            this.update_ac.UseVisualStyleBackColor = true;
            this.update_ac.Click += new System.EventHandler(this.update_ac_Click);
            // 
            // Laba32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 488);
            this.Controls.Add(this.tabControl1);
            this.Name = "Laba32";
            this.Text = "Laba32";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Laba32_FormClosed);
            this.Load += new System.EventHandler(this.Laba32_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAuction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGridAuction;
        private System.Windows.Forms.Button update_ac;
        private System.Windows.Forms.Button delete_ac;
        private System.Windows.Forms.Button add_ac;
    }
}