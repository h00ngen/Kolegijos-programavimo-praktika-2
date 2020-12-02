
namespace Praktika2
{
    partial class NaudotojuSarasas
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vartotojų sąrašas";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Laurynas Gudavičius 2000-04-20 h00ngen",
            "DJ Benjamin 1999-01-01 Bloons"});
            this.checkedListBox1.Location = new System.Drawing.Point(69, 81);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(657, 244);
            this.checkedListBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ištrinti vartotoją";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NaudotojuSarasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Name = "NaudotojuSarasas";
            this.Text = "NaudotojuSarasas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button button1;
    }
}