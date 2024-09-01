namespace CodeFirstSample
{
    partial class Form1
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
            this.btnInsertWithDapper = new System.Windows.Forms.Button();
            this.btnIsertWithdapperSp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertWithDapper
            // 
            this.btnInsertWithDapper.Location = new System.Drawing.Point(28, 21);
            this.btnInsertWithDapper.Name = "btnInsertWithDapper";
            this.btnInsertWithDapper.Size = new System.Drawing.Size(162, 23);
            this.btnInsertWithDapper.TabIndex = 0;
            this.btnInsertWithDapper.Text = "Insert With Dapper";
            this.btnInsertWithDapper.UseVisualStyleBackColor = true;
            this.btnInsertWithDapper.Click += new System.EventHandler(this.btnInsertWithDapper_Click);
            // 
            // btnIsertWithdapperSp
            // 
            this.btnIsertWithdapperSp.Location = new System.Drawing.Point(28, 68);
            this.btnIsertWithdapperSp.Name = "btnIsertWithdapperSp";
            this.btnIsertWithdapperSp.Size = new System.Drawing.Size(162, 23);
            this.btnIsertWithdapperSp.TabIndex = 1;
            this.btnIsertWithdapperSp.Text = "Insert With Dapper - SP ";
            this.btnIsertWithdapperSp.UseVisualStyleBackColor = true;
            this.btnIsertWithdapperSp.Click += new System.EventHandler(this.btnIsertWithdapperSp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIsertWithdapperSp);
            this.Controls.Add(this.btnInsertWithDapper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertWithDapper;
        private System.Windows.Forms.Button btnIsertWithdapperSp;
    }
}

