using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belife.Negocios
{
    class Plan
    {

        public string IdPlan { get; set; }
        public string Nombre { get; set; }
        public double PrimaBase { get; set; }
        public string PolizaActual { get; set; }
        
        public bool Read()
        {
            return true;
        }

        public bool ReadAll()
        {
            return true;
        }
    }
}
