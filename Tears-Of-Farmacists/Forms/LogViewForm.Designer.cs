namespace Tears_Of_Farmacists.Forms
{
    partial class LogViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogViewForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.L_T1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.L_T2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.L_T3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.L_T4 = new System.Windows.Forms.Label();
            this.Theme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueAnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 453);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Theme,
            this.Question,
            this.Answer,
            this.TrueAnswer});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(7, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(868, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Controls.Add(this.L_T4, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.L_T3, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.L_T2, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.L_T1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 13);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(876, 59);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бухгалтерия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_T1
            // 
            this.L_T1.AutoSize = true;
            this.L_T1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_T1.Location = new System.Drawing.Point(112, 0);
            this.L_T1.Name = "L_T1";
            this.L_T1.Size = new System.Drawing.Size(103, 59);
            this.L_T1.TabIndex = 1;
            this.L_T1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(221, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 59);
            this.label3.TabIndex = 2;
            this.label3.Text = "Менеджмент";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_T2
            // 
            this.L_T2.AutoSize = true;
            this.L_T2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_T2.Location = new System.Drawing.Point(330, 0);
            this.L_T2.Name = "L_T2";
            this.L_T2.Size = new System.Drawing.Size(103, 59);
            this.L_T2.TabIndex = 3;
            this.L_T2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(439, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 59);
            this.label5.TabIndex = 4;
            this.label5.Text = "Маркетинг";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_T3
            // 
            this.L_T3.AutoSize = true;
            this.L_T3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_T3.Location = new System.Drawing.Point(548, 0);
            this.L_T3.Name = "L_T3";
            this.L_T3.Size = new System.Drawing.Size(103, 59);
            this.L_T3.TabIndex = 5;
            this.L_T3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(657, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 59);
            this.label7.TabIndex = 6;
            this.label7.Text = "ИТ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // L_T4
            // 
            this.L_T4.AutoSize = true;
            this.L_T4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.L_T4.Location = new System.Drawing.Point(766, 0);
            this.L_T4.Name = "L_T4";
            this.L_T4.Size = new System.Drawing.Size(107, 59);
            this.L_T4.TabIndex = 7;
            this.L_T4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Theme
            // 
            this.Theme.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Theme.HeaderText = "Тема";
            this.Theme.Name = "Theme";
            this.Theme.ReadOnly = true;
            this.Theme.Width = 71;
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Question.HeaderText = "Вопрос";
            this.Question.Name = "Question";
            this.Question.ReadOnly = true;
            // 
            // Answer
            // 
            this.Answer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Answer.HeaderText = "Ваш ответ";
            this.Answer.Name = "Answer";
            this.Answer.ReadOnly = true;
            // 
            // TrueAnswer
            // 
            this.TrueAnswer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrueAnswer.HeaderText = "Верный ответ";
            this.TrueAnswer.Name = "TrueAnswer";
            this.TrueAnswer.ReadOnly = true;
            // 
            // LogViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "LogViewForm";
            this.Text = "Результаты теста ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogViewForm_FormClosed);
            this.Shown += new System.EventHandler(this.LogViewForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label L_T4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label L_T3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_T2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_T1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewTextBoxColumn Answer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrueAnswer;
    }
}