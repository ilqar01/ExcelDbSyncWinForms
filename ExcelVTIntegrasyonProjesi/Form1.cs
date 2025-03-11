using Microsoft.Office.Interop.Excel;
using System.Collections;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelVTIntegrasyonProjesi
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=localhost;Initial Catalog=ProjelerVT;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVtdenOku_Click(object sender, EventArgs e)
        {



            Excel.Application excelProgram = new Excel.Application();
            excelProgram.Visible = true;
            Excel.Workbook workbook = excelProgram.Workbooks.Add(System.Reflection.Missing.Value);
            Excel.Worksheet page1 = workbook.Sheets[1];

            string[] headings = { "Personel No", "Ad", "Soyad", "Semt", "Sehir" };
            Excel.Range range;
            for (int i = 0; i < headings.Length; i++)
            {
                range = page1.Cells[1, (1 + i)];
                range.Value2 = headings[i];
            }


            using (connection)
            {


                try
                {


                    connection.Open();
                    string query = "select * from Personel";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader sdr = command.ExecuteReader();

                    int row = 2;
                    while (sdr.Read())
                    {
                        string personelNo = sdr[0].ToString();
                        string name = sdr[1].ToString();
                        string surname = sdr[2].ToString();
                        string district = sdr[3].ToString();
                        string city = sdr[4].ToString();
                        richTextBox1.Text += personelNo + " " + name + " " + surname + " " + district + " " + city + "\n";

                        range = page1.Cells[row, 1];
                        range.Value2 = personelNo;
                        range = page1.Cells[row, 2];
                        range.Value2 = name;
                        range = page1.Cells[row, 3];
                        range.Value2 = surname;
                        range = page1.Cells[row, 4];
                        range.Value2 = district;
                        range = page1.Cells[row, 5];
                        range.Value2 = city;
                        row++;

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error while sql query process\n " + ex.ToString());
                }

            }
            
        }

        private void btnExceldenOku_Click(object sender, EventArgs e)
        {
            Excel.Application exlApp;
            Excel.Workbook exlWorkBook;
            Excel.Worksheet exlWorkSheet;
            Excel.Range range;
            int rowCount = 0;
            int columnCount = 0;
            exlApp = new Excel.Application();
            exlWorkBook = exlApp.Workbooks.Open("C:\\Users\\acer\\Documents\\Test.xlsx");
            exlWorkSheet = (Excel.Worksheet)exlWorkBook.Worksheets.get_Item(1);
            range = exlWorkSheet.UsedRange;

            richTextBox2.Clear();


            for(rowCount=2; rowCount<=range.Rows.Count; rowCount++)
            {
                ArrayList list = new ArrayList();


                for(columnCount=1; columnCount<=range.Columns.Count; columnCount++)
                {
                    string okunanHucre =Convert.ToString( (range.Cells[rowCount, columnCount] as Excel.Range).Value2);
                    richTextBox2.Text = richTextBox2.Text + okunanHucre + "  ";
                    list.Add(okunanHucre);
                }
                richTextBox2.Text = richTextBox2.Text + "\n";

                try
                {
                    connection.Open();
                    string query = "insert into personel values(@p1 , @p2 , @p3 , @p4 , @p5)";
                    SqlCommand command = new SqlCommand(query , connection);
                    command.Parameters.AddWithValue("@p1", list[0]);
                    command.Parameters.AddWithValue("@p2", list[1]);

                    command.Parameters.AddWithValue("@p3", list[2]);

                    command.Parameters.AddWithValue("@p4", list[3]);

                    command.Parameters.AddWithValue("@p5", list[4]);
                    command.ExecuteNonQuery();

                }
                catch (Exception a)
                {

                    MessageBox.Show("Error while connection with db \n" +  a );
                }
                finally
                {
                    if (connection != null)
                    {
                        connection.Close();
                    }
                }
            }


            exlApp.Quit();
            ReleaseObject(exlWorkSheet);
            ReleaseObject(exlWorkBook);
            ReleaseObject(exlApp);


        }

        private void ReleaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
            }
            catch(Exception ex)
            {
                obj = null;
            }

            finally
            {
                GC.Collect();
            }

        }
    }
}