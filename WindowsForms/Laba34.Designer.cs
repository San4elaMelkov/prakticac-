
namespace WindowsForms
{
    partial class Laba34
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
            System.Windows.Forms.Button button3;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Button button1;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.updateUsers = new System.Windows.Forms.Button();
            this.deleteUsers = new System.Windows.Forms.Button();
            this.addUsers = new System.Windows.Forms.Button();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.updateLogAuctions = new System.Windows.Forms.Button();
            this.deleteLogAuctions = new System.Windows.Forms.Button();
            this.addLogAuctions = new System.Windows.Forms.Button();
            this.dataGridKonf = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridPriglos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridVznos = new System.Windows.Forms.DataGridView();
            button3 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKonf)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPriglos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVznos)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            button3.Location = new System.Drawing.Point(3, 395);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(786, 70);
            button3.TabIndex = 33;
            button3.Text = "Вывести";
            button3.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 506);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.updateUsers);
            this.tabPage4.Controls.Add(this.deleteUsers);
            this.tabPage4.Controls.Add(this.addUsers);
            this.tabPage4.Controls.Add(this.dataGridUsers);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 468);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Пользователи";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // updateUsers
            // 
            this.updateUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.updateUsers.Location = new System.Drawing.Point(379, 398);
            this.updateUsers.Name = "updateUsers";
            this.updateUsers.Size = new System.Drawing.Size(202, 70);
            this.updateUsers.TabIndex = 31;
            this.updateUsers.Text = "Обновить";
            this.updateUsers.UseVisualStyleBackColor = true;
            this.updateUsers.Click += new System.EventHandler(this.updateUsers_Click);
            // 
            // deleteUsers
            // 
            this.deleteUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteUsers.Location = new System.Drawing.Point(210, 398);
            this.deleteUsers.Name = "deleteUsers";
            this.deleteUsers.Size = new System.Drawing.Size(169, 70);
            this.deleteUsers.TabIndex = 30;
            this.deleteUsers.Text = "Удалить";
            this.deleteUsers.UseVisualStyleBackColor = true;
            this.deleteUsers.Click += new System.EventHandler(this.deleteUsers_Click);
            // 
            // addUsers
            // 
            this.addUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.addUsers.Location = new System.Drawing.Point(0, 398);
            this.addUsers.Name = "addUsers";
            this.addUsers.Size = new System.Drawing.Size(210, 70);
            this.addUsers.TabIndex = 29;
            this.addUsers.Text = "Добавить";
            this.addUsers.UseVisualStyleBackColor = true;
            this.addUsers.Click += new System.EventHandler(this.addUsers_Click);
            // 
            // dataGridUsers
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridUsers.Location = new System.Drawing.Point(0, 0);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUsers.RowHeadersWidth = 51;
            this.dataGridUsers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridUsers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.RowTemplate.Height = 30;
            this.dataGridUsers.Size = new System.Drawing.Size(792, 398);
            this.dataGridUsers.TabIndex = 28;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.updateLogAuctions);
            this.tabPage5.Controls.Add(this.deleteLogAuctions);
            this.tabPage5.Controls.Add(this.addLogAuctions);
            this.tabPage5.Controls.Add(this.dataGridKonf);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 468);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Конференции";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // updateLogAuctions
            // 
            this.updateLogAuctions.Dock = System.Windows.Forms.DockStyle.Left;
            this.updateLogAuctions.Location = new System.Drawing.Point(379, 398);
            this.updateLogAuctions.Name = "updateLogAuctions";
            this.updateLogAuctions.Size = new System.Drawing.Size(202, 70);
            this.updateLogAuctions.TabIndex = 31;
            this.updateLogAuctions.Text = "Обновить";
            this.updateLogAuctions.UseVisualStyleBackColor = true;
            this.updateLogAuctions.Click += new System.EventHandler(this.updateLogAuctions_Click);
            // 
            // deleteLogAuctions
            // 
            this.deleteLogAuctions.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteLogAuctions.Location = new System.Drawing.Point(210, 398);
            this.deleteLogAuctions.Name = "deleteLogAuctions";
            this.deleteLogAuctions.Size = new System.Drawing.Size(169, 70);
            this.deleteLogAuctions.TabIndex = 30;
            this.deleteLogAuctions.Text = "Удалить";
            this.deleteLogAuctions.UseVisualStyleBackColor = true;
            this.deleteLogAuctions.Click += new System.EventHandler(this.deleteLogAuctions_Click);
            // 
            // addLogAuctions
            // 
            this.addLogAuctions.Dock = System.Windows.Forms.DockStyle.Left;
            this.addLogAuctions.Location = new System.Drawing.Point(0, 398);
            this.addLogAuctions.Name = "addLogAuctions";
            this.addLogAuctions.Size = new System.Drawing.Size(210, 70);
            this.addLogAuctions.TabIndex = 29;
            this.addLogAuctions.Text = "Добавить";
            this.addLogAuctions.UseVisualStyleBackColor = true;
            this.addLogAuctions.Click += new System.EventHandler(this.addLogAuctions_Click);
            // 
            // dataGridKonf
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridKonf.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridKonf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridKonf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridKonf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridKonf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridKonf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridKonf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKonf.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridKonf.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridKonf.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridKonf.Location = new System.Drawing.Point(0, 0);
            this.dataGridKonf.Name = "dataGridKonf";
            this.dataGridKonf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridKonf.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridKonf.RowHeadersWidth = 51;
            this.dataGridKonf.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridKonf.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridKonf.RowTemplate.Height = 30;
            this.dataGridKonf.Size = new System.Drawing.Size(792, 398);
            this.dataGridKonf.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.dataGridPriglos);
            this.tabPage1.Controls.Add(button3);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 468);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Приглашенные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox3.Location = new System.Drawing.Point(3, 302);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(786, 31);
            this.textBox3.TabIndex = 39;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox2.Location = new System.Drawing.Point(3, 333);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(786, 31);
            this.textBox2.TabIndex = 38;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(3, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(786, 31);
            this.textBox1.TabIndex = 37;
            // 
            // dataGridPriglos
            // 
            this.dataGridPriglos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPriglos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPriglos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridPriglos.Location = new System.Drawing.Point(3, 3);
            this.dataGridPriglos.Name = "dataGridPriglos";
            this.dataGridPriglos.Size = new System.Drawing.Size(786, 392);
            this.dataGridPriglos.TabIndex = 36;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridVznos);
            this.tabPage2.Controls.Add(button1);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(792, 468);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.Text = "Уплатившие взнос";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridVznos
            // 
            this.dataGridVznos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridVznos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVznos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridVznos.Location = new System.Drawing.Point(0, 0);
            this.dataGridVznos.Name = "dataGridVznos";
            this.dataGridVznos.Size = new System.Drawing.Size(792, 398);
            this.dataGridVznos.TabIndex = 38;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            button1.Location = new System.Drawing.Point(0, 398);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(792, 70);
            button1.TabIndex = 37;
            button1.Text = "Вывести";
            button1.UseVisualStyleBackColor = true;
            // 
            // Laba34
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.tabControl1);
            this.Name = "Laba34";
            this.Text = "Laba34";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Laba34_FormClosed);
            this.Load += new System.EventHandler(this.Laba34_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKonf)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPriglos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVznos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button updateUsers;
        private System.Windows.Forms.Button deleteUsers;
        private System.Windows.Forms.Button addUsers;
        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button updateLogAuctions;
        private System.Windows.Forms.Button deleteLogAuctions;
        private System.Windows.Forms.Button addLogAuctions;
        private System.Windows.Forms.DataGridView dataGridKonf;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridPriglos;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridVznos;
    }
}