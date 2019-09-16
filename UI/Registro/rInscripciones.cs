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
    public partial class rInscripciones : Form
    {
        public rInscripciones()
        {
            InitializeComponent();
            LlenarComboBox();
        }
        //Muestra el nombre del estudiante y guardar id estudiante.....
        private void LlenarComboBox()
        {
            EstudianteComboBox.DataSource = EstudiantesBLL.GetList(x => true);
            EstudianteComboBox.ValueMember = "EstudianteId";
            EstudianteComboBox.DisplayMember = "Nombre";

            //TraerBalance();
        }
        // Especifica el formato de moneda y convierte un número en una cadena que representa una cantidad de moneda.....
        private void FormatoMoneda(object sender , ConvertEventArgs e)
        {
            double valor = 0;
            double.TryParse(e.Value.ToString(), out valor);
            e.Value = valor.ToString("#,##.00;(#,##.00);0.00");
        }

        // Metodo para llevar balance a tipo moneda y presentarlo en pantalla.....
        private void CambiarBalance()
        {
            BalanceTextBox.DataBindings.Clear();
            Binding binding = new Binding("Text", EstudianteComboBox.DataSource, "Balance");
            binding.Format += new ConvertEventHandler(FormatoMoneda);
            BalanceTextBox.DataBindings.Add(binding);

        }

        private void LlenarBalance()
        {
            List<Estudiantes> listaEstudiantes = EstudiantesBLL.GetList(x => x.Nombre.Equals(EstudianteComboBox.Text));
            foreach (var item in listaEstudiantes)
            {
                BalanceTextBox.Text = item.Balance.ToString();
            }
        }

        private void Limpiar()
        {
            InscripnumericUpDown1.Value = 0;
            EstudianteComboBox.SelectedIndex = 0;
            ComentariostextBox1.Clear();
            MontotextBox2.Clear();
            DepositotextBox3.Clear();
            BalanceTextBox.Clear();
            CambiarBalance();
        }
 
        private Inscripciones LlenaClase()
        {
            return new Inscripciones()
            {
                InscripcionId = Convert.ToInt32(InscripnumericUpDown1.Value),
                Fecha = FechaDateTimePicker.Value.Date,
                EstudianteId = Convert.ToInt32(EstudianteComboBox.SelectedValue),
                Balance = ToDecimal(BalanceTextBox.Text),
                Deposito = ToDecimal(DepositotextBox3.Text),
                Monto = ToDecimal(MontotextBox2.Text),
                Comentarios = ComentariostextBox1.Text
            };
        }

        public static decimal ToDecimal(string valor)
        {
            decimal retorno = 0;
            decimal.TryParse(valor, out retorno);

            return retorno;
        }

        private void Fechalabel1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            int id_inscripcion = Convert.ToInt32(InscripnumericUpDown1.Value);
            Inscripciones inscripcion = InscripcionesBLL.Buscar(id_inscripcion);


            if (inscripcion == null)
            {
                if (InscripcionesBLL.Guardar(LlenaClase()))
                {
                    MessageBox.Show("Guardado", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }

            }
            else
            {
                inscripcion = LlenaClase();
                if (InscripcionesBLL.Modificar(inscripcion))  /// Metodo para modificar informacion de algun estudiante.....
                {
                    MessageBox.Show("Modificado", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("No Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiar();
                }

            }

        }

        private void ElimiarButton_Click(object sender, EventArgs e)
        {
            int id_inscripcion = Convert.ToInt32(InscripnumericUpDown1.Value);
            Inscripciones inscripcion = InscripcionesBLL.Buscar(id_inscripcion);

            if (inscripcion != null)
            {
                if (InscripcionesBLL.Eliminar(inscripcion.InscripcionId))
                {
                    MessageBox.Show("Eliminado", "Realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NuevoButton.PerformClick();
                }
                else
                {
                    MessageBox.Show("No Eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    NuevoButton.PerformClick();
                }
            }
            else
                MessageBox.Show("No Hay Resultado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(InscripnumericUpDown1.Value);
            Inscripciones inscripcion = InscripcionesBLL.Buscar(id);
            
            if (inscripcion != null)
            {
                //MessageBox.Show("Estudiante Encontrado");
                LlenaCampo(inscripcion);
            }
            else
            {
                MessageBox.Show("Estudiante no Encontado");
                Limpiar();
            }
        }

        private void LlenaCampo(Inscripciones inscripion)
        {
            InscripnumericUpDown1.Value = inscripion.InscripcionId;
            EstudianteComboBox.SelectedValue = inscripion.EstudianteId;
            BalanceTextBox.Text = inscripion.Balance.ToString();
            MontotextBox2.Text = inscripion.Monto.ToString();
            DepositotextBox3.Text = inscripion.Deposito.ToString();
            ComentariostextBox1.Text = inscripion.Comentarios;
            FechaDateTimePicker.Value = inscripion.Fecha;
            CambiarBalance();
        }

        private void EstudianteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LlenarBalance();
            CambiarBalance();
        }
    }

}



