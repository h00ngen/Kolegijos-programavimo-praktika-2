
namespace Praktika2
{
    partial class StudentasPazymiai
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
            this.comboBoxDalykoPasirinkimas = new System.Windows.Forms.ComboBox();
            this.lecturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSetPasirinktiDalykaPazymiams = new Praktika2.praktikaDataSetPasirinktiDalykaPazymiams();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lecturesTableAdapter = new Praktika2.praktikaDataSetPasirinktiDalykaPazymiamsTableAdapters.lecturesTableAdapter();
            this.marksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSetRodytiPazymius = new Praktika2.praktikaDataSetRodytiPazymius();
            this.marksTableAdapter = new Praktika2.praktikaDataSetRodytiPazymiusTableAdapters.marksTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetPasirinktiDalykaPazymiams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetRodytiPazymius)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxDalykoPasirinkimas
            // 
            this.comboBoxDalykoPasirinkimas.DataSource = this.lecturesBindingSource;
            this.comboBoxDalykoPasirinkimas.DisplayMember = "name";
            this.comboBoxDalykoPasirinkimas.FormattingEnabled = true;
            this.comboBoxDalykoPasirinkimas.Location = new System.Drawing.Point(155, 60);
            this.comboBoxDalykoPasirinkimas.Name = "comboBoxDalykoPasirinkimas";
            this.comboBoxDalykoPasirinkimas.Size = new System.Drawing.Size(240, 21);
            this.comboBoxDalykoPasirinkimas.TabIndex = 31;
            this.comboBoxDalykoPasirinkimas.ValueMember = "lectureID";
            this.comboBoxDalykoPasirinkimas.SelectedIndexChanged += new System.EventHandler(this.cboDalykoPasirinkimas_SelectedIndexChanged);
            // 
            // lecturesBindingSource
            // 
            this.lecturesBindingSource.DataMember = "lectures";
            this.lecturesBindingSource.DataSource = this.praktikaDataSetPasirinktiDalykaPazymiams;
            // 
            // praktikaDataSetPasirinktiDalykaPazymiams
            // 
            this.praktikaDataSetPasirinktiDalykaPazymiams.DataSetName = "praktikaDataSetPasirinktiDalykaPazymiams";
            this.praktikaDataSetPasirinktiDalykaPazymiams.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Pasirinkite dalyką";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mano pažymiai ir įvertinimai\r\n";
            // 
            // lecturesTableAdapter
            // 
            this.lecturesTableAdapter.ClearBeforeFill = true;
            // 
            // marksBindingSource
            // 
            this.marksBindingSource.DataMember = "marks";
            this.marksBindingSource.DataSource = this.praktikaDataSetRodytiPazymius;
            // 
            // praktikaDataSetRodytiPazymius
            // 
            this.praktikaDataSetRodytiPazymius.DataSetName = "praktikaDataSetRodytiPazymius";
            this.praktikaDataSetRodytiPazymius.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marksTableAdapter
            // 
            this.marksTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 56);
            this.button1.TabIndex = 32;
            this.button1.Text = "Žiūrėti pažymius";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // StudentasPazymiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxDalykoPasirinkimas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "StudentasPazymiai";
            this.Text = "Pažymiai";
            this.Load += new System.EventHandler(this.StudentasPazymiai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetPasirinktiDalykaPazymiams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetRodytiPazymius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxDalykoPasirinkimas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private praktikaDataSetPasirinktiDalykaPazymiams praktikaDataSetPasirinktiDalykaPazymiams;
        private System.Windows.Forms.BindingSource lecturesBindingSource;
        private praktikaDataSetPasirinktiDalykaPazymiamsTableAdapters.lecturesTableAdapter lecturesTableAdapter;
        private praktikaDataSetRodytiPazymius praktikaDataSetRodytiPazymius;
        private System.Windows.Forms.BindingSource marksBindingSource;
        private praktikaDataSetRodytiPazymiusTableAdapters.marksTableAdapter marksTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}