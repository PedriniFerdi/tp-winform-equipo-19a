using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class MemoriaArticulo
    {
        public Articulo Articulo { get; set; }
        private static MemoriaArticulo instance = null;

        private MemoriaArticulo()
        {
            this.Articulo = new Articulo();
        }

        public static MemoriaArticulo Instance()
        {
            if (instance == null)
            {
                instance = new MemoriaArticulo();
            }
            return instance;
        }

        public void ReinicarMemoria()
        {
            this.Articulo = new Articulo();
        }
    }
}
