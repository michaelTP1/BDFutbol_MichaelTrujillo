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
    public partial class Form6 : Form
    {
        SqlConnection con;

        int table;

        DataSet ds;

        SqlDataAdapter da;


        public Form6()
        {
            InitializeComponent();
        }
        public Form6(SqlConnection con)
        {
            InitializeComponent();

            this.con = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "Confirmar inserción";
            string title = "Insertar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                insertar();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

       

        private void Form6_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from equipos", con);
            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from ligas", con);
            DataTable dt2 = new DataTable();


            da.Fill(dt);
            da2.Fill(dt2);


            ligaCombo.ValueMember = "codLiga";
            ligaCombo.DisplayMember = "nomLiga";
            ligaCombo.DataSource = dt2;

            equiposCombo.ValueMember = "codEquipo";
            equiposCombo.DisplayMember = "nomEquipo";
            equiposCombo.DataSource = dt;

            con.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string message = "Confirmar borrado";
            string title = "Borrar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                borrar();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string message = "Confirmar actualización";
            string title = "Actualizar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                actualizar();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
        //insertamos el equipo usando el procedimiento correspondiente
        private void insertar()
        {
            errorLabel.Text = "";
            con.Open();
            try
            {
                SqlCommand command = new SqlCommand("insertar_equipo ", con);
                command.CommandType = CommandType.StoredProcedure;


                SqlParameter param = new SqlParameter
                ("@nomEquipo", SqlDbType.Char);
                param.Direction = ParameterDirection.Input;
                param.Value = nombreText.Text;
                SqlParameter param1 = new SqlParameter
                ("@codLiga", SqlDbType.Char);
                param1.Direction = ParameterDirection.Input;
                param1.Value = ligaCombo.SelectedValue;
                SqlParameter param2 = new SqlParameter
                ("@localidad", SqlDbType.Char);
                param2.Direction = ParameterDirection.Input;
                param2.Value = LocalidadText.Text;
                SqlParameter param3 = new SqlParameter
                ("@internacional", SqlDbType.Bit);
                param3.Direction = ParameterDirection.Input;
                param3.Value = checkBox1.Checked;
                SqlParameter param4 = new SqlParameter
                ("@liga_existe", SqlDbType.Int);
                param4.Direction = ParameterDirection.Output;

                SqlParameter param5 = new SqlParameter
                ("@error_insercion", SqlDbType.Int);
                param5.Direction = ParameterDirection.Output;


                SqlParameter[] parameters = { param, param1, param2, param3, param4, param5 };


                command.Parameters.AddRange(parameters);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                errorLabel.Text = "Compruebe los datos e inténtelo de nuevo";
            }


            con.Close();
        }
        //borramos el equipo seleccionado con delete
        private void borrar()
        {
           

                errorLabel.Text = "";
                con.Open();
                try
                {
                    SqlCommand command = new SqlCommand("delete equipos where codEquipo=@codEquipo", con);



                   
                    SqlParameter param = new SqlParameter
                    ("@codEquipo", SqlDbType.Int);
                    param.Value = equiposCombo.SelectedValue;


                   


                    command.Parameters.Add(param);

                    command.ExecuteNonQuery();

                }
                catch (Exception)
                {
                    errorLabel.Text = "Compruebe los datos e inténtelo de nuevo";
                }


                con.Close();
            }

        //actualizamos los datos del equipo con update
        private void actualizar()
        {
            errorLabel.Text = "";
            con.Open();
            try
            {
                SqlCommand command = new SqlCommand("update equipos set nomEquipo=@nomEquipo, codLiga=@codLiga, localidad=@localidad, internacional=@internacional where codEquipo=@codEquipo", con);
               


                SqlParameter param = new SqlParameter
                ("@nomEquipo", SqlDbType.Char);
                 param.Value = nombreText.Text;

                SqlParameter param1 = new SqlParameter
                ("@codLiga", SqlDbType.Char);
                param1.Value = ligaCombo.SelectedValue;

                SqlParameter param2 = new SqlParameter
                ("@localidad", SqlDbType.Char);
                param2.Value = LocalidadText.Text;

                SqlParameter param3 = new SqlParameter
                ("@internacional", SqlDbType.Bit);
                param3.Value = checkBox1.Checked;

                SqlParameter param4 = new SqlParameter
                ("@codEquipo", SqlDbType.Int);
                param4.Value = equiposCombo.SelectedValue;


                SqlParameter[] parameters = { param, param1, param2, param3};


                command.Parameters.AddRange(parameters);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
                errorLabel.Text = "Compruebe los datos e inténtelo de nuevo";
            }


            con.Close();
        }
    }
}
