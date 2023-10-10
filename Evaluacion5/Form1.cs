using Evaluacion5;
using Evaluacion5.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Evaluacion5
{
    public partial class Form1 : Form
    {
        public bool isGreen = true; // Variable para alternar el color

        Recomendacion Lista { get; set; } = new Recomendacion();
        public Form1()
        {
            InitializeComponent();
            btnInscribirse.Hide();

          
            dg.DataSource = Lista.ListaRecomendacion;
            

        }

       
            public void btnTomarDecision_Click(object sender, EventArgs e)
        {
            Recomendacion recomendacion = new Recomendacion();

            // Obtén la selección del usuario
            string areaInteres = cmbAreaInteres.SelectedItem as string;
            string nivelDificultad = cmbNivelDificultad.SelectedItem as string;


            recomendacion.areaInteres = areaInteres;
            recomendacion.nivelDificultad = nivelDificultad;
            

            lblRecomendacion.Text = recomendacion.ObtenerRecomendacion();

            Recomendacion rec = new Recomendacion();
            

            

            while (isGreen)
            {
                if (lblRecomendacion.Text.Contains( "Lo siento, no podemos encontrar una recomendación en este momento."))
                {
                    panel1.BackColor = Color.Red;
                    lblVacante.Text = "";
                    btnInscribirse.Hide();
                }
                else if (lblRecomendacion.Text != "")
                {
                    panel1.BackColor = Color.Green;
                    lblVacante.Text = "¡Hay vacantes!";
                    btnInscribirse.Show();
                }
                else
                {
                    panel1.BackColor = Color.Red;
                    btnInscribirse.Hide();
                }
                break;
            }
        }

     

        private void btnInscribirse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inscripción realizada con éxito");
            Recomendacion rec = new Recomendacion();
            rec.Agregar(cmbAreaInteres.Text,
                        cmbNivelDificultad.Text,
                        lblVacante.Text);
            Lista.InsertRecomendacion(rec);
        }

        
    }
}
