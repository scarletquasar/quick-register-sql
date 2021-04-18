namespace QUICKREGISTERSQL
{
    partial class Main_
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.pName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.ClearRegisterBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(439, 64);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(80, 23);
            this.RegisterBtn.TabIndex = 0;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(59, 12);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(460, 20);
            this.pName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "AGE:";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(59, 38);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(460, 20);
            this.Age.TabIndex = 5;
            // 
            // ClearRegisterBtn
            // 
            this.ClearRegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearRegisterBtn.Location = new System.Drawing.Point(12, 64);
            this.ClearRegisterBtn.Name = "ClearRegisterBtn";
            this.ClearRegisterBtn.Size = new System.Drawing.Size(182, 23);
            this.ClearRegisterBtn.TabIndex = 6;
            this.ClearRegisterBtn.Text = "CLEAR ALL REGISTERS";
            this.ClearRegisterBtn.UseVisualStyleBackColor = true;
            this.ClearRegisterBtn.Click += new System.EventHandler(this.ClearRegisterBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CONNECTION STRING:";
            // 
            // ConnString
            // 
            this.ConnString.Location = new System.Drawing.Point(12, 115);
            this.ConnString.Multiline = true;
            this.ConnString.Name = "ConnString";
            this.ConnString.Size = new System.Drawing.Size(507, 48);
            this.ConnString.TabIndex = 8;
            this.ConnString.TextChanged += new System.EventHandler(this.ConnString_TextChanged);
            // 
            // Main_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 167);
            this.Controls.Add(this.ConnString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClearRegisterBtn);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pName);
            this.Controls.Add(this.RegisterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_";
            this.ShowIcon = false;
            this.Text = "QuickRegister - SQL SERVER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Button ClearRegisterBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConnString;
    }
}

