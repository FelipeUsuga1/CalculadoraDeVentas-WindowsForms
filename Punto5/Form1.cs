using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libTienda;

namespace Punto5
{
    public partial class Form1 : Form
    {
        float fltValTotalVentas = 0;
        float fltTotalDesc = 0;
        int cont = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //this.txtNventas.Text = String.Empty;
            this.txtValProd.Text = String.Empty;
            this.txtCantProd.Text = String.Empty;
            this.lbSubtotal.Text = String.Empty;
            this.lbValDesc.Text = String.Empty;
            this.lbTotalAPagar.Text = String.Empty;
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            int intCantProd;
            int intNVentas;
            float fltValProd;

            try
            {

                intCantProd = Convert.ToInt32(this.txtCantProd.Text);
                intNVentas = Convert.ToInt32(this.txtNventas.Text);
                fltValProd = Convert.ToSingle(this.txtValProd.Text);

                //Instanciamos el objeto
                clsTienda cT = new clsTienda();

                //Envio de la info de la Clase

                cT.cantProd = intCantProd;
                cT.NVentas = intNVentas;
                cT.valorProd = fltValProd;

                //invocamos el metodo y tratamiento del error
                if (!cT.Facturar())
                {
                    MessageBox.Show(cT.Error);
                    cT = null; // opcional
                    return;
                }

                //Mostramos la informacion
                this.lbSubtotal.Text = cT.ValCompra.ToString();
                this.lbValDesc.Text = cT.valDesc.ToString();
                this.lbTotalAPagar.Text = cT.totalAPag.ToString();
                this.txtNventas.Enabled = false;

                cont++;

                fltValTotalVentas = (float)(fltValTotalVentas + cT.totalAPag);
                fltTotalDesc = (float)(fltTotalDesc + cT.valDesc);

                //Mostramos acumuladores
                this.lbvalTotVent.Text = fltValTotalVentas.ToString();
                this.lbTotalDesc.Text = fltTotalDesc.ToString();

                if (cont == intNVentas) {
                    this.grbTotalVent.Visible = true;
                    this.txtNventas.Enabled = true;
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
