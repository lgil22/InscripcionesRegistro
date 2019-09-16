using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InscripcionesEstudiantes.BLL;
using InscripcionesEstudiantes.Entidades;

namespace InscripcionesEstudiantes.UI
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            MatriculamaskedTextBox1.Text = string.Empty;
            NombretextBox1.Text = string.Empty;
            ApellidostextBox2.Text = string.Empty;
            TelefonomaskedTextBox3.Text = string.Empty;
            CedulamaskedTextBox4.Text = "";
            dateTimePicker.Value = DateTime.Now;
            DirecciontextBox3.Text = string.Empty;
            EmailtextBox4.Text = string.Empty;
            SexocomboBox.SelectedIndex = 0;
            BalancetextBox5.Text = BalancetextBox5.Text;
            errorProvider.Clear();
        }
        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = Convert.ToInt32(IDnumericUpDown.Value);
            estudiante.Matricula = MatriculamaskedTextBox1.Text;
            estudiante.Nombre = NombretextBox1.Text;
            estudiante.Apellidos = ApellidostextBox2.Text;
            estudiante.Telefono = TelefonomaskedTextBox3.Text;
            estudiante.Cedula = CedulamaskedTextBox4.Text;
            estudiante.FechaNacimiento = dateTimePicker.Value;
            estudiante.Direccion = DirecciontextBox3.Text;
            estudiante.Email = EmailtextBox4.Text;
            estudiante.Sexo = SexocomboBox.Text;
            estudiante.Balance = ToDecimal(BalancetextBox5.Text);

            return estudiante;
        }
        public static decimal ToDecimal(string valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor, out retorno);

            return retorno;
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            IDnumericUpDown.Value = estudiante.EstudianteId;
            MatriculamaskedTextBox1.Text = estudiante.Matricula;
            NombretextBox1.Text = estudiante.Nombre;
            ApellidostextBox2.Text = estudiante.Apellidos;
            TelefonomaskedTextBox3.Text = estudiante.Telefono;
            CedulamaskedTextBox4.Text = estudiante.Cedula;
            dateTimePicker.Value = estudiante.FechaNacimiento;
            DirecciontextBox3.Text = estudiante.Direccion;
            EmailtextBox4.Text = estudiante.Email;
            SexocomboBox.Text = estudiante.Sexo;
            BalancetextBox5.Text = estudiante.Balance.ToString();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rEstudiantes));
            this.Idlabel1 = new System.Windows.Forms.Label();
            this.Matriculalabel2 = new System.Windows.Forms.Label();
            this.Nombrelabel3 = new System.Windows.Forms.Label();
            this.Apellidoslabel4 = new System.Windows.Forms.Label();
            this.Telefonolabel5 = new System.Windows.Forms.Label();
            this.Cedulalabel6 = new System.Windows.Forms.Label();
            this.FechaNaclabel7 = new System.Windows.Forms.Label();
            this.Direccionlabel8 = new System.Windows.Forms.Label();
            this.Emaillbel9 = new System.Windows.Forms.Label();
            this.Sexolabel10 = new System.Windows.Forms.Label();
            this.Balancelabel11 = new System.Windows.Forms.Label();
            this.IDnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MatriculamaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.ApellidostextBox2 = new System.Windows.Forms.TextBox();
            this.TelefonomaskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.CedulamaskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DirecciontextBox3 = new System.Windows.Forms.TextBox();
            this.EmailtextBox4 = new System.Windows.Forms.TextBox();
            this.SexocomboBox = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BalancetextBox5 = new System.Windows.Forms.TextBox();
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.Nuevobutton2 = new System.Windows.Forms.Button();
            this.Guardarbutton3 = new System.Windows.Forms.Button();
            this.Elimiarbutton4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Idlabel1
            // 
            this.Idlabel1.AutoSize = true;
            this.Idlabel1.Location = new System.Drawing.Point(31, 32);
            this.Idlabel1.Name = "Idlabel1";
            this.Idlabel1.Size = new System.Drawing.Size(18, 13);
            this.Idlabel1.TabIndex = 0;
            this.Idlabel1.Text = "ID";
            // 
            // Matriculalabel2
            // 
            this.Matriculalabel2.AutoSize = true;
            this.Matriculalabel2.Location = new System.Drawing.Point(31, 68);
            this.Matriculalabel2.Name = "Matriculalabel2";
            this.Matriculalabel2.Size = new System.Drawing.Size(50, 13);
            this.Matriculalabel2.TabIndex = 1;
            this.Matriculalabel2.Text = "Matricula";
            // 
            // Nombrelabel3
            // 
            this.Nombrelabel3.AutoSize = true;
            this.Nombrelabel3.Location = new System.Drawing.Point(31, 101);
            this.Nombrelabel3.Name = "Nombrelabel3";
            this.Nombrelabel3.Size = new System.Drawing.Size(44, 13);
            this.Nombrelabel3.TabIndex = 2;
            this.Nombrelabel3.Text = "Nombre";
            // 
            // Apellidoslabel4
            // 
            this.Apellidoslabel4.AutoSize = true;
            this.Apellidoslabel4.Location = new System.Drawing.Point(31, 135);
            this.Apellidoslabel4.Name = "Apellidoslabel4";
            this.Apellidoslabel4.Size = new System.Drawing.Size(49, 13);
            this.Apellidoslabel4.TabIndex = 3;
            this.Apellidoslabel4.Text = "Apellidos";
            // 
            // Telefonolabel5
            // 
            this.Telefonolabel5.AutoSize = true;
            this.Telefonolabel5.Location = new System.Drawing.Point(31, 168);
            this.Telefonolabel5.Name = "Telefonolabel5";
            this.Telefonolabel5.Size = new System.Drawing.Size(49, 13);
            this.Telefonolabel5.TabIndex = 4;
            this.Telefonolabel5.Text = "Telefono";
            // 
            // Cedulalabel6
            // 
            this.Cedulalabel6.AutoSize = true;
            this.Cedulalabel6.Location = new System.Drawing.Point(31, 200);
            this.Cedulalabel6.Name = "Cedulalabel6";
            this.Cedulalabel6.Size = new System.Drawing.Size(40, 13);
            this.Cedulalabel6.TabIndex = 5;
            this.Cedulalabel6.Text = "Cedula";
            // 
            // FechaNaclabel7
            // 
            this.FechaNaclabel7.AutoSize = true;
            this.FechaNaclabel7.Location = new System.Drawing.Point(31, 238);
            this.FechaNaclabel7.Name = "FechaNaclabel7";
            this.FechaNaclabel7.Size = new System.Drawing.Size(93, 13);
            this.FechaNaclabel7.TabIndex = 6;
            this.FechaNaclabel7.Text = "Fecha Nacimiento";
            // 
            // Direccionlabel8
            // 
            this.Direccionlabel8.AutoSize = true;
            this.Direccionlabel8.Location = new System.Drawing.Point(31, 271);
            this.Direccionlabel8.Name = "Direccionlabel8";
            this.Direccionlabel8.Size = new System.Drawing.Size(52, 13);
            this.Direccionlabel8.TabIndex = 7;
            this.Direccionlabel8.Text = "Direccion";
            this.Direccionlabel8.Click += new System.EventHandler(this.Direccionlabel8_Click);
            // 
            // Emaillbel9
            // 
            this.Emaillbel9.AutoSize = true;
            this.Emaillbel9.Location = new System.Drawing.Point(31, 306);
            this.Emaillbel9.Name = "Emaillbel9";
            this.Emaillbel9.Size = new System.Drawing.Size(32, 13);
            this.Emaillbel9.TabIndex = 8;
            this.Emaillbel9.Text = "Email";
            // 
            // Sexolabel10
            // 
            this.Sexolabel10.AutoSize = true;
            this.Sexolabel10.Location = new System.Drawing.Point(31, 339);
            this.Sexolabel10.Name = "Sexolabel10";
            this.Sexolabel10.Size = new System.Drawing.Size(31, 13);
            this.Sexolabel10.TabIndex = 9;
            this.Sexolabel10.Text = "Sexo";
            // 
            // Balancelabel11
            // 
            this.Balancelabel11.AutoSize = true;
            this.Balancelabel11.Location = new System.Drawing.Point(31, 375);
            this.Balancelabel11.Name = "Balancelabel11";
            this.Balancelabel11.Size = new System.Drawing.Size(46, 13);
            this.Balancelabel11.TabIndex = 10;
            this.Balancelabel11.Text = "Balance";
            // 
            // IDnumericUpDown
            // 
            this.IDnumericUpDown.Location = new System.Drawing.Point(139, 30);
            this.IDnumericUpDown.Name = "IDnumericUpDown";
            this.IDnumericUpDown.Size = new System.Drawing.Size(129, 20);
            this.IDnumericUpDown.TabIndex = 11;
            // 
            // MatriculamaskedTextBox1
            // 
            this.MatriculamaskedTextBox1.Location = new System.Drawing.Point(139, 68);
            this.MatriculamaskedTextBox1.Mask = "0000-0000";
            this.MatriculamaskedTextBox1.Name = "MatriculamaskedTextBox1";
            this.MatriculamaskedTextBox1.Size = new System.Drawing.Size(129, 20);
            this.MatriculamaskedTextBox1.TabIndex = 12;
            this.MatriculamaskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.MatriculamaskedTextBox1_MaskInputRejected);
            // 
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(139, 98);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.Size = new System.Drawing.Size(129, 20);
            this.NombretextBox1.TabIndex = 13;
            // 
            // ApellidostextBox2
            // 
            this.ApellidostextBox2.Location = new System.Drawing.Point(139, 132);
            this.ApellidostextBox2.Name = "ApellidostextBox2";
            this.ApellidostextBox2.Size = new System.Drawing.Size(129, 20);
            this.ApellidostextBox2.TabIndex = 14;
            this.ApellidostextBox2.TextChanged += new System.EventHandler(this.ApellidostextBox2_TextChanged);
            // 
            // TelefonomaskedTextBox3
            // 
            this.TelefonomaskedTextBox3.Location = new System.Drawing.Point(139, 165);
            this.TelefonomaskedTextBox3.Mask = "000-000-0000";
            this.TelefonomaskedTextBox3.Name = "TelefonomaskedTextBox3";
            this.TelefonomaskedTextBox3.Size = new System.Drawing.Size(129, 20);
            this.TelefonomaskedTextBox3.TabIndex = 17;
            // 
            // CedulamaskedTextBox4
            // 
            this.CedulamaskedTextBox4.Location = new System.Drawing.Point(139, 200);
            this.CedulamaskedTextBox4.Mask = "000-0000000-0";
            this.CedulamaskedTextBox4.Name = "CedulamaskedTextBox4";
            this.CedulamaskedTextBox4.Size = new System.Drawing.Size(129, 20);
            this.CedulamaskedTextBox4.TabIndex = 18;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(139, 232);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(129, 20);
            this.dateTimePicker.TabIndex = 19;
            // 
            // DirecciontextBox3
            // 
            this.DirecciontextBox3.Location = new System.Drawing.Point(139, 268);
            this.DirecciontextBox3.Name = "DirecciontextBox3";
            this.DirecciontextBox3.Size = new System.Drawing.Size(129, 20);
            this.DirecciontextBox3.TabIndex = 20;
            // 
            // EmailtextBox4
            // 
            this.EmailtextBox4.Location = new System.Drawing.Point(139, 303);
            this.EmailtextBox4.Name = "EmailtextBox4";
            this.EmailtextBox4.Size = new System.Drawing.Size(129, 20);
            this.EmailtextBox4.TabIndex = 21;
            // 
            // SexocomboBox
            // 
            this.SexocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexocomboBox.FormattingEnabled = true;
            this.SexocomboBox.Items.AddRange(new object[] {
            "Seleccione",
            "Femenino",
            "Masculino"});
            this.SexocomboBox.Location = new System.Drawing.Point(138, 336);
            this.SexocomboBox.Name = "SexocomboBox";
            this.SexocomboBox.Size = new System.Drawing.Size(130, 21);
            this.SexocomboBox.TabIndex = 22;
            this.SexocomboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BalancetextBox5
            // 
            this.BalancetextBox5.Location = new System.Drawing.Point(138, 372);
            this.BalancetextBox5.Name = "BalancetextBox5";
            this.BalancetextBox5.ReadOnly = true;
            this.BalancetextBox5.Size = new System.Drawing.Size(130, 20);
            this.BalancetextBox5.TabIndex = 23;
            this.BalancetextBox5.TextChanged += new System.EventHandler(this.BalancetextBox5_TextChanged);
            this.BalancetextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BalancetextBox5_KeyPress);
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton1.Image")));
            this.Buscarbutton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton1.Location = new System.Drawing.Point(274, 12);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(84, 38);
            this.Buscarbutton1.TabIndex = 24;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click);
            // 
            // Nuevobutton2
            // 
            this.Nuevobutton2.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton2.Image")));
            this.Nuevobutton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton2.Location = new System.Drawing.Point(74, 431);
            this.Nuevobutton2.Name = "Nuevobutton2";
            this.Nuevobutton2.Size = new System.Drawing.Size(84, 41);
            this.Nuevobutton2.TabIndex = 25;
            this.Nuevobutton2.Text = "Nuevo";
            this.Nuevobutton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Nuevobutton2.UseVisualStyleBackColor = true;
            this.Nuevobutton2.Click += new System.EventHandler(this.Nuevobutton2_Click);
            // 
            // Guardarbutton3
            // 
            this.Guardarbutton3.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton3.Image")));
            this.Guardarbutton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton3.Location = new System.Drawing.Point(175, 431);
            this.Guardarbutton3.Name = "Guardarbutton3";
            this.Guardarbutton3.Size = new System.Drawing.Size(84, 41);
            this.Guardarbutton3.TabIndex = 26;
            this.Guardarbutton3.Text = "Guardar";
            this.Guardarbutton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Guardarbutton3.UseVisualStyleBackColor = true;
            this.Guardarbutton3.Click += new System.EventHandler(this.Guardarbutton3_Click);
            // 
            // Elimiarbutton4
            // 
            this.Elimiarbutton4.Image = ((System.Drawing.Image)(resources.GetObject("Elimiarbutton4.Image")));
            this.Elimiarbutton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Elimiarbutton4.Location = new System.Drawing.Point(274, 432);
            this.Elimiarbutton4.Name = "Elimiarbutton4";
            this.Elimiarbutton4.Size = new System.Drawing.Size(84, 41);
            this.Elimiarbutton4.TabIndex = 27;
            this.Elimiarbutton4.Text = "Eliminar";
            this.Elimiarbutton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Elimiarbutton4.UseVisualStyleBackColor = true;
            this.Elimiarbutton4.Click += new System.EventHandler(this.Elimiarbutton4_Click);
            // 
            // rEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 482);
            this.Controls.Add(this.Elimiarbutton4);
            this.Controls.Add(this.Guardarbutton3);
            this.Controls.Add(this.Nuevobutton2);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.BalancetextBox5);
            this.Controls.Add(this.SexocomboBox);
            this.Controls.Add(this.EmailtextBox4);
            this.Controls.Add(this.DirecciontextBox3);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.CedulamaskedTextBox4);
            this.Controls.Add(this.TelefonomaskedTextBox3);
            this.Controls.Add(this.ApellidostextBox2);
            this.Controls.Add(this.NombretextBox1);
            this.Controls.Add(this.MatriculamaskedTextBox1);
            this.Controls.Add(this.IDnumericUpDown);
            this.Controls.Add(this.Balancelabel11);
            this.Controls.Add(this.Sexolabel10);
            this.Controls.Add(this.Emaillbel9);
            this.Controls.Add(this.Direccionlabel8);
            this.Controls.Add(this.FechaNaclabel7);
            this.Controls.Add(this.Cedulalabel6);
            this.Controls.Add(this.Telefonolabel5);
            this.Controls.Add(this.Apellidoslabel4);
            this.Controls.Add(this.Nombrelabel3);
            this.Controls.Add(this.Matriculalabel2);
            this.Controls.Add(this.Idlabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rEstudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Estudiantes";
            this.Load += new System.EventHandler(this.REstudiantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void REstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void ApellidostextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Direccionlabel8_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MatriculamaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BalancetextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BalancetextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            int id;
            Estudiantes estudiante = new Estudiantes();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            estudiante = EstudiantesBLL.Buscar(id);

            if (estudiante != null)
            {
                MessageBox.Show("Estudiante Encontrado");
                LlenaCampo(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante no Encontado");
            }
        }

        private void Guardarbutton3_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante;
            bool paso = false;

            if (!Validate())
                return;

            estudiante = LlenaClase();


            //Determinar si es guardar o modificar
            if (IDnumericUpDown.Value == 0)
                paso = EstudiantesBLL.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una persona que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = EstudiantesBLL.Modificar(estudiante);
            }

            //Informar el resultado
            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Limpiar();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Estudiantes estudiante = EstudiantesBLL.Buscar((int)IDnumericUpDown.Value);

            return (estudiante != null);
        }

        private void Elimiarbutton4_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = EstudiantesBLL.Buscar(Convert.ToInt32(IDnumericUpDown.Value));

            if (estudiantes != null)
            {
                EstudiantesBLL.Eliminar(estudiantes.EstudianteId);
                MessageBox.Show("Eliminado");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No Eliminado, Id No Existe");
                errorProvider.SetError(IDnumericUpDown, "No se puede eliminar una persona que no existe");
                errorProvider.Clear();
                Limpiar();
            }


           int id;
           int.TryParse(IDnumericUpDown.Text, out id);


            if (IDnumericUpDown.Value == 0)
            {
               MessageBox.Show("Esta Vacio");

            }
            else if (EstudiantesBLL.Eliminar(id))
             {
              MessageBox.Show("Eliminado");
               Limpiar();
            }
            else
            {
             errorProvider.SetError(IDnumericUpDown, "No se puede eliminar una persona que no existe");
             errorProvider.Clear();
               Limpiar();
            }
        }

        private void Nuevobutton2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}

