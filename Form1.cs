using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("ColumnA", "a");
            dataGridView1.Columns.Add("ColumnX", "x");
            dataGridView1.Columns.Add("ColumnY", "y");

            for (int a = -10; a <= 10; a++)
            {
                string[] values = CalculateValues(a);
                dataGridView1.Rows.Add(values);
            }
        }

        public static string[] CalculateValues(double a)
        {
            double x = a * a;
            double y = Math.Sqrt(a);
            return new string[] { a.ToString(), x.ToString(), y.ToString() };
        }

       


    }
}



