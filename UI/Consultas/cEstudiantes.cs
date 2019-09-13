using InscripcionesEstudiantes.BLL;
using InscripcionesEstudiantes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InscripcionesEstudiantes.UI
{
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            {
                var listado = new List<Estudiantes>();

                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.SelectedIndex)
                    {
                        case 0://Todo
                            listado = EstudiantesBLL.GetList(est => true);
                            break;

                        case 1://ID
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = EstudiantesBLL.GetList(est => est.EstudianteId == id);
                            break;

                        case 2://Matricula
                            listado = EstudiantesBLL.GetList(est => est.Matricula.Contains(CriteriotextBox.Text));
                            break;

                        case 3://Nombre
                            listado = EstudiantesBLL.GetList(est => est.Nombre.Contains(CriteriotextBox.Text));
                            break;

                        case 4://Cedula
                            listado = EstudiantesBLL.GetList(est => est.Cedula.Contains(CriteriotextBox.Text));
                            break;

                        case 5://Direccion
                            listado = EstudiantesBLL.GetList(est => est.Direccion.Contains(CriteriotextBox.Text));
                            break;
                    }

                    listado = listado.Where(c => c.FechaNacimiento.Date >= DesdedateTime.Value.Date && c.FechaNacimiento.Date <= HastadateTime.Value.Date).ToList();
                }
                else
                {
                    listado = EstudiantesBLL.GetList(est => true);
                }

                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = listado;
            }

        }
    
    }
}
