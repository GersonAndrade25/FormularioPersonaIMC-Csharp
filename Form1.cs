using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERSONA__Problema_4._4_
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMasculino.Checked)
                chkFemenino.Checked = false;

        }
        private void chkFemenino_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemenino.Checked)
                chkMasculino.Checked = false;

        }

        private void VistaPersona_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //crear la persona
            Persona P = new Persona();

            P.Nombre = txtNombre.Text;
            P.Edad = int.Parse(txtEdad.Text);
            P.Peso = double.Parse(txtPeso.Text);
            P.Altura = double.Parse(txtPeso.Text);

            if (chkMasculino.Checked)
            {
                P.Sexo = "Masculino";
            }
            else if (chkFemenino.Checked)
            {
                P.Sexo = "Femenino";
            }
            else
            {
                P.Sexo = "No especificado";
            }


            //VISTA EN TREEVIEWS DE LOS DATOS DE LA PERSONA//

            VistaPersona.Nodes.Clear();

            TreeNode nodoRaiz = new TreeNode("Datos de la persona: ");
            nodoRaiz.Nodes.Add($"Nombre: {P.Nombre}");
            nodoRaiz.Nodes.Add($"Edad: {P.Edad} años");
            nodoRaiz.Nodes.Add($"Sexo: {P.Sexo}");
            nodoRaiz.Nodes.Add($"Peso: {P.Peso}Kg");
            nodoRaiz.Nodes.Add($"Altura: {P.Altura}m");
            VistaPersona.Nodes.Add(nodoRaiz);
            nodoRaiz.Expand();


            treeVista2.Nodes.Clear();
            TreeNode nodoRaiz2 = new TreeNode("Datos extra: ");
            nodoRaiz2.Nodes.Add($" {P.EsMayorDeEdad(P.Edad)}");
            nodoRaiz2.Nodes.Add($" {P.CalcularIMC(P.Peso,P.Altura)}");
            treeVista2.Nodes.Add(nodoRaiz2);
            nodoRaiz2.Expand();

        }


    }
}
