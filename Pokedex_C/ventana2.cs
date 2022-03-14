using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_C
{
    public partial class ventana2 : Form
    {
        public void cambiaDescripcionPokemon(String descripcion)
        {
            cajaDescripcion.Text = descripcion;
        }

        public ventana2()
        {
            InitializeComponent();
            
        }
    }
}
