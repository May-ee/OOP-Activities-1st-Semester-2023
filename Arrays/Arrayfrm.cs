using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Arrays
{
    public partial class Arrayfrm : Form
    {
        //Encapsulation Activity: refer to Details Class
        private Details details = new Details();


        public Arrayfrm()
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.Rows.Clear();
        }

        ///Array Activity
        //private string[]  dataArray = {};
        //private string[] M = {};
        //private string[] L = {};
        //private string[] A = {};
        //private string[] dataArray = new string(4);
        // End of Array Activity

        private void InitializeDataGridView()
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "First Name";
            dataGridView1.Columns[1].Name = "Middle Name";
            dataGridView1.Columns[2].Name = "Last Name";
            dataGridView1.Columns[3].Name = "Age";
            UpdateDataGridView();


        }

        private void UpdateDataGridView()
        {
            ///Array Activity
            //dataGridView1.Rows.Clear();
            //foreach (var item in details.GetArray())
            //{
            //    dataGridView1.Rows.Add(item);
            //}
            ///End of Array Activity

            //Encapsulation Activity
            dataGridView1.Rows.Clear();

            for (int i = 0; i < details.getF().Length; i++)
            {
                dataGridView1.Rows.Add(details.getF()[i], details.getM()[i], details.getL()[i], details.getA()[i]);

            }
            //End Encapsulation Activity

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ///Array Activity
            //try
            //{
            //    //assign textbox 1 to new item variable
            //string fname = textBox1.Text;
            //string mname = textBox2.Text;
            //string lname = textBox3.Text;
            //string age = textBox4.Text;

            //if (string.IsNullOrEmpty(fname) && string.IsNullOrEmpty(mname) && string.IsNullOrEmpty(lname) && string.IsNullOrEmpty(age))
            //{
            //    MessageBox.Show("error");
            //}
            //
            //

            //    Array.Resize(ref dataArray, dataArray.Length + 1); //to add new item in th array
            //    Array.Resize(ref M, M.Length + 1);
            //    Array.Resize(ref L, L.Length + 1);
            //    Array.Resize(ref A, A.Length + 1);//resizing array method with arguments of reference array and its length added by 1
            //    dataArray[dataArray.Length - 1] = fname;
            //    M[M.Length - 1] = mname;
            //    L[L.Length - 1] = lname;
            //    A[A.Length - 1] = age;//

            //    UpdateDataGridView();

            //    textBox1.Clear(); // to clear inputs 
            //    textBox2.Clear();
            //    textBox3.Clear();
            //    textBox4.Clear();
            //

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("error" + ex);
            //}
            //// End of Array Activity

            //Encapsulation Activity

            try
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("Input All the Fields");
                }

                string newItem = textBox1.Text;
                string newItem2 = textBox2.Text;
                string newItem3 = textBox3.Text;
                string newItem4 = textBox4.Text;

                details.AddData(newItem, newItem2, newItem3, newItem4);

                UpdateDataGridView();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex);
            }


        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
