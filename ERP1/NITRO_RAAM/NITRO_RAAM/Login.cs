using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using System.Collections;

namespace NITRO_RAAM
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        public Login()
        {
            InitializeComponent();

            /*
             * Con esta linea aplicamos todos los cambios del estilo de la ventana 
             * (si no ponemos eso no funciona nada)
            */
            //this.StyleManager = metroStyleManager1;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void mbtnEntrar_Click(object sender, EventArgs e)
        {
            // Objeto DataTable para recoger todos los datos de la consulta
            DataTable tabla = new DataTable();
            // Objeto del tipo de la bbdd que contiene la consulta a bbdd
            BBDDDataSetTableAdapters.UsuariosTableAdapter taUser = new BBDDDataSetTableAdapters.UsuariosTableAdapter();
            // Volcamos en tabla todos los datos devueltos por la consulta 
            tabla = taUser.CuentaEmple();


            // Recorremos todos los datos que contiene la tabla de Usuarios
            string data = string.Empty;
            //Guardar todas las filas en un Array
            ArrayList data1 = new ArrayList();

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                DataRow row = tabla.Rows[i];

                for (int j = 0; j < tabla.Columns.Count; j++)
                {
                    //data += tabla.Columns[j].ColumnName + "~" + row[j];
                    data += row[j];
                    if (j != tabla.Columns.Count - 1)
                    {
                        data += "|";
                    }
                }
                // Añadir la fila en el ArrayList
                data1.Add(data);
                data = "";
            }


            // Comprobar si coincide con la bbdd lo puesto por el usuario
            Principal vPrincipal = new Principal();
            Char separador = '|';
            Boolean encontrado = false;

            foreach(String a in data1)
            {
                String[] cuenta = new String[5];
                cuenta = a.Split(separador);
                
                if (cuenta[1].Equals(mtbxUser.Text))
                {
                    if (cuenta[2].Equals(mtbPass.Text))
                    {
                        //Abrir la ventana correspondiente y cerrar la ventana del Login
                        vPrincipal.Show();
                        this.Close();
                        // Comprobar si entra en los if
                        encontrado = true;
                    }
                }
            }

            //Mensaje de error si el usuario introduce la infromación de forma erronea
            if(encontrado == false){
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
