using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDFutbol_MichaelTrujillo
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        public Form7(DataGridView view)
        {
            
            InitializeComponent();
            dataGridView1.DataSource = view.DataSource;

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
