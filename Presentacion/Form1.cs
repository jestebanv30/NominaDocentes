using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frRegistro : Form
    {
        ServicioCatedratico servicioCatedratico = new ServicioCatedratico();
        ServicioOcasionales ServicioOcasionales = new ServicioOcasionales();
        public frRegistro()
        {
            
            InitializeComponent();
            cbOcasional.Enabled = false;
            txtHora.Enabled = false;
            txtValor.Enabled = false;
            txtId.MaxLength = 10;
            txtPhone.MaxLength = 10;

            cbPosgrado.Items.Add("Especializacion");
            cbPosgrado.Items.Add("Maestria");
            cbPosgrado.Items.Add("Doctorado");
            cbPosgrado.Items.Add("Postdoctorado");

            cbSemillero.Items.Add("A1");
            cbSemillero.Items.Add("B");
            cbSemillero.Items.Add("C");
            cbSemillero.Items.Add("Reconocidos por Colciencias");
            cbSemillero.Items.Add("Semillero");
        }

        void Guardar()
        {
            if (txtId.Text == "" || txtName.Text == "" || txtLName.Text == "" || txtEmail.Text == "" || txtPhone.Text == ""
                || cbPosgrado.Text == "" || cbSemillero.Text == "" || rdOcasional.Checked == false && rdCatedraticos.Checked == false)
            {
                MessageBox.Show("FALTAN DATOS POR COMPLETAR", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    Profesor profesor = new Profesor();
                    profesor.Identificacion = int.Parse(txtId.Text);
                    profesor.Nombres = txtName.Text;
                    profesor.Apellidos = txtLName.Text;
                    profesor.Correo = txtEmail.Text;
                    profesor.Telefono = int.Parse(txtPhone.Text);
                    profesor.Posgrado = cbPosgrado.SelectedItem.ToString();
                    profesor.Semillero = cbSemillero.SelectedItem.ToString();


                    if (rdOcasional.Checked == true)
                    {
                        Ocasionales ocasionales = new Ocasionales();

                        ocasionales.Identificacion = profesor.Identificacion;
                        ocasionales.Nombres = profesor.Nombres;
                        ocasionales.Apellidos = profesor.Apellidos;
                        ocasionales.Correo = profesor.Correo;
                        ocasionales.Telefono = profesor.Telefono;
                        ocasionales.Posgrado = profesor.Posgrado;
                        ocasionales.Semillero = profesor.Semillero;
                        ocasionales.Time = cbOcasional.SelectedItem.ToString();

                        var mensaje1 = ServicioOcasionales.Save(ocasionales);
                        var mensaje3 = ServicioOcasionales.CalcularSalario(ocasionales);
                        MessageBox.Show(mensaje1.ToUpper(), "Regristro Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(mensaje3.ToString(), "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Catedraticos catedraticos = new Catedraticos();
                        

                        catedraticos.Identificacion = profesor.Identificacion;
                        catedraticos.Nombres = profesor.Nombres;
                        catedraticos.Apellidos = profesor.Apellidos;
                        catedraticos.Correo = profesor.Correo;
                        catedraticos.Telefono = profesor.Telefono;
                        catedraticos.Posgrado = profesor.Posgrado;
                        catedraticos.Semillero = profesor.Semillero;

                        catedraticos.NumHoras = int.Parse(txtHora.Text);
                        catedraticos.ValorHoras = double.Parse(txtValor.Text);

                        var mensaje = servicioCatedratico.Save(catedraticos);
                        var mensaje2 = servicioCatedratico.CalcularSalario(catedraticos);
                        MessageBox.Show(mensaje.ToUpper(), "Regristro Profesor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show(mensaje2.ToString(), "Nomina", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message, "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void rdOcasional_CheckedChanged(object sender, EventArgs e)
        {
            if (rdOcasional.Checked == true)
            {
                cbOcasional.Enabled = true;
                cbOcasional.Items.Add("Auxiliar de tiempo completo");
                cbOcasional.Items.Add("Auxiliar de medio tiempo");
                cbOcasional.Items.Add("Asistente de tiempo completo");
                cbOcasional.Items.Add("Asistente de medio tiempo");
                cbOcasional.Items.Add("Asociacion de tiempo completo");
                cbOcasional.Items.Add("Asociacion de medio tiempo");
                cbOcasional.Items.Add("Titular de tiempo completo");
                cbOcasional.Items.Add("Titular de medio tiempo");
            }
            else
            {
                cbOcasional.Enabled = false;
                cbOcasional.SelectedIndex = -1;
            }
            
        }

        private void rdCatedraticos_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCatedraticos.Checked == true)
            {
                txtHora.Enabled = true; txtValor.Enabled = true;
            }
            else
            {
                txtHora.Enabled = false; txtValor.Enabled = false;
                txtHora.Clear(); txtValor.Clear();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
