using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Belife.Negocios
{
    public class Cliente
    {
        public string RutCliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public virtual EstadoCivil EstadoCivil { get; set; }
        public virtual Sexo Sexo { get; set; }

        public Cliente()
        {
            Init();
        }

        public void Init()
        {
            RutCliente = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            FechaNacimiento = DateTime.Today;
            Sexo = new Sexo();
            EstadoCivil = new EstadoCivil();
        }

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

        public bool ReadAllBySexo()
        {
            return true;
        }

        public bool ReadAllByEstadoCivil()
        {
            return true;
        }
    }
}
