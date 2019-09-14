namespace InscripcionesEstudiantes.UI
{
    partial class cEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cEstudiantes));
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.Desdelabel1 = new System.Windows.Forms.Label();
            this.Hastalabel2 = new System.Windows.Forms.Label();
            this.Filtrolabel3 = new System.Windows.Forms.Label();
            this.Criteriolabel4 = new System.Windows.Forms.Label();
            this.DesdedateTime = new System.Windows.Forms.DateTimePicker();
            this.HastadateTime = new System.Windows.Forms.DateTimePicker();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.Consultarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 53);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.Size = new System.Drawing.Size(782, 340);
            this.ConsultadataGridView.TabIndex = 1;
            // 
            // Desdelabel1
            // 
            this.Desdelabel1.AutoSize = true;
            this.Desdelabel1.Location = new System.Drawing.Point(9, 9);
            this.Desdelabel1.Name = "Desdelabel1";
            this.Desdelabel1.Size = new System.Drawing.Size(38, 13);
            this.Desdelabel1.TabIndex = 2;
            this.Desdelabel1.Text = "Desde";
            // 
            // Hastalabel2
            // 
            this.Hastalabel2.AutoSize = true;
            this.Hastalabel2.Location = new System.Drawing.Point(119, 9);
            this.Hastalabel2.Name = "Hastalabel2";
            this.Hastalabel2.Size = new System.Drawing.Size(35, 13);
            this.Hastalabel2.TabIndex = 3;
            this.Hastalabel2.Text = "Hasta";
            // 
            // Filtrolabel3
            // 
            this.Filtrolabel3.AutoSize = true;
            this.Filtrolabel3.Location = new System.Drawing.Point(224, 9);
            this.Filtrolabel3.Name = "Filtrolabel3";
            this.Filtrolabel3.Size = new System.Drawing.Size(29, 13);
            this.Filtrolabel3.TabIndex = 4;
            this.Filtrolabel3.Text = "Filtro";
            // 
            // Criteriolabel4
            // 
            this.Criteriolabel4.AutoSize = true;
            this.Criteriolabel4.Location = new System.Drawing.Point(351, 9);
            this.Criteriolabel4.Name = "Criteriolabel4";
            this.Criteriolabel4.Size = new System.Drawing.Size(39, 13);
            this.Criteriolabel4.TabIndex = 5;
            this.Criteriolabel4.Text = "Criterio";
            // 
            // DesdedateTime
            // 
            this.DesdedateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdedateTime.Location = new System.Drawing.Point(12, 25);
            this.DesdedateTime.Name = "DesdedateTime";
            this.DesdedateTime.Size = new System.Drawing.Size(104, 20);
            this.DesdedateTime.TabIndex = 6;
            // 
            // HastadateTime
            // 
            this.HastadateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastadateTime.Location = new System.Drawing.Point(122, 25);
            this.HastadateTime.Name = "HastadateTime";
            this.HastadateTime.Size = new System.Drawing.Size(99, 20);
            this.HastadateTime.TabIndex = 7;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todo",
            "id"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(227, 24);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.FiltrocomboBox.TabIndex = 8;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(354, 25);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(338, 20);
            this.CriteriotextBox.TabIndex = 9;
            // 
            // Consultarbutton
            // 
            this.Consultarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Consultarbutton.Image")));
            this.Consultarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultarbutton.Location = new System.Drawing.Point(698, 12);
            this.Consultarbutton.Name = "Consultarbutton";
            this.Consultarbutton.Size = new System.Drawing.Size(96, 33);
            this.Consultarbutton.TabIndex = 10;
            this.Consultarbutton.Text = "Consultar";
            this.Consultarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultarbutton.UseVisualStyleBackColor = true;
            this.Consultarbutton.Click += new System.EventHandler(this.Consultarbutton_Click);
            // 
            // cEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 406);
            this.Controls.Add(this.Consultarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.HastadateTime);
            this.Controls.Add(this.DesdedateTime);
            this.Controls.Add(this.Criteriolabel4);
            this.Controls.Add(this.Filtrolabel3);
            this.Controls.Add(this.Hastalabel2);
            this.Controls.Add(this.Desdelabel1);
            this.Controls.Add(this.ConsultadataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Estudiantes";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Label Desdelabel1;
        private System.Windows.Forms.Label Hastalabel2;
        private System.Windows.Forms.Label Filtrolabel3;
        private System.Windows.Forms.Label Criteriolabel4;
        private System.Windows.Forms.DateTimePicker DesdedateTime;
        private System.Windows.Forms.DateTimePicker HastadateTime;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Button Consultarbutton;
    }
}