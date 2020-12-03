
namespace Praktika2
{
    partial class AdminVartotojoSalinimas
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxVartotojoSalinimas = new System.Windows.Forms.ComboBox();
            this.praktikaDataSetVartotojoSalinimas = new Praktika2.praktikaDataSetVartotojoSalinimas();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Praktika2.praktikaDataSetVartotojoSalinimasTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetVartotojoSalinimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 138);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 29;
            this.button1.Text = "Trinti vartotoją";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pasirinkite vartotojo vardą ar pavardę";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Vartotojo šalinimas iš sistemos";
            // 
            // comboBoxVartotojoSalinimas
            // 
            this.comboBoxVartotojoSalinimas.DataSource = this.usersBindingSource;
            this.comboBoxVartotojoSalinimas.DisplayMember = "name";
            this.comboBoxVartotojoSalinimas.FormattingEnabled = true;
            this.comboBoxVartotojoSalinimas.Location = new System.Drawing.Point(249, 67);
            this.comboBoxVartotojoSalinimas.Name = "comboBoxVartotojoSalinimas";
            this.comboBoxVartotojoSalinimas.Size = new System.Drawing.Size(269, 21);
            this.comboBoxVartotojoSalinimas.TabIndex = 34;
            this.comboBoxVartotojoSalinimas.ValueMember = "name";
            // 
            // praktikaDataSetVartotojoSalinimas
            // 
            this.praktikaDataSetVartotojoSalinimas.DataSetName = "praktikaDataSetVartotojoSalinimas";
            this.praktikaDataSetVartotojoSalinimas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.praktikaDataSetVartotojoSalinimas;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // AdminVartotojoSalinimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 203);
            this.Controls.Add(this.comboBoxVartotojoSalinimas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminVartotojoSalinimas";
            this.Text = "AdminVartotojoŠalinimas";
            this.Load += new System.EventHandler(this.AdminVartotojoSalinimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetVartotojoSalinimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxVartotojoSalinimas;
        private praktikaDataSetVartotojoSalinimas praktikaDataSetVartotojoSalinimas;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private praktikaDataSetVartotojoSalinimasTableAdapters.usersTableAdapter usersTableAdapter;
    }
}