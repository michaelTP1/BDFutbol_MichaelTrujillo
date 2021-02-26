using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * Michael Jonay Trujillo Padilla
 * */

namespace BDFutbol_MichaelTrujillo
{
    public partial class Form2 : Form


    {

        SqlConnection con;

        int table;

        DataSet ds;

        SqlDataAdapter da;


        public Form2()
        {
            InitializeComponent();
        }
        public Form2(SqlConnection con)
        {
            InitializeComponent();

            this.con = con;
        }

        /*Cada botón rellena el datagridview con los datos de la tabla correspondiente*/

        private void button1_Click(object sender, EventArgs e)
        {

            con.Open();
                    SqlCommand cmd = new SqlCommand("select * from equipos", con);
                    ds = new DataSet();

                    da = new SqlDataAdapter(cmd);

                    da.Fill(ds, "Equipos");

                  

                    dataGridView1.DataSource = ds.Tables["Equipos"]; //Cargamos los datos en la tabla
            string getRowCount = (dataGridView1.Rows.Count - 1).ToString();
            filasLabel.Text = getRowCount;

                 dataGridView1.Columns[0].HeaderText = "Código equipo";
                    dataGridView1.Columns[1].HeaderText = "nombre equipo";
                    dataGridView1.Columns[2].HeaderText = "cod liga";
                    dataGridView1.Columns[3].HeaderText = "localidad";
                    dataGridView1.Columns[4].HeaderText = "internacional";

                    table = 0;


            con.Close();
        }

    

        private void showFutbolistasButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from futbolistas", con);
            ds = new DataSet();

            da = new SqlDataAdapter(cmd);

            da.Fill(ds, "Futbolistas");


            dataGridView1.DataSource = ds.Tables["Futbolistas"];
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Nacionalidad";

            string getRowCount = (dataGridView1.Rows.Count-1).ToString();
            filasLabel.Text = getRowCount;
            table = 2;
            con.Close();
        }

        private void showLigasButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from ligas", con);
            ds = new DataSet();

            da = new SqlDataAdapter(cmd);

            da.Fill(ds, "Ligas");


            dataGridView1.DataSource = ds.Tables["Ligas"];
            dataGridView1.Columns[0].HeaderText = "Código liga";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            string getRowCount = (dataGridView1.Rows.Count - 1).ToString();
            filasLabel.Text = getRowCount;

            table = 3;
            con.Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from contratos", con);
            ds = new DataSet();

            da = new SqlDataAdapter(cmd);

            da.Fill(ds, "Contratos");


            dataGridView1.DataSource = ds.Tables["Contratos"];
            dataGridView1.Columns[0].HeaderText = "Código contrato";
            dataGridView1.Columns[1].HeaderText = "Identificación";
            dataGridView1.Columns[2].HeaderText = "Código equipo";
            dataGridView1.Columns[3].HeaderText = "Fecha de inicio";
            dataGridView1.Columns[4].HeaderText = "Fecha finalización";
            dataGridView1.Columns[5].HeaderText = "Precio anual";
            dataGridView1.Columns[6].HeaderText = "Precio recisión";
  

            string getRowCount = (dataGridView1.Rows.Count - 1).ToString();
            filasLabel.Text = getRowCount;

            table = 1;

            con.Close();



        }
        /*dependiendo de la tabla en la que estemos actualizamos la base de datos con los cambios pertinentes*/
        private void Actualizar_Click(object sender, EventArgs e)
        {
            con.Open();
            
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(da); 
            da.SelectCommand.Connection = con;


            if (table == 0)
            {
                da.Update(ds.Tables["Equipos"]); 
            }
            else if (table == 1)
            {
                da.Update(ds.Tables["Contratos"]);
            }
            else if (table == 2)
            {
                da.Update(ds.Tables["Futbolistas"]);
            }
            else
            {
                da.Update(ds.Tables["Ligas"]);
            }
            string getRowCount = (dataGridView1.Rows.Count - 1).ToString();
            filasLabel.Text = getRowCount;
            con.Close();

        }

      
    }
}
