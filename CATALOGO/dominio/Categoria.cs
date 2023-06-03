using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using dominio;

namespace dominio
{
    public class Categoria
    {

        public int Id { get; set; }
        [DisplayName("Descripción")]
        public string Descripcion { get; set; }

    }
}
