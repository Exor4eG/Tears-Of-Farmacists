namespace Tears_Of_Farmacists.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.TB_Pass = new System.Windows.Forms.TextBox();
            this.B_Login = new System.Windows.Forms.Button();
            this.B_Cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TB_Login, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TB_Pass, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.B_Login, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.B_Cancel, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 203);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 45);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пользователь:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 3);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введите учётные данные Farmacy для авторизации";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Login
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TB_Login, 2);
            this.TB_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Login.Location = new System.Drawing.Point(154, 55);
            this.TB_Login.Margin = new System.Windows.Forms.Padding(10);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(318, 22);
            this.TB_Login.TabIndex = 1;
            // 
            // TB_Pass
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TB_Pass, 2);
            this.TB_Pass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Pass.Location = new System.Drawing.Point(154, 100);
            this.TB_Pass.Margin = new System.Windows.Forms.Padding(10);
            this.TB_Pass.Name = "TB_Pass";
            this.TB_Pass.PasswordChar = '*';
            this.TB_Pass.Size = new System.Drawing.Size(318, 22);
            this.TB_Pass.TabIndex = 2;
            this.TB_Pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_Pass_KeyDown);
            // 
            // B_Login
            // 
            this.B_Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_Login.Location = new System.Drawing.Point(154, 145);
            this.B_Login.Margin = new System.Windows.Forms.Padding(10);
            this.B_Login.Name = "B_Login";
            this.B_Login.Size = new System.Drawing.Size(148, 25);
            this.B_Login.TabIndex = 3;
            this.B_Login.Text = "Войти";
            this.B_Login.UseVisualStyleBackColor = true;
            this.B_Login.Click += new System.EventHandler(this.B_Login_Click);
            // 
            // B_Cancel
            // 
            this.B_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.B_Cancel.Location = new System.Drawing.Point(322, 145);
            this.B_Cancel.Margin = new System.Windows.Forms.Padding(10);
            this.B_Cancel.Name = "B_Cancel";
            this.B_Cancel.Size = new System.Drawing.Size(150, 25);
            this.B_Cancel.TabIndex = 4;
            this.B_Cancel.Text = "Отмена";
            this.B_Cancel.UseVisualStyleBackColor = true;
            this.B_Cancel.Click += new System.EventHandler(this.B_Cancel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(482, 203);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 250);
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход в систему";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.TextBox TB_Pass;
        private System.Windows.Forms.Button B_Login;
        private System.Windows.Forms.Button B_Cancel;
    }
}