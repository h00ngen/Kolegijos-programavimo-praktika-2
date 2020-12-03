
namespace Praktika2
{
    partial class AdminDestytojoPriskyrimas
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxDestytojoPasirinkimas = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet = new Praktika2.praktikaDataSet();
            this.comboBoxPaskaitosPasirinkimas = new System.Windows.Forms.ComboBox();
            this.lecturesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praktikaDataSet1 = new Praktika2.praktikaDataSet1();
            this.usersTableAdapter = new Praktika2.praktikaDataSetTableAdapters.usersTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lecturesTableAdapter = new Praktika2.praktikaDataSet1TableAdapters.lecturesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 36);
            this.button1.TabIndex = 23;
            this.button1.Text = "Priskirti dėstytoją prie paskaitos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Pasirinkite dėstytoją";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Dėstytojo priskyrimas prie paskaitos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pasirinkite paskaitą";
            // 
            // comboBoxDestytojoPasirinkimas
            // 
            this.comboBoxDestytojoPasirinkimas.DataSource = this.usersBindingSource;
            this.comboBoxDestytojoPasirinkimas.DisplayMember = "username";
            this.comboBoxDestytojoPasirinkimas.FormattingEnabled = true;
            this.comboBoxDestytojoPasirinkimas.Location = new System.Drawing.Point(230, 94);
            this.comboBoxDestytojoPasirinkimas.Name = "comboBoxDestytojoPasirinkimas";
            this.comboBoxDestytojoPasirinkimas.Size = new System.Drawing.Size(240, 21);
            this.comboBoxDestytojoPasirinkimas.TabIndex = 25;
            this.comboBoxDestytojoPasirinkimas.ValueMember = "username";
            this.comboBoxDestytojoPasirinkimas.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestytojoPasirinkimas_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.praktikaDataSet;
            // 
            // praktikaDataSet
            // 
            this.praktikaDataSet.DataSetName = "praktikaDataSet";
            this.praktikaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxPaskaitosPasirinkimas
            // 
            this.comboBoxPaskaitosPasirinkimas.DataSource = this.lecturesBindingSource;
            this.comboBoxPaskaitosPasirinkimas.DisplayMember = "name";
            this.comboBoxPaskaitosPasirinkimas.FormattingEnabled = true;
            this.comboBoxPaskaitosPasirinkimas.Location = new System.Drawing.Point(230, 121);
            this.comboBoxPaskaitosPasirinkimas.Name = "comboBoxPaskaitosPasirinkimas";
            this.comboBoxPaskaitosPasirinkimas.Size = new System.Drawing.Size(240, 21);
            this.comboBoxPaskaitosPasirinkimas.TabIndex = 26;
            this.comboBoxPaskaitosPasirinkimas.ValueMember = "name";
            // 
            // lecturesBindingSource
            // 
            this.lecturesBindingSource.DataMember = "lectures";
            this.lecturesBindingSource.DataSource = this.praktikaDataSet1;
            // 
            // praktikaDataSet1
            // 
            this.praktikaDataSet1.DataSetName = "praktikaDataSet1";
            this.praktikaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(594, 25);
            this.fillByToolStrip.TabIndex = 27;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // lecturesTableAdapter
            // 
            this.lecturesTableAdapter.ClearBeforeFill = true;
            // 
            // AdminDestytojoPriskyrimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 227);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.comboBoxPaskaitosPasirinkimas);
            this.Controls.Add(this.comboBoxDestytojoPasirinkimas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AdminDestytojoPriskyrimas";
            this.Text = "AdminDestytojoPriskyrimas";
            this.Load += new System.EventHandler(this.AdminDestytojoPriskyrimas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praktikaDataSet1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxDestytojoPasirinkimas;
        private System.Windows.Forms.ComboBox comboBoxPaskaitosPasirinkimas;
        private praktikaDataSet praktikaDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private praktikaDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private praktikaDataSet1 praktikaDataSet1;
        private System.Windows.Forms.BindingSource lecturesBindingSource;
        private praktikaDataSet1TableAdapters.lecturesTableAdapter lecturesTableAdapter;
    }
}