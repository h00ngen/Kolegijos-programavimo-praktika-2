
namespace Praktika2
{
    partial class AdminPaskaitosSalinimas
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
            this.comboBoxPaskaitosSalinimas = new System.Windows.Forms.ComboBox();
            this.praktikaDataSetPaskaituTrynimas = new Praktika2.praktikaDataSetPaskaituTrynimas();
            this.lecturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturesTableAdapter = new Praktika2.praktikaDataSetPaskaituTrynimasTableAdapters.lecturesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetPaskaituTrynimas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 117);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 40;
            this.button1.Text = "Trinti paskaitą";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pasirinkite trinamą paskaitą\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Paskaitų šalinimas iš sistemos";
            // 
            // comboBoxPaskaitosSalinimas
            // 
            this.comboBoxPaskaitosSalinimas.DataSource = this.lecturesBindingSource;
            this.comboBoxPaskaitosSalinimas.DisplayMember = "name";
            this.comboBoxPaskaitosSalinimas.FormattingEnabled = true;
            this.comboBoxPaskaitosSalinimas.Location = new System.Drawing.Point(155, 69);
            this.comboBoxPaskaitosSalinimas.Name = "comboBoxPaskaitosSalinimas";
            this.comboBoxPaskaitosSalinimas.Size = new System.Drawing.Size(269, 21);
            this.comboBoxPaskaitosSalinimas.TabIndex = 42;
            this.comboBoxPaskaitosSalinimas.ValueMember = "name";
            // 
            // praktikaDataSetPaskaituTrynimas
            // 
            this.praktikaDataSetPaskaituTrynimas.DataSetName = "praktikaDataSetPaskaituTrynimas";
            this.praktikaDataSetPaskaituTrynimas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturesBindingSource
            // 
            this.lecturesBindingSource.DataMember = "lectures";
            this.lecturesBindingSource.DataSource = this.praktikaDataSetPaskaituTrynimas;
            // 
            // lecturesTableAdapter
            // 
            this.lecturesTableAdapter.ClearBeforeFill = true;
            // 
            // AdminPaskaitosSalinimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 179);
            this.Controls.Add(this.comboBoxPaskaitosSalinimas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminPaskaitosSalinimas";
            this.Text = "AdminPaskaitosSalinimas";
            this.Load += new System.EventHandler(this.AdminPaskaitosSalinimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetPaskaituTrynimas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPaskaitosSalinimas;
        private praktikaDataSetPaskaituTrynimas praktikaDataSetPaskaituTrynimas;
        private System.Windows.Forms.BindingSource lecturesBindingSource;
        private praktikaDataSetPaskaituTrynimasTableAdapters.lecturesTableAdapter lecturesTableAdapter;
    }
}