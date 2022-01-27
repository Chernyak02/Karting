namespace Karting
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.Date);
            this.panel2.Location = new System.Drawing.Point(-8, 549);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 118);
            this.panel2.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date.Location = new System.Drawing.Point(56, 39);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(89, 37);
            this.Date.TabIndex = 2;
            this.Date.Text = "label3";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 129);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(340, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Москва, Россия 20 июня 2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(387, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kart Skills 2017";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(446, 219);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(283, 31);
            this.Email.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(370, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(425, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Форма авторизации";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(446, 292);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(283, 31);
            this.Password.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(330, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password:";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Gray;
            this.Cancel.Location = new System.Drawing.Point(537, 395);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(142, 39);
            this.Cancel.TabIndex = 29;
            this.Cancel.Text = "Cansel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Gray;
            this.Login.Location = new System.Drawing.Point(378, 395);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(142, 39);
            this.Login.TabIndex = 28;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization";
            this.Text = "KartSkills2017";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Label Date;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private TextBox Email;
        private Label label6;
        private Label label5;
        private TextBox Password;
        private Label label3;
        private Button Cancel;
        private Button Login;
    }
}