namespace ExcelToDatabase
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
            this.btn_select = new System.Windows.Forms.Button();
            this.btn_import = new System.Windows.Forms.Button();
            this.tb_conStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fd_openExcel = new System.Windows.Forms.OpenFileDialog();
            this.tb_tableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(18, 105);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(115, 79);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "Excel Seç";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // btn_import
            // 
            this.btn_import.Location = new System.Drawing.Point(176, 106);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(103, 78);
            this.btn_import.TabIndex = 1;
            this.btn_import.Text = "Aktar";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // tb_conStr
            // 
            this.tb_conStr.Location = new System.Drawing.Point(103, 4);
            this.tb_conStr.Name = "tb_conStr";
            this.tb_conStr.Size = new System.Drawing.Size(540, 22);
            this.tb_conStr.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Con str :";
            // 
            // fd_openExcel
            // 
            this.fd_openExcel.FileName = "openFileDialog1";
            // 
            // tb_tableName
            // 
            this.tb_tableName.Location = new System.Drawing.Point(103, 50);
            this.tb_tableName.Name = "tb_tableName";
            this.tb_tableName.Size = new System.Drawing.Size(540, 22);
            this.tb_tableName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Table Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 403);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_tableName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_conStr);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.btn_select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.TextBox tb_conStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog fd_openExcel;
        private System.Windows.Forms.TextBox tb_tableName;
        private System.Windows.Forms.Label label2;
    }
}

