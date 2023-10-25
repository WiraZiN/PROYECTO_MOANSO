using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class logMatPrenda
    {
        #region sigleton
        private static readonly logMatPrenda _instancia = new logMatPrenda();

        public static logMatPrenda Instancia
        {
            get
            {
                return logMatPrenda._instancia;
            }
        }
        #endregion singleton
        #region metodos

        public void InsertarMatPrenda(entMatPrenda Pr)
        {
            datMatPrenda.Instancia.InsertarMatPrenda(Pr);
        }

        public void ModificarMatPrenda(entMatPrenda Pr)
        {
            datMatPrenda.Instancia.ModificarMatPrenda(Pr);
        }

        public void DeshabilitarMatPrenda(entMatPrenda Cli)
        {
            datMatPrenda.Instancia.DeshabilitarMatPrenda(Cli);
        }

        #endregion metodos
    }
}
