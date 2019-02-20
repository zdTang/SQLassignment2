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

namespace assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


    


        private void Copy_Click(object sender, EventArgs e)
        {
            OleDbConnection myConnection = new OleDbConnection("File Name = d:\\link.udl");            //myConnection.ConnectionString = "File Name =‪ D:\\link.UDL";            try
            {
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                    MessageBox.Show("Good!").ToString();
                    //Console.WriteLine("Connection opened successfully!");
                else
                    Console.WriteLine("Connection could not be established");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            finally
            {
                myConnection.Close();
            }
            Console.ReadLine();

            return;
        }
    }
}
