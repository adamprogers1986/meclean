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
                string[] rows = File.ReadAllLines(filename);

                


                int columnindex = 0;
                int rowindex = 0;
                int highestindex = 0;
                foreach (string row in rows)
                {

                    string[] columns = row.Split(',');

                    int? maxVal = null; //nullable so this works even if you have all super-low negatives
                   
                    //  foreach (string column in columns)
                    for ( int i = 0; i < columns.Length; i++)
                    {

                        int thisNum = i;
                        if (!maxVal.HasValue || thisNum > maxVal.Value)
                        {
                            maxVal = thisNum;
                            highestindex = i;
                           
                        }

                        var CsvList = new List<Csv>();
                        CsvList.Add(new Csv {
                            rownumber = rowindex,
                            columnnumber = i,
                            columncontent = columns[i],
                            postcodecontent = address.Postcode,
                            postcodecolumn = highestindex + 1

                        });
                       // Csv firstCsv = CsvList[0];
                        
                        columnindex++;
                        //MessageBox.Show(columnindex.Max().tostring());
                    }

                    
                    columnindex = 0;
                    rowindex++;

                   
                    MessageBox.Show(highestindex.ToString());
                }
                




            }











            }
        }

       
    }


