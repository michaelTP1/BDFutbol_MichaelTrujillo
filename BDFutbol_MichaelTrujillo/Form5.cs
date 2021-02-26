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

    public partial class Form5 : Form
    {
        SqlConnection con;

        int table;

        DataSet ds;

        SqlDataAdapter da;


        public Form5()
        {
            InitializeComponent();
        }
        public Form5(SqlConnection con)
        {
            InitializeComponent();

            this.con = con;
        }
        /*Rellenar combobox al cargar el formulario*/

        private void Form5_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from equipos", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from ligas", con);
            DataTable dt2 = new DataTable();
  

            da.Fill(dt);
            da2.Fill(dt2);
          

            proc1LigaCombo.ValueMember = "codLiga";
            proc1LigaCombo.DisplayMember = "nomLiga";
            proc1LigaCombo.DataSource = dt2;

            proc2EquipoCombo.ValueMember = "codEquipo";
            proc2EquipoCombo.DisplayMember = "nomEquipo";
            proc2EquipoCombo.DataSource = dt;

           




            con.Close();

        }

        private void proc1Button_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            con.Open();
            try{

            
                SqlCommand command = new SqlCommand("insertar_equipo ", con);
                command.CommandType = CommandType.StoredProcedure;

                
                SqlParameter param = new SqlParameter
                ("@nomEquipo", SqlDbType.Char);
                param.Direction = ParameterDirection.Input;
                param.Value =p1NombreText.Text;
                SqlParameter param1 = new SqlParameter
                ("@codLiga", SqlDbType.Char);
                param1.Direction = ParameterDirection.Input;
                param1.Value = proc1LigaCombo.SelectedValue;
                SqlParameter param2 = new SqlParameter
                ("@localidad", SqlDbType.Char);
                param2.Direction = ParameterDirection.Input;
                param2.Value = p1LocalidadText.Text;
                SqlParameter param3 = new SqlParameter
                ("@internacional", SqlDbType.Bit);
                param3.Direction = ParameterDirection.Input;
                param3.Value = p1Check.Checked;
                SqlParameter param4= new SqlParameter
                ("@liga_existe", SqlDbType.Int);
                param4.Direction = ParameterDirection.Output;
                
                SqlParameter param5 = new SqlParameter
                ("@error_insercion", SqlDbType.Int);
                param5.Direction = ParameterDirection.Output;


                SqlParameter[] parameters = { param, param1, param2, param3, param4, param5 };


                command.Parameters.AddRange(parameters);

                command.ExecuteNonQuery();

                procedure1ErrorLabel.Text = command.Parameters[5].Value.ToString();

            }
            catch (Exception){
                errorLabel.Text = "Compruebe los datos e inténtelo de nuevo";
            }



            con.Close();
        }

        private void proc2Button_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            con.Open();
            try
            {


                SqlCommand command = new SqlCommand("consulta_contratos ", con);
                command.CommandType = CommandType.StoredProcedure;


                SqlParameter param = new SqlParameter
                ("@nomEquipo", SqlDbType.Char);
                param.Direction = ParameterDirection.Input;
                param.Value = proc2EquipoCombo.SelectedValue;
                SqlParameter param1 = new SqlParameter
                ("@precio_anual", SqlDbType.Int);
                param1.Direction = ParameterDirection.Input;
                param1.Value = p2PrecioAnualText.Text;
                SqlParameter param2 = new SqlParameter
                ("@precio_recision", SqlDbType.Int);
                param2.Direction = ParameterDirection.Input;
                param2.Value = p2PrecioRecisionText.Text;
                SqlParameter param3 = new SqlParameter
                ("@numero_activos", SqlDbType.Int);
                param3.Direction = ParameterDirection.Output;
                SqlParameter param4 = new SqlParameter
                ("@numero_consultado", SqlDbType.Int);
                param4.Direction = ParameterDirection.Output;

               

                SqlParameter[] parameters = { param, param1, param2, param3, param4 };


                command.Parameters.AddRange(parameters);

                command.ExecuteNonQuery();

                p2ActivosLabel.Text = command.Parameters[3].Value.ToString();
                p2ConsultadosLabel.Text = command.Parameters[4].Value.ToString();

            }
            catch (Exception)
            {
                errorLabel.Text = "Compruebe los datos e inténtelo de nuevo";
            }



            con.Close();
        }

        private void proc3Button_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            con.Open();
            try {

                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand("contratos_futbolista ", con);
                command.CommandType = CommandType.StoredProcedure;


                SqlParameter param = new SqlParameter
                ("@documento", SqlDbType.Char);
                param.Direction = ParameterDirection.Input;
                param.Value = p3IDText.Text;

            command.Parameters.Add(param);

                SqlDataReader reader = command.ExecuteReader();
                dt.Load(reader);

                dataGridView1.DataSource = dt;


            }
            catch (Exception)
            {
                errorLabel.Text = "Compruebe los datos e inténtelo de nuevo";
            }

            

            con.Close();


        }

        private void funcButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

           
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("Select dbo.meses_activo(@documento); ", con);

                command.Parameters.AddWithValue("@documento", f1IDText.Text);

                functionOutLabel.Text = command.ExecuteScalar().ToString();
                }
               catch (Exception)
                {
                    errorLabel.Text = "Compruebe los datos e inténtelo de nuevo";
                }
            con.Close();

        }
    }
}
