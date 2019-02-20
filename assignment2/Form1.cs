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
            this.sourceDatabase.TabIndex = 0;// this one get focus
        }


    


        private void Copy_Click(object sender, EventArgs e)
        {
            OleDbConnection myConnection = new OleDbConnection("File Name = d:\\link.udl");
            //myConnection.ConnectionString = "File Name =‪ D:\\link.UDL";
            try
            {
                myConnection.Open();
                if (myConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Good!").ToString();
                    //DataTable dt = myConnection.GetSchema();

                    // MessageBox.Show("pretty Good!").ToString();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = myConnection;
                    command.CommandText = "use " + sourceDatabase.Text + "; select count(*) From master.dbo.sysdatabases where name = '" + sourceDatabase.Text + "'";
                    string num = command.ExecuteScalar().ToString();
                    if(num=="1")
                    {
                        MessageBox.Show(sourceDatabase.Text + " exist!").ToString();

                        string x = sourceTable.Text;

                        //command.CommandText = "SELECT count(*) FROM INFORMATION_SCHEMA.TABLES " + sourceDatabase.Text + " WHERE " + sourceDatabase.Text + ".TABLE_NAME = '" + sourceTable.Text + "'";
                        //command.CommandText = "SELECT count(*) FROM INFORMATION_SCHEMA.TABLES " + sourceDatabase.Text + "";
                        string ifTable = command.ExecuteScalar().ToString();
                        if(ifTable=="1")
                        {
                            MessageBox.Show(sourceTable.Text + "table  exist!").ToString();
                        }
                        else
                        {
                            MessageBox.Show(sourceTable.Text + " doesn't  exist!").ToString();
                        }
                        //int table = dTable.Rows.Count ;

                    }
                    else
                    {
                        MessageBox.Show("Database" + sourceDatabase.Text+" doesn't  exist!").ToString();
                    }
                    

                }

                // all logic should put here


                /*check source and destination database*/

                // get text from those textbox








                else
                    MessageBox.Show("Connot connect to the database, check the UDL file. ").ToString();
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
