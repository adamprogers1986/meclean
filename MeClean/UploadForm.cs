using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace MeClean
{
    public partial class UploadForm : Form
    {
        public UploadForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Address address = new Address();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "csv files (*.csv)|*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                List<string> rows = File.ReadAllLines(filename).ToList();

                int max = Int32.MinValue;

                int columnindex = 0;
                int rowindex = 0;
                
                foreach (string row in rows)
                {

                    
                    foreach (string column in row.Split(','))
                    {
                      //  int getit = column.Max();
                       // MessageBox.Show(getit.ToString());
                          var CsvList = new List<Csv>();
                        CsvList.Add(new Csv {
                            rownumber = rowindex,
                            columnnumber = columnindex,
                            columncontent = column,
                            postcodecontent = address.Postcode


                        });
                        Csv firstCsv = CsvList[0];
                        MessageBox.Show(firstCsv.rownumber.ToString() + " " + firstCsv.columncontent.ToString());
                        columnindex++;
                    }
                    columnindex = 0;
                    rowindex++;
                }


               


            }











            }
        }

       
    }


