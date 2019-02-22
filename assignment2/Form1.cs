/*==============================================================================
 Project    :  Advanced SQL Assignment #3
 Discription:  This application is to copy a table between two different database
               with OLE DB provider.
 Programmer :  Zhendong Tang
 Date       :  Feb 22, 2019
 ============================================================================*/






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
        string sourceConnection;   // connection string of source database
        
        public Form1()
        {
            InitializeComponent();
            this.sourceBtn.TabIndex = 0;    // this component get focus
        }

        private void Copy_Click(object sender, EventArgs e)
        {



            //   Check if the CONNECTION STRING is empty

            if (String.IsNullOrEmpty(sourceConnection) )
            {
                MessageBox.Show("Please Generate Connection String Frist!").ToString();
                Application.Exit();      //  if Connection String is EMPTY, application quits.
            }


            OleDbConnection myConnection = new OleDbConnection();
            try
            {

              
                myConnection.ConnectionString = sourceConnection;   //  Connect to Database

                myConnection.Open();

                OleDbCommand command = new OleDbCommand();

                command.Connection = myConnection;

                if (myConnection.State == ConnectionState.Open)
                {
   

                    // Check if all REQUIRED information are over there. 

                    if (String.IsNullOrEmpty(sourceDatabase.Text) || String.IsNullOrEmpty(sourceTable.Text) ||
                        String.IsNullOrEmpty(targetDatabase.Text) || String.IsNullOrEmpty(targetTable.Text))
                    {
                        MessageBox.Show("Please input all required information!").ToString();
                        Application.Exit();  // If missed something required, the application will quit. 
                    }



                    // Check if source database exists
                    command.CommandText = "select count(*) From master.dbo.sysdatabases where name = '" + sourceDatabase.Text + "'";

                    if((int)command.ExecuteScalar()==1)  // Source Database exists.
                    {


                        // check if source Table exists

                        command.CommandText = "use " + sourceDatabase.Text + "; SELECT count(*) FROM INFORMATION_SCHEMA.TABLES " + sourceDatabase.Text + " WHERE " + sourceDatabase.Text + ".TABLE_NAME = '" + sourceTable.Text + "'";


                        if((int)command.ExecuteScalar()!=1)  //  if source table doesn't exist

                        {
                            MessageBox.Show(sourceTable.Text + " doesn't  exist!").ToString();
                            Application.Exit();
                        }


                    }
                    else   //  if the source database doesn't exist.
                    {
                        MessageBox.Show("Database  " + sourceDatabase.Text + " doesn't  exist!").ToString();
                        Application.Exit();
                    }

                    // Check if target database exists

                    command.CommandText = "select count(*) From master.dbo.sysdatabases where name = '" + targetDatabase.Text + "'";

                    if((int)command.ExecuteScalar()==1)  // Target database exists
                    {
                        

                        // Once the Target database exists, then check  if target Table exists

                        command.CommandText = "use " + targetDatabase.Text + "; SELECT count(*) FROM INFORMATION_SCHEMA.TABLES " + targetDatabase.Text + " WHERE " + targetDatabase.Text + ".TABLE_NAME = '" + targetTable.Text + "'";


                        if((int)command.ExecuteScalar()==1) // if the target table is already over there. quit the application. 
                        {
                            MessageBox.Show(targetTable.Text + " already exist!, Copy is not possible, the application quit.").ToString();
                            Application.Exit();
                        }
                        else
                        {
 
                            // Everything is fine, ready to copy !!!!!
                            // Use a Transaction to keep the whole action safe


                            command.CommandText = "BEGIN TRAN COPY; ";  //  Start a Transaction                           
                            command.CommandText += "select* into " + targetDatabase.Text + ".dbo." + targetTable.Text + " from " + sourceDatabase.Text + ".dbo." + sourceTable.Text + "";
                            command.CommandText += ";COMMIT TRAN COPY";  // Commit a Transaction

                            int effectLines = command.ExecuteNonQuery();
                            MessageBox.Show("Copy successfully! "+ effectLines.ToString() + " records have been copied").ToString();


                        }


                    }
                    else
                    {
                        MessageBox.Show(targetDatabase.Text + " doesn't  exist!").ToString();
                        Application.Exit();
                    }


                }
                

            }
            catch (Exception ex)  // Once something wrong, show error message and quit.
            {
                MessageBox.Show(ex.Message.ToString()).ToString();
                Application.Exit();
            }
            finally
            {
                myConnection.Close();
            }
            Console.ReadLine();

            return;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ADODB.Connection conn = new ADODB.Connection();
            object oConn = (object)conn;

            MSDASC.DataLinks dlg = new MSDASC.DataLinks();
            dlg.PromptEdit(ref oConn);

            sourceConnection = conn.ConnectionString;

        }

       
    }
}








