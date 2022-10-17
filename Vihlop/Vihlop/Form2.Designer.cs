
namespace Vihlop
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.FullNameBox = new System.Windows.Forms.TextBox();
            this.MarkAutoBox = new System.Windows.Forms.TextBox();
            this.TypeWorkBox = new System.Windows.Forms.TextBox();
            this.NumberAutoBox = new System.Windows.Forms.TextBox();
            this.TypeCorruptBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(551, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FullNameBox
            // 
            this.FullNameBox.Location = new System.Drawing.Point(119, 32);
            this.FullNameBox.Name = "FullNameBox";
            this.FullNameBox.Size = new System.Drawing.Size(100, 20);
            this.FullNameBox.TabIndex = 1;
            // 
            // MarkAutoBox
            // 
            this.MarkAutoBox.Location = new System.Drawing.Point(119, 58);
            this.MarkAutoBox.Name = "MarkAutoBox";
            this.MarkAutoBox.Size = new System.Drawing.Size(100, 20);
            this.MarkAutoBox.TabIndex = 2;
            // 
            // TypeWorkBox
            // 
            this.TypeWorkBox.Location = new System.Drawing.Point(119, 84);
            this.TypeWorkBox.Name = "TypeWorkBox";
            this.TypeWorkBox.Size = new System.Drawing.Size(100, 20);
            this.TypeWorkBox.TabIndex = 3;
            // 
            // NumberAutoBox
            // 
            this.NumberAutoBox.Location = new System.Drawing.Point(119, 110);
            this.NumberAutoBox.Name = "NumberAutoBox";
            this.NumberAutoBox.Size = new System.Drawing.Size(100, 20);
            this.NumberAutoBox.TabIndex = 4;
            // 
            // TypeCorruptBox
            // 
            this.TypeCorruptBox.Location = new System.Drawing.Point(119, 136);
            this.TypeCorruptBox.Name = "TypeCorruptBox";
            this.TypeCorruptBox.Size = new System.Drawing.Size(100, 20);
            this.TypeCorruptBox.TabIndex = 5;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(119, 162);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 6;
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(119, 188);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(100, 20);
            this.DateBox.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.TypeCorruptBox);
            this.Controls.Add(this.NumberAutoBox);
            this.Controls.Add(this.TypeWorkBox);
            this.Controls.Add(this.MarkAutoBox);
            this.Controls.Add(this.FullNameBox);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox FullNameBox;
        private System.Windows.Forms.TextBox MarkAutoBox;
        private System.Windows.Forms.TextBox TypeWorkBox;
        private System.Windows.Forms.TextBox NumberAutoBox;
        private System.Windows.Forms.TextBox TypeCorruptBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox DateBox;
    }
}