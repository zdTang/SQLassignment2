namespace assignment2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceTable = new System.Windows.Forms.TextBox();
            this.sourceDatabase = new System.Windows.Forms.TextBox();
            this.targetDatabase = new System.Windows.Forms.TextBox();
            this.targetTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Copy = new System.Windows.Forms.Button();
            this.sourceBtn = new System.Windows.Forms.Button();
            this.targetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sourceTable
            // 
            this.sourceTable.Location = new System.Drawing.Point(158, 190);
            this.sourceTable.Name = "sourceTable";
            this.sourceTable.Size = new System.Drawing.Size(125, 20);
            this.sourceTable.TabIndex = 0;
            // 
            // sourceDatabase
            // 
            this.sourceDatabase.Location = new System.Drawing.Point(158, 130);
            this.sourceDatabase.Name = "sourceDatabase";
            this.sourceDatabase.Size = new System.Drawing.Size(125, 20);
            this.sourceDatabase.TabIndex = 1;
            // 
            // targetDatabase
            // 
            this.targetDatabase.Location = new System.Drawing.Point(653, 130);
            this.targetDatabase.Name = "targetDatabase";
            this.targetDatabase.Size = new System.Drawing.Size(125, 20);
            this.targetDatabase.TabIndex = 2;
            // 
            // targetTable
            // 
            this.targetTable.Location = new System.Drawing.Point(653, 196);
            this.targetTable.Name = "targetTable";
            this.targetTable.Size = new System.Drawing.Size(125, 20);
            this.targetTable.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Table";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(567, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(567, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(650, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Destination";
            // 
            // Copy
            // 
            this.Copy.Location = new System.Drawing.Point(378, 125);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(110, 23);
            this.Copy.TabIndex = 5;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = true;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // sourceBtn
            // 
            this.sourceBtn.Location = new System.Drawing.Point(75, 50);
            this.sourceBtn.Name = "sourceBtn";
            this.sourceBtn.Size = new System.Drawing.Size(208, 23);
            this.sourceBtn.TabIndex = 6;
            this.sourceBtn.Text = "Setup Source Database";
            this.sourceBtn.UseVisualStyleBackColor = true;
            this.sourceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // targetBtn
            // 
            this.targetBtn.Location = new System.Drawing.Point(570, 49);
            this.targetBtn.Name = "targetBtn";
            this.targetBtn.Size = new System.Drawing.Size(208, 24);
            this.targetBtn.TabIndex = 7;
            this.targetBtn.Text = "Setup Destination Database";
            this.targetBtn.UseVisualStyleBackColor = true;
            this.targetBtn.Click += new System.EventHandler(this.targetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 253);
            this.Controls.Add(this.targetBtn);
            this.Controls.Add(this.sourceBtn);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetTable);
            this.Controls.Add(this.targetDatabase);
            this.Controls.Add(this.sourceDatabase);
            this.Controls.Add(this.sourceTable);
            this.Name = "Form1";
            this.Text = "Data Transfer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceTable;
        private System.Windows.Forms.TextBox sourceDatabase;
        private System.Windows.Forms.TextBox targetDatabase;
        private System.Windows.Forms.TextBox targetTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.Button sourceBtn;
        private System.Windows.Forms.Button targetBtn;
    }
}

