using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belife.Negocios
{
    class Contrato
    {

        public string Numero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string RutCliente { get; set; }
        public string CodigoPlan { get; set; }
        public DateTime FechaInicioVigencia { get; set; }
        public DateTime FechaFinVigencia { get; set; }
        public bool Vigente { get; set; }
        public bool DeclaracionSalud { get; set; }
        public double PrimaAnual { get; set; }
        public double PrimaMensual { get; set; }
        public string Observaciones { get; set; }


        public bool Create()
        {
            return true;
        }

        public bool Read()
        {
            return true;
        }

        public bool Update()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }

        public bool ReadAll()
        {
            return true;
        }

        public bool ReadAllByNumeroContrato()
        {
            return true;
        }

        public bool ReadAllByRut()
        {
            return true;
        }
        public bool ReadAllByPoliza()
        {
            return true;
        }
    }
}
