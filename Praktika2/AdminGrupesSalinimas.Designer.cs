
namespace Praktika2
{
    partial class AdminGrupesSalinimas
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
            this.comboBoxGrupesSalinimas = new System.Windows.Forms.ComboBox();
            this.praktikaDataSet2 = new Praktika2.praktikaDataSet2();
            this.groupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupsTableAdapter = new Praktika2.praktikaDataSet2TableAdapters.groupsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 36;
            this.button1.Text = "Trinti vartotoją";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Pasirinkite trinamą grupę\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "Darbuotojų/studentų grupių šalinimas iš sistemos";
            // 
            // comboBoxGrupesSalinimas
            // 
            this.comboBoxGrupesSalinimas.DataSource = this.groupsBindingSource;
            this.comboBoxGrupesSalinimas.DisplayMember = "groupname";
            this.comboBoxGrupesSalinimas.FormattingEnabled = true;
            this.comboBoxGrupesSalinimas.Location = new System.Drawing.Point(228, 61);
            this.comboBoxGrupesSalinimas.Name = "comboBoxGrupesSalinimas";
            this.comboBoxGrupesSalinimas.Size = new System.Drawing.Size(269, 21);
            this.comboBoxGrupesSalinimas.TabIndex = 38;
            this.comboBoxGrupesSalinimas.ValueMember = "groupname";
            // 
            // praktikaDataSet2
            // 
            this.praktikaDataSet2.DataSetName = "praktikaDataSet2";
            this.praktikaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupsBindingSource
            // 
            this.groupsBindingSource.DataMember = "groups";
            this.groupsBindingSource.DataSource = this.praktikaDataSet2;
            // 
            // groupsTableAdapter
            // 
            this.groupsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminGrupesSalinimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 179);
            this.Controls.Add(this.comboBoxGrupesSalinimas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminGrupesSalinimas";
            this.Text = "AdminGrupesSalinimas";
            this.Load += new System.EventHandler(this.AdminGrupesSalinimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGrupesSalinimas;
        private praktikaDataSet2 praktikaDataSet2;
        private System.Windows.Forms.BindingSource groupsBindingSource;
        private praktikaDataSet2TableAdapters.groupsTableAdapter groupsTableAdapter;
    }
}