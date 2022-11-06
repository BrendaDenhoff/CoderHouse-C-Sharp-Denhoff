using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    public class Venta
    {
        public int Id { get; set; }
        public string Comentarios { get; set; }

        public Venta(int id, string comentarios)
        {
            this.Id = id;
            this.Comentarios = comentarios;
        }
    }
}
