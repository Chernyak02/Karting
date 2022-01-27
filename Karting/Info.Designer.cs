namespace Karting
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Kart = new System.Windows.Forms.Button();
            this.Sponsor = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.Date);
            this.panel2.Location = new System.Drawing.Point(-8, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1074, 100);
            this.panel2.TabIndex = 5;
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
            this.panel1.Controls.Add(this.Back);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-8, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 110);
            this.panel1.TabIndex = 4;
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.Location = new System.Drawing.Point(29, 20);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(171, 52);
            this.Back.TabIndex = 2;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(419, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(238, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подробная информация";
            // 
            // Kart
            // 
            this.Kart.BackColor = System.Drawing.Color.Gray;
            this.Kart.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kart.Location = new System.Drawing.Point(48, 182);
            this.Kart.Name = "Kart";
            this.Kart.Size = new System.Drawing.Size(479, 128);
            this.Kart.TabIndex = 7;
            this.Kart.Text = "Kart Skills 2017";
            this.Kart.UseVisualStyleBackColor = false;
            // 
            // Sponsor
            // 
            this.Sponsor.BackColor = System.Drawing.Color.Gray;
            this.Sponsor.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sponsor.Location = new System.Drawing.Point(567, 182);
            this.Sponsor.Name = "Sponsor";
            this.Sponsor.Size = new System.Drawing.Size(479, 128);
            this.Sponsor.TabIndex = 8;
            this.Sponsor.Text = "Список благотворительных организаций";
            this.Sponsor.UseVisualStyleBackColor = false;
            this.Sponsor.Click += new System.EventHandler(this.Sponsor_Click);
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.Gray;
            this.Result.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Result.Location = new System.Drawing.Point(48, 338);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(479, 128);
            this.Result.TabIndex = 9;
            this.Result.Text = "Предыдущие результаты";
            this.Result.UseVisualStyleBackColor = false;
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1058, 664);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.Sponsor);
            this.Controls.Add(this.Kart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Info";
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
        private Button Back;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button Kart;
        private Button Sponsor;
        private Button Result;
    }
}