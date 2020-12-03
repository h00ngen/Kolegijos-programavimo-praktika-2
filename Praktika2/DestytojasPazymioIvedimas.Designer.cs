
namespace Praktika2
{
    partial class DestytojasPazymioIvedimas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPazymioPasirinkimas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxStudentoPasirinkimas = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSetIvestiStudentuiPazymi = new Praktika2.praktikaDataSetIvestiStudentuiPazymi();
            this.usersTableAdapter = new Praktika2.praktikaDataSetIvestiStudentuiPazymiTableAdapters.usersTableAdapter();
            this.rodytiTikStudentusToolStrip = new System.Windows.Forms.ToolStrip();
            this.rodytiTikStudentusToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.comboBoxDestytojasPaskaitosIvedimas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.praktikaDataSetPasirinkitePaskaita = new Praktika2.praktikaDataSetPasirinkitePaskaita();
            this.lecturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturesTableAdapter = new Praktika2.praktikaDataSetPasirinkitePaskaitaTableAdapters.lecturesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetIvestiStudentuiPazymi)).BeginInit();
            this.rodytiTikStudentusToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetPasirinkitePaskaita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 37);
            this.label1.TabIndex = 21;
            this.label1.Text = "Pažymio/įvertinimo įvedimas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pasirinkite studentą:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pasirinkite pažymį:";
            // 
            // comboBoxPazymioPasirinkimas
            // 
            this.comboBoxPazymioPasirinkimas.FormattingEnabled = true;
            this.comboBoxPazymioPasirinkimas.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxPazymioPasirinkimas.Location = new System.Drawing.Point(200, 121);
            this.comboBoxPazymioPasirinkimas.Name = "comboBoxPazymioPasirinkimas";
            this.comboBoxPazymioPasirinkimas.Size = new System.Drawing.Size(277, 21);
            this.comboBoxPazymioPasirinkimas.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Įvesti pažymį";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxStudentoPasirinkimas
            // 
            this.comboBoxStudentoPasirinkimas.DataSource = this.usersBindingSource;
            this.comboBoxStudentoPasirinkimas.DisplayMember = "name";
            this.comboBoxStudentoPasirinkimas.FormattingEnabled = true;
            this.comboBoxStudentoPasirinkimas.Location = new System.Drawing.Point(200, 80);
            this.comboBoxStudentoPasirinkimas.Name = "comboBoxStudentoPasirinkimas";
            this.comboBoxStudentoPasirinkimas.Size = new System.Drawing.Size(276, 21);
            this.comboBoxStudentoPasirinkimas.TabIndex = 28;
            this.comboBoxStudentoPasirinkimas.ValueMember = "name";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.praktikaDataSetIvestiStudentuiPazymi;
            // 
            // praktikaDataSetIvestiStudentuiPazymi
            // 
            this.praktikaDataSetIvestiStudentuiPazymi.DataSetName = "praktikaDataSetIvestiStudentuiPazymi";
            this.praktikaDataSetIvestiStudentuiPazymi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // rodytiTikStudentusToolStrip
            // 
            this.rodytiTikStudentusToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.rodytiTikStudentusToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rodytiTikStudentusToolStripButton});
            this.rodytiTikStudentusToolStrip.Location = new System.Drawing.Point(0, 0);
            this.rodytiTikStudentusToolStrip.Name = "rodytiTikStudentusToolStrip";
            this.rodytiTikStudentusToolStrip.Size = new System.Drawing.Size(583, 25);
            this.rodytiTikStudentusToolStrip.TabIndex = 29;
            this.rodytiTikStudentusToolStrip.Text = "rodytiTikStudentusToolStrip";
            // 
            // rodytiTikStudentusToolStripButton
            // 
            this.rodytiTikStudentusToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rodytiTikStudentusToolStripButton.Name = "rodytiTikStudentusToolStripButton";
            this.rodytiTikStudentusToolStripButton.Size = new System.Drawing.Size(113, 22);
            this.rodytiTikStudentusToolStripButton.Text = "RodytiTikStudentus";
            this.rodytiTikStudentusToolStripButton.Click += new System.EventHandler(this.rodytiTikStudentusToolStripButton_Click);
            // 
            // comboBoxDestytojasPaskaitosIvedimas
            // 
            this.comboBoxDestytojasPaskaitosIvedimas.DataSource = this.lecturesBindingSource;
            this.comboBoxDestytojasPaskaitosIvedimas.DisplayMember = "name";
            this.comboBoxDestytojasPaskaitosIvedimas.FormattingEnabled = true;
            this.comboBoxDestytojasPaskaitosIvedimas.Location = new System.Drawing.Point(200, 161);
            this.comboBoxDestytojasPaskaitosIvedimas.Name = "comboBoxDestytojasPaskaitosIvedimas";
            this.comboBoxDestytojasPaskaitosIvedimas.Size = new System.Drawing.Size(277, 21);
            this.comboBoxDestytojasPaskaitosIvedimas.TabIndex = 30;
            this.comboBoxDestytojasPaskaitosIvedimas.ValueMember = "lectureID";
            this.comboBoxDestytojasPaskaitosIvedimas.SelectedIndexChanged += new System.EventHandler(this.DestytojasPaskaitosIvedimas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Pasirinkite paskaitą:";
            // 
            // praktikaDataSetPasirinkitePaskaita
            // 
            this.praktikaDataSetPasirinkitePaskaita.DataSetName = "praktikaDataSetPasirinkitePaskaita";
            this.praktikaDataSetPasirinkitePaskaita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturesBindingSource
            // 
            this.lecturesBindingSource.DataMember = "lectures";
            this.lecturesBindingSource.DataSource = this.praktikaDataSetPasirinkitePaskaita;
            // 
            // lecturesTableAdapter
            // 
            this.lecturesTableAdapter.ClearBeforeFill = true;
            // 
            // DestytojasPazymioIvedimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 266);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxDestytojasPaskaitosIvedimas);
            this.Controls.Add(this.rodytiTikStudentusToolStrip);
            this.Controls.Add(this.comboBoxStudentoPasirinkimas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxPazymioPasirinkimas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DestytojasPazymioIvedimas";
            this.Text = "DestytojasPazymioIvedimas";
            this.Load += new System.EventHandler(this.DestytojasPazymioIvedimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetIvestiStudentuiPazymi)).EndInit();
            this.rodytiTikStudentusToolStrip.ResumeLayout(false);
            this.rodytiTikStudentusToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSetPasirinkitePaskaita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPazymioPasirinkimas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxStudentoPasirinkimas;
        private praktikaDataSetIvestiStudentuiPazymi praktikaDataSetIvestiStudentuiPazymi;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private praktikaDataSetIvestiStudentuiPazymiTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ToolStrip rodytiTikStudentusToolStrip;
        private System.Windows.Forms.ToolStripButton rodytiTikStudentusToolStripButton;
        private System.Windows.Forms.ComboBox comboBoxDestytojasPaskaitosIvedimas;
        private System.Windows.Forms.Label label4;
        private praktikaDataSetPasirinkitePaskaita praktikaDataSetPasirinkitePaskaita;
        private System.Windows.Forms.BindingSource lecturesBindingSource;
        private praktikaDataSetPasirinkitePaskaitaTableAdapters.lecturesTableAdapter lecturesTableAdapter;
    }
}