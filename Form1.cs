using Microsoft.Office.Interop.Excel;
using objExcel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DataGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrilla2_Click(object sender, EventArgs e)
        {
            Grilla.Negocio ng = new Grilla.Negocio();
            System.Data.DataTable dt = (System.Data.DataTable) ng.llenarGrilla();//casteo a datatable
            if(dt != null)
            {
                dataGridView1.DataSource = dt;
            }
            else MessageBox.Show("No hay datos");
            
        }
        string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);


        private void btnExcel2_Click_1(object sender, EventArgs e)
        {
            objExcel.Application objAplicacion = new objExcel.Application();
            Workbook objLibro = objAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);//nuevo libro en archivo excel
            Worksheet objHoja = (Worksheet)objAplicacion.ActiveSheet;//Hoja de calculo en nuesto nuevo libro

            objAplicacion.Visible = false; // abre automarico el excel (no quiero)

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                objHoja.Cells[1, columna.Index+1] = columna.HeaderText;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    objHoja.Cells[fila.Index+2, columna.Index+1] = fila.Cells[columna.Index].Value;
                }
            }

            objLibro.SaveAs(ruta + "\\PruebaExcel.xlsx");
            objLibro.Close();
            objAplicacion.Quit();
            MessageBox.Show("Excel Listo!");

        }
    }
}
