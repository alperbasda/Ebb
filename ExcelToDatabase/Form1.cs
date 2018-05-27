using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelToDatabase
{
    public partial class Form1 : Form
    {
        private static string _path = "";
        private static bool _validate;
        private static string[] _propNames;
        private static string _createdQuery;
        public Form1()
        {
            InitializeComponent();
            _validate = true;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            DialogResult result = fd_openExcel.ShowDialog();
            if (result == DialogResult.OK)
            {
                _path = fd_openExcel.FileName;
            }
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            ValidateText();
            if (_validate)
            {

                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(_path);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                _propNames = new string[colCount];
                for (int i = 1; i <= colCount; i++)
                {
                    _propNames[i - 1] = xlRange.Cells[1, i].Value2.ToString();
                }

                _createdQuery = "insert into " + tb_tableName.Text + " values";
                for (int j = 2; j <= rowCount; j++)
                {
                    _createdQuery += " (";
                    for (int i = 1; i <= colCount; i++)
                    {
                        Decimal h2 = 0;
                        Decimal.TryParse(xlRange.Cells[j, i].Value2.ToString(), out h2);
                        _createdQuery +=  h2 + " ,";
                    }
                    _createdQuery = _createdQuery.Substring(0, _createdQuery.Length - 1);
                    _createdQuery += " ) ,";
                    if (j%500==0)
                    {
                        _createdQuery = _createdQuery.Substring(0, _createdQuery.Length - 1);
                        ExecQuery();
                        _createdQuery= "insert into " + tb_tableName.Text + " values";
                    } 
                }
                _createdQuery = _createdQuery.Substring(0, _createdQuery.Length - 1);
                ExecQuery();
                MessageBox.Show("Veri aktarımı tamamlandı");
            }
        }

        private void ValidateText()
        {
            if (string.IsNullOrEmpty(tb_conStr.Text))
            {
                MessageBox.Show("Connection String Boş geçilemez");
                _validate = false;
            }
        }
        
        private void ExecQuery()
        {
            string s = @"Server=.\SQLEXPRESS;Database=BusStationsDb;integrated security=True;";
            using (SqlConnection connection = new SqlConnection(tb_conStr.Text))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(_createdQuery, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

