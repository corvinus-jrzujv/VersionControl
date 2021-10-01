
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 251);
            this.listBox1.TabIndex = 0;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(247, 41);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(35, 13);
            this.label_LastName.TabIndex = 1;
            this.label_LastName.Text = "label1";
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(247, 70);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(35, 13);
            this.label_FirstName.TabIndex = 2;
            this.label_FirstName.Text = "label2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(306, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(306, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 20);
            this.textBox2.TabIndex = 4;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(250, 96);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(213, 23);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "button1";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 301);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_Add;
    }
}

