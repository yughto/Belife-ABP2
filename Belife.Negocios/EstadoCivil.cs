using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belife.Negocios
{
    public class EstadoCivil
    {

        public int IdEstadoCivil { get; set; }
        public string Descripcion { get; set; }

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
