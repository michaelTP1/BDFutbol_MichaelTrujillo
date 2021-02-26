using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDFutbol_MichaelTrujillo
{
    /*
 * Michael Jonay Trujillo Padilla
 * */
    public partial class Form3 : Form
    {

        SqlConnection con;

        DataSet ds;

        SqlDataAdapter da;

        DataTable dataTable;

        public Form3()
        {
            InitializeComponent();
        }
        public Form3(SqlConnection con)
        {
            InitializeComponent();

            this.con = con;
        }
        /* Utilizamos distintos databindings para rellenar la tabla automáticamente*/
        private void Form3_Load(object sender, EventArgs e)
        {
            using(bdFutbolEntities db=new bdFutbolEntities())
            {
                contratosBindingSource.DataSource = db.contratos.ToList();
                equiposBindingSource.DataSource = db.equipos.ToList();
                futbolistasBindingSource.DataSource = db.futbolistas.ToList();
               
            }

           
        }

      
    }
}
