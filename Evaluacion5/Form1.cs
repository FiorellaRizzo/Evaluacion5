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
        
        public Form1()
        {
            InitializeComponent();
        }

        public void btnTomarDecision_Click(object sender, EventArgs e)
        {
            Recomendacion recomendacion = new Recomendacion();

            // Obtén la selección del usuario
            string areaInteres = cmbAreaInteres.SelectedItem as string;
            string nivelDificultad = cmbNivelDificultad.SelectedItem as string;


            recomendacion.areaInteres = Convert.ToString(lblMateria);
            recomendacion.nivelDificultad = Convert.ToString (lblNivelDificultad);

            lblRecomendacion.Text = recomendacion.ObtenerRecomendacion();

                
        }
    }
}
