
namespace UserMaintenance
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
            this.listUsers = new System.Windows.Forms.ListBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.text_LastName = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_File = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listUsers
            // 
            this.listUsers.FormattingEnabled = true;
            this.listUsers.Location = new System.Drawing.Point(40, 27);
            this.listUsers.Name = "listUsers";
            this.listUsers.Size = new System.Drawing.Size(191, 251);
            this.listUsers.TabIndex = 0;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(247, 41);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(54, 13);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "Full Name";
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(306, 41);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(157, 20);
            this.text_LastName.TabIndex = 3;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(250, 67);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(213, 23);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "Hozzáadás";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_File
            // 
            this.button_File.Location = new System.Drawing.Point(250, 96);
            this.button_File.Name = "button_File";
            this.button_File.Size = new System.Drawing.Size(213, 23);
            this.button_File.TabIndex = 6;
            this.button_File.Text = "Fájlba írás";
            this.button_File.UseVisualStyleBackColor = true;
            this.button_File.Click += new System.EventHandler(this.button_File_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 301);
            this.Controls.Add(this.button_File);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.listUsers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUsers;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.TextBox text_LastName;
        private System.Windows.Forms.Button button_Add;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_File;
    }
}

