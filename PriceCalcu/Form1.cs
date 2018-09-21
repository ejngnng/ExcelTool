using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PriceCalcu.util;

namespace PriceCalcu
{
    public partial class Form1 : Form
    {
        private DataTable SourceData = null;
        public Form1()
        {
            InitializeComponent();
            TXT_RATE.Text = "90";
        }

        private void BTN_FILE_EXPLOR_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*xls*)|*.xls*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径
                TXT_FILE_PATH.Text = file.ToString();
            }
        }

        private void BTN_IMPORT_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            DataColumn Number = new DataColumn();
            Number.ColumnName = "序号";
            Number.AutoIncrement = true;
            Number.AutoIncrementSeed = 1;
            Number.AutoIncrementStep = 1;
            dt.Columns.Add(Number);

            DataColumn Company = new DataColumn();
            Company.ColumnName = "报名公司";
            dt.Columns.Add(Company);

            DataColumn Price = new DataColumn();
            Price.ColumnName = "价格";
            dt.Columns.Add(Price);

            DataTable origin = GetExcelData(TXT_FILE_PATH.Text.ToString());
            int origin_rows = origin.Rows.Count;
            int origin_cols = origin.Columns.Count;
            Console.WriteLine("rows: {0}, coloumn: {1}", origin_rows, origin_cols);
            Console.WriteLine("rows 1, col 1: {0}", origin.Rows[0][1].ToString());
            for(int i=0; i<(origin_rows-1); i++)
            {
                dt.Rows.Add();
            }

            for(int i=0; i<origin_rows-1; i++)
            {
                for(int j=0; j<origin_cols; j++)
                {
                    dt.Rows[i][j+1] = origin.Rows[i+1][j].ToString();
                }
            }

            SourceDataGridView.DataSource = dt;

            SourceData = dt;
        }

        private static DataTable GetExcelData(string str)
        {
            string strCon = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + str + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + str + ";" + "Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
            string strCom = " SELECT * FROM [Sheet1$]";
            myConn.Open();
            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            DataTable myDataSet = new DataTable();
            myCommand.Fill(myDataSet);
            myConn.Close();
            return myDataSet;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("table change");
            Console.WriteLine("table: {0}", tabControl1.SelectedIndex);
            if(tabControl1.SelectedIndex == 1)
            {
                tabControlIndex1_Process();
            }
            else if(tabControl1.SelectedIndex == 2)
            {

            }
        }

        private void tabControlIndex1_Process()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = SourceData;
                DataColumn Score = new DataColumn();
                Score.ColumnName = "价格得分";
                dt.Columns.Add(Score);

                DataColumn Sort = new DataColumn();
                Sort.ColumnName = "排名";
                dt.Columns.Add(Sort);

                dataGridView1.DataSource = SourceData;

                List<double> Total = new List<double>();

                for (int i = 0; i < (SourceData.Rows.Count - 1); i++)
                {
                    Total.Add(double.Parse(SourceData.Rows[i][2].ToString()));
                }

                Console.WriteLine("avg: {0}", Total.Average().ToString());
                TXT_AVG.Text = Total.Average().ToString("f3");
                double avg = double.Parse(TXT_AVG.Text.ToString());
                double rate = double.Parse(TXT_RATE.Text.ToString());
                TXT_BASE.Text = (avg * rate / 100).ToString("f3");

                for(int i=0; i<(SourceData.Rows.Count); i++)
                {
                    CondicationFanbiOne calcu = new CondicationFanbiOne(double.Parse(SourceData.Rows[i][2].ToString()));
                    calcu.setAverage(double.Parse(TXT_AVG.Text.ToString()));
                    calcu.setRate(double.Parse(TXT_RATE.Text.ToString()));
                    Console.WriteLine("{0}, res: {1}", i, calcu.getResult().ToString());
                    dt.Rows[i][3] = calcu.getResult().ToString("f2");
                }

                double[] score = new double[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    score[i] = double.Parse(dt.Rows[i][3].ToString());
                }

                PriceSort sort = new PriceSort(score);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i][4] = sort.getNumber(double.Parse(dt.Rows[i][3].ToString()));
                }
            }
            catch
            {
                return;
            }

        }

        private void TXT_RATE_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = (DataTable)dataGridView1.DataSource;
                double avg = double.Parse(TXT_AVG.Text.ToString());
                double rate = double.Parse(TXT_RATE.Text.ToString());
                TXT_BASE.Text = (avg * rate / 100).ToString("f3");
                for (int i = 0; i < (SourceData.Rows.Count); i++)
                {
                    CondicationFanbiOne calcu = new CondicationFanbiOne(double.Parse(SourceData.Rows[i][2].ToString()));
                    calcu.setAverage(double.Parse(TXT_AVG.Text.ToString()));
                    calcu.setRate(double.Parse(TXT_RATE.Text.ToString()));
                    Console.WriteLine("{0}, res: {1}", i, calcu.getResult().ToString());
                    dt.Rows[i][3] = calcu.getResult().ToString("f2");
                }

                double[] score = new double[dt.Rows.Count];
                for(int i=0; i< dt.Rows.Count; i++)
                {
                    score[i] = double.Parse(dt.Rows[i][3].ToString());
                }

                PriceSort sort = new PriceSort(score);
                for(int i=0; i<dt.Rows.Count; i++)
                {
                    dt.Rows[i][4] = sort.getNumber(double.Parse(dt.Rows[i][3].ToString()));
                }

            }
            catch
            {
                return;
            }
        }
    }
}
