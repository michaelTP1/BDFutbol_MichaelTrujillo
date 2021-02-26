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
    public partial class Form4 : Form
    {


        SqlConnection con;

        DataSet ds=new DataSet();

        DataView ligaDataView = new DataView();

        DataTable dataTable;


        public Form4()
        {
            InitializeComponent();
        }
        public Form4(SqlConnection con)
        {
            InitializeComponent();

            this.con = con;
         
        }

        /* Al cargar el formulario establecemos una relación entre la tabla ligas y la tabla equipos*/

        private void Form4_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlDataAdapter daLigas = new SqlDataAdapter("select * from ligas", con);
            daLigas.Fill(ds, "Ligas");

            SqlDataAdapter daEquipos = new SqlDataAdapter("select * from equipos", con);
            daEquipos.Fill(ds, "Equipos");
           
            DataRowView currentRowView;

            ligaDataView = new DataView(ds.Tables["Ligas"]);
            dataGridView1.DataSource = ligaDataView;
           
            DataColumn parentColumn = ds.Tables["Ligas"].Columns["codLiga"];
            DataColumn childColumn = ds.Tables["Equipos"].Columns["codLiga"];

            DataRelation ligaEquiposRelation = new DataRelation("LigaEquipos", parentColumn, childColumn);
            ds.Relations.Add(ligaEquiposRelation);
       
            currentRowView = ligaDataView[dataGridView1.CurrentRow.Index];
            con.Close();
        }

        /*Al hacer click en una celda en la tabla ligas cargamos los datos correspondientes en la tabla equipos*/
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            con.Open();
            try
            {

                DataRowView currentRowView;
                currentRowView = ligaDataView[e.RowIndex];
                dataGridView2.DataSource = currentRowView.CreateChildView(ds.Relations["LigaEquipos"]);
            } catch(Exception)
            {

            }
            con.Close();
        }
    }
}
