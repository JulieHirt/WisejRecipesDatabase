﻿namespace RecipeDatabase
{
    partial class Page1
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

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.dataGridView2 = new Wisej.Web.DataGridView();
			this.textBox1 = new Wisej.Web.TextBox();
			this.button1 = new Wisej.Web.Button();
			this.label3 = new Wisej.Web.Label();
			this.button2 = new Wisej.Web.Button();
			this.buttonReload = new Wisej.Web.Button();
			this.dataRepeater1 = new Wisej.Web.DataRepeater();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).BeginInit();
			this.dataRepeater1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = true;
			this.dataGridView1.AllowUserToDeleteRows = true;
			this.dataGridView1.Location = new System.Drawing.Point(24, 70);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(399, 309);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellEndEdit += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(47, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 2;
			this.label1.Text = "dbo.Menu_Items";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(694, 46);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 18);
			this.label2.TabIndex = 3;
			this.label2.Text = "dbo.Food_Group";
			// 
			// dataGridView2
			// 
			this.dataGridView2.Location = new System.Drawing.Point(449, 70);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(443, 308);
			this.dataGridView2.TabIndex = 4;
			this.dataGridView2.CellEndEdit += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(182, 392);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(148, 30);
			this.textBox1.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(66, 437);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(126, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = "Filter";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 395);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 18);
			this.label3.TabIndex = 7;
			this.label3.Text = "Enter a food group here";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(612, 395);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(199, 38);
			this.button2.TabIndex = 8;
			this.button2.Text = "Filter based on selected row";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// buttonReload
			// 
			this.buttonReload.Location = new System.Drawing.Point(291, 24);
			this.buttonReload.Name = "buttonReload";
			this.buttonReload.Size = new System.Drawing.Size(267, 30);
			this.buttonReload.TabIndex = 9;
			this.buttonReload.Text = "Reload from Database/ clear filters";
			this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
			// 
			// dataRepeater1
			// 
			this.dataRepeater1.ItemSize = new System.Drawing.Size(200, 100);
			// 
			// dataRepeater1.ItemTemplate
			// 
			this.dataRepeater1.ItemTemplate.Size = new System.Drawing.Size(462, 100);
			this.dataRepeater1.Location = new System.Drawing.Point(927, 94);
			this.dataRepeater1.Name = "dataRepeater1";
			this.dataRepeater1.Size = new System.Drawing.Size(464, 272);
			this.dataRepeater1.TabIndex = 10;
			this.dataRepeater1.Text = "dataRepeater1";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.dataRepeater1);
			this.Controls.Add(this.buttonReload);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1394, 546);
			this.Load += new System.EventHandler(this.Page1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataRepeater1)).EndInit();
			this.dataRepeater1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Wisej.Web.DataGridView dataGridView1;
        private Wisej.Web.Label label1;
        private Wisej.Web.Label label2;
        private Wisej.Web.DataGridView dataGridView2;
        private Wisej.Web.TextBox textBox1;
        private Wisej.Web.Button button1;
        private Wisej.Web.Label label3;
        private Wisej.Web.Button button2;
        private Wisej.Web.Button buttonReload;
		private Wisej.Web.DataRepeater dataRepeater1;
	}
}

