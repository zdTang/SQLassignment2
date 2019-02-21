﻿using System;
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
        static string sourceConnection;   // connection string of source database
        static string targetConnection;   // connection string of target database




        public Form1()
        {
            InitializeComponent();
            this.sourceDatabase.TabIndex = 0;// this one get focus
        }


    


        private void Copy_Click(object sender, EventArgs e)
        {
            // OleDbConnection myConnection = new OleDbConnection("File Name = d:\\link.udl");
            OleDbConnection myConnection = new OleDbConnection();
            myConnection.ConnectionString = "Provider=SQLOLEDB.1;Password=123456;Persist Security Info=True;User ID=sa;Data Source=tang";
            //myConnection.ConnectionString = "File Name =‪ D:\\link.UDL";
            try
            {
                myConnection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = myConnection;

                if (myConnection.State == ConnectionState.Open)
                {
                    MessageBox.Show("Connection is Good!").ToString();

                    // check source database
                    command.CommandText = "select count(*) From master.dbo.sysdatabases where name = '" + sourceDatabase.Text + "'";
                    string num = command.ExecuteScalar().ToString();
                    if (num == "1")
                    {
                        MessageBox.Show(sourceDatabase.Text + " exist!").ToString();

                        // check source Table

                        command.CommandText = "use " + sourceDatabase.Text + "; SELECT count(*) FROM INFORMATION_SCHEMA.TABLES " + sourceDatabase.Text + " WHERE " + sourceDatabase.Text + ".TABLE_NAME = '" + sourceTable.Text + "'";

                        string ifTable = command.ExecuteScalar().ToString();

                        if (ifTable == "1")
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
                        MessageBox.Show("Database" + sourceDatabase.Text + " doesn't  exist!").ToString();
                    }


                    // check Target database

                    command.CommandText = "select count(*) From master.dbo.sysdatabases where name = '" + targetDatabase.Text + "'";
                    string ifTargetExist = command.ExecuteScalar().ToString();
                    if (ifTargetExist == "1")
                    {
                        MessageBox.Show(targetDatabase.Text + " exist!").ToString();
                    }
                    else
                    {
                        MessageBox.Show(targetDatabase.Text + " doesn't  exist!").ToString();
                    }

                    // start to copy

                    command.CommandText = "select count(*) From master.dbo.sysdatabases where name = '" + targetDatabase.Text + "'";

                    //select* into b数据库.dbo.b表 from a数据库.dbo.a表[where 条件]//

                    //OleDbConnection c = new OleDbConnection("connectionStringForServer1Database1Here");
                    //OleDbConnection c2 = new OleDbConnection("connectionStringForServer2Database1Here");
                    //c.Open();
                    //OleDbCommand cm = new OleDbCommand(c);
                    //cm.CommandText = "select * from table1;";
                    //using (OleDbDataReader reader = cm.ExecuteReader())
                    //{
                    //    using (SqlBulkInsert bc = new OleDbBulkInsert(c))
                    //    {
                    //        c2.Open();
                    //        bc.DestinationTable = "table1";
                    //        bc.WriteToServer(reader);
                    //    }
                    //}










                }
                // all logic should put here


                /*check source and destination database*/

                // get text from those textbox

                else
                {
                    MessageBox.Show("Connot connect to the database, check the UDL file. ").ToString();
                }
                    
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

        private void button1_Click(object sender, EventArgs e)
        {

            ADODB.Connection conn = new ADODB.Connection();
            object oConn = (object)conn;

            MSDASC.DataLinks dlg = new MSDASC.DataLinks();
            dlg.PromptEdit(ref oConn);

            sourceConnection = conn.ConnectionString;

        }

        private void targetBtn_Click(object sender, EventArgs e)
        {
            ADODB.Connection conn = new ADODB.Connection();
            object oConn = (object)conn;

            MSDASC.DataLinks dlg = new MSDASC.DataLinks();
            dlg.PromptEdit(ref oConn);

            targetConnection = conn.ConnectionString;
        }
    }
}
