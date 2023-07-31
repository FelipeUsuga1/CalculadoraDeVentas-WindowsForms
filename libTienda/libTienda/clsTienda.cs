using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libTienda
{
    public class clsTienda
    {
        #region "Atributos"
        private int intCantProd;
        private float fltValorProd;
        private int intNVentas;
        private float fltValCompra;
        private float fltValDesc;
        private float fltTotalAPag;
        private float fltTotalVent;
        private float fltTotalDesc;
        private string strError;
        #endregion

        #region "Constructor"

        public clsTienda(){
            intCantProd = 0;
            fltValorProd = 0;
            intNVentas = 0;
            fltValCompra = 0;
            fltValDesc = 0; 
            fltTotalAPag = 0;
            fltTotalVent = 0;
            fltTotalDesc = 0;
            strError = string.Empty;
        }

        #endregion
         
        #region "Propiedades"

        public int cantProd
        {
            set { intCantProd = value; }
        }

        public float valorProd
        {
            set { fltValorProd = value; }
        }

        public int NVentas
        {
            set { intNVentas = value; }
        }


        public float valDesc
        {
            get { return fltValDesc; }
        }
        public float ValCompra
        {
            get { return fltValCompra; }
        }

        public float totalAPag
        {
            get { return fltTotalAPag; }
        }


        public float totalVent
        {
            get { return fltTotalVent; }
        }


        public float totalDesc
        {
            get { return fltTotalDesc; }
        }

        public string Error
        {
            get { return strError; }
        }

        #endregion

        #region "Metodos privados"

        private bool Validar()
        {
            if (intCantProd <= 0)
            {
                strError = "Error, cantidad de productos no valido";
                return false;
            }

            if (intNVentas <= 0)
            {
                strError = "Error, cantidad de ventas no valida";
                return false;
            }

            if (fltValorProd <= 0)
            {
                strError = "Error, valor del producto no valido";
                return false;
            }

            return true;
        }

        #endregion

        #region "Metodos publicos"
        public bool Facturar()
        {

            float fltPdesc;
            try
            {

                fltValCompra = intCantProd*fltValorProd;

                if (fltValCompra < 2400000) {
                    fltPdesc = 7.25f;
                }
                else {
                    fltPdesc = 10.35f;
                }

                fltValDesc = fltValCompra * fltPdesc/100;
                fltTotalAPag = fltValCompra - fltValDesc;

                return true;

            }
            catch (Exception ex) 
            {
                strError = ex.Message;
                return false;
            }      
        
        }



        #endregion
    }
}
