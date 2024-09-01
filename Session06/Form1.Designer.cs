namespace Session06
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
            this.SuspendLayout();
            // 
            // btnInsertWithDapper
            // 
            this.btnInsertWithDapper.Location = new System.Drawing.Point(12, 34);
            this.btnInsertWithDapper.Name = "btnInsertWithDapper";
            this.btnInsertWithDapper.Size = new System.Drawing.Size(176, 23);
            this.btnInsertWithDapper.TabIndex = 0;
            this.btnInsertWithDapper.Text = "Insert With Dapper";
            this.btnInsertWithDapper.UseVisualStyleBackColor = true;
            this.btnInsertWithDapper.Click += new System.EventHandler(this.btnInsertWithDapper_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInsertWithDapper);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertWithDapper;
    }
}

