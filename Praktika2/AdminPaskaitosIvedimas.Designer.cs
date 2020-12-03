
namespace Praktika2
{
    partial class AdminPaskaitosIvedimas
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
            this.textBoxPaskaitosIvedimas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Pridėti paskaitą";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPaskaitosIvedimas
            // 
            this.textBoxPaskaitosIvedimas.Location = new System.Drawing.Point(265, 64);
            this.textBoxPaskaitosIvedimas.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPaskaitosIvedimas.Name = "textBoxPaskaitosIvedimas";
            this.textBoxPaskaitosIvedimas.Size = new System.Drawing.Size(212, 20);
            this.textBoxPaskaitosIvedimas.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Įveskite naujos paskaitos pavadinimą";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Naujos paskaitos įvedimas";
            // 
            // AdminPaskaitosIvedimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 208);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPaskaitosIvedimas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminPaskaitosIvedimas";
            this.Text = "AdminPamokosIvedimas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPaskaitosIvedimas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}