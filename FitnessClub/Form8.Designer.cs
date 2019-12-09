namespace FitnessClub
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDUslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameUslugiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uslugiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessClubDataSet6 = new FitnessClub.FitnessClubDataSet6();
            this.uslugiTableAdapter = new FitnessClub.FitnessClubDataSet6TableAdapters.UslugiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUslugiDataGridViewTextBoxColumn,
            this.nameUslugiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uslugiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(308, 230);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDUslugiDataGridViewTextBoxColumn
            // 
            this.iDUslugiDataGridViewTextBoxColumn.DataPropertyName = "ID_Uslugi";
            this.iDUslugiDataGridViewTextBoxColumn.HeaderText = "ID_Uslugi";
            this.iDUslugiDataGridViewTextBoxColumn.Name = "iDUslugiDataGridViewTextBoxColumn";
            this.iDUslugiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameUslugiDataGridViewTextBoxColumn
            // 
            this.nameUslugiDataGridViewTextBoxColumn.DataPropertyName = "Name_Uslugi";
            this.nameUslugiDataGridViewTextBoxColumn.HeaderText = "Name_Uslugi";
            this.nameUslugiDataGridViewTextBoxColumn.Name = "nameUslugiDataGridViewTextBoxColumn";
            // 
            // uslugiBindingSource
            // 
            this.uslugiBindingSource.DataMember = "Uslugi";
            this.uslugiBindingSource.DataSource = this.fitnessClubDataSet6;
            // 
            // fitnessClubDataSet6
            // 
            this.fitnessClubDataSet6.DataSetName = "FitnessClubDataSet6";
            this.fitnessClubDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uslugiTableAdapter
            // 
            this.uslugiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить услугу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(169, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить услугу";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Info;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(12, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(308, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Выбрать услугу";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 343);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form8";
            this.Text = "Услуги";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uslugiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FitnessClubDataSet6 fitnessClubDataSet6;
        private System.Windows.Forms.BindingSource uslugiBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUslugiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameUslugiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private FitnessClubDataSet6TableAdapters.UslugiTableAdapter uslugiTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}