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
            this.btnSelectWithDapper = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelectWithDapperSP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertWithDapper
            // 
            this.btnInsertWithDapper.Location = new System.Drawing.Point(28, 12);
            this.btnInsertWithDapper.Name = "btnInsertWithDapper";
            this.btnInsertWithDapper.Size = new System.Drawing.Size(162, 23);
            this.btnInsertWithDapper.TabIndex = 0;
            this.btnInsertWithDapper.Text = "Insert With Dapper";
            this.btnInsertWithDapper.UseVisualStyleBackColor = true;
            this.btnInsertWithDapper.Click += new System.EventHandler(this.btnInsertWithDapper_Click);
            // 
            // btnIsertWithdapperSp
            // 
            this.btnIsertWithdapperSp.Location = new System.Drawing.Point(28, 50);
            this.btnIsertWithdapperSp.Name = "btnIsertWithdapperSp";
            this.btnIsertWithdapperSp.Size = new System.Drawing.Size(162, 23);
            this.btnIsertWithdapperSp.TabIndex = 1;
            this.btnIsertWithdapperSp.Text = "Insert With Dapper - SP ";
            this.btnIsertWithdapperSp.UseVisualStyleBackColor = true;
            this.btnIsertWithdapperSp.Click += new System.EventHandler(this.btnIsertWithdapperSp_Click);
            // 
            // btnSelectWithDapper
            // 
            this.btnSelectWithDapper.Location = new System.Drawing.Point(28, 90);
            this.btnSelectWithDapper.Name = "btnSelectWithDapper";
            this.btnSelectWithDapper.Size = new System.Drawing.Size(162, 23);
            this.btnSelectWithDapper.TabIndex = 2;
            this.btnSelectWithDapper.Text = "Select With Dapper";
            this.btnSelectWithDapper.UseVisualStyleBackColor = true;
            this.btnSelectWithDapper.Click += new System.EventHandler(this.btnSelectWithDapper_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(328, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(460, 426);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSelectWithDapperSP
            // 
            this.btnSelectWithDapperSP.Location = new System.Drawing.Point(28, 132);
            this.btnSelectWithDapperSP.Name = "btnSelectWithDapperSP";
            this.btnSelectWithDapperSP.Size = new System.Drawing.Size(162, 23);
            this.btnSelectWithDapperSP.TabIndex = 4;
            this.btnSelectWithDapperSP.Text = "Select With Dapper -Sp";
            this.btnSelectWithDapperSP.UseVisualStyleBackColor = true;
            this.btnSelectWithDapperSP.Click += new System.EventHandler(this.btnSelectWithDapperSP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSelectWithDapperSP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSelectWithDapper);
            this.Controls.Add(this.btnIsertWithdapperSp);
            this.Controls.Add(this.btnInsertWithDapper);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertWithDapper;
        private System.Windows.Forms.Button btnIsertWithdapperSp;
        private System.Windows.Forms.Button btnSelectWithDapper;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelectWithDapperSP;
    }
}

