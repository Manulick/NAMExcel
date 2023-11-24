using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlToExcel
{
    public partial class MainForm : Form
    {
        private readonly DatabaseHandler dbHandler;

        private DataTable dt;

        public MainForm()
        {
            InitializeComponent();
            dt = new DataTable();

            // Crea la instancia de DatabaseHandler con credenciales genéricas
            dbHandler = new DatabaseHandler("localhost", "AdventureWorks", "", "");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            string query = txtQuery.Text;

            // Ejecuta el query y carga los resultados en el DataGridView
            dt = dbHandler.ExecuteQuery(query);
            dataGridView1.DataSource = dt;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            dbHandler.ExportarDataTableAExcel(dt);
        }
    }
}
