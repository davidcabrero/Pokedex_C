﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex_C
{
    public partial class VentanaPrincipal : Form
    {
        Conexion miConexion = new Conexion();
        DataTable misPokemons = new DataTable();
        int idActual = 1; //guarda el id del pokemos que se está mostrando
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void Izquierda_Click(object sender, EventArgs e)
        {
            idActual--;
            misPokemons = miConexion.getPoquemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString();
            imagen.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]);
            masinfo.ResetText(); //Elimina el texto de la pantalla más info al cambiar

        }

        private Image convierteBlobAImagen(byte[] img)
        {
            MemoryStream ms = new System.IO.MemoryStream(img);
            return (Image.FromStream(ms));
        }

        private void Derecha_Click(object sender, EventArgs e)
        {
            idActual++;
            misPokemons = miConexion.getPoquemonPorId(idActual);
            nombrePokemon.Text = misPokemons.Rows[0]["nombre"].ToString(); //Texto en la pantalla: Nombre (en string)
            imagen.Image = convierteBlobAImagen((byte[])misPokemons.Rows[0]["imagen"]); //Convierte la imagen
            masinfo.ResetText();
        }
        private void clear_Click(object sender, EventArgs e)
        { 
            //Vacia la pantalla masinfo y la del nombre
            masinfo.ResetText();
            nombrePokemon.ResetText();
        }
        private void especie_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["especie"].ToString();
            //Si no hay datos, se le notifica al usuario
            if (misPokemons.Rows[0]["especie"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }
        }

        private void habitat_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["habitat"].ToString();
            if (misPokemons.Rows[0]["habitat"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }

        }

        private void tipos_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["tipo1"].ToString();
            if (misPokemons.Rows[0]["tipo1"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }
        }

        private void habilidad_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["habilidad"].ToString();
            if (misPokemons.Rows[0]["habilidad"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }
        }

        private void movimientos_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["movimiento1"].ToString();
            if (misPokemons.Rows[0]["movimiento1"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }

        }

        private void preEvolucion_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["preEvolucion"].ToString();
            if (misPokemons.Rows[0]["preEvolucion"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }
        }

        private void posEvolucion_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["posEvolucion"].ToString();
            if (misPokemons.Rows[0]["posEvolucion"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }
        }

        private void descripcion_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["descripcion"].ToString();
            if (misPokemons.Rows[0]["descripcion"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }
        }

        private void peso_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["peso"].ToString();
            if (misPokemons.Rows[0]["peso"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }
        }

        private void altura_Click(object sender, EventArgs e)
        {
            misPokemons = miConexion.getPoquemonPorId(idActual);
            masinfo.Text = misPokemons.Rows[0]["altura"].ToString();
            if (misPokemons.Rows[0]["altura"].ToString() == "")
            {
                masinfo.Text = "No hay datos";
            }
        }

    }
}
