﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classwritersrccscode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public classwriter cwr = new classwriter("persoana","public",true,true);

        private void button1_Click(object sender, EventArgs e)
        {
            cwr.entries.Add(new entryItem("1", "public", "int", "cod", "1", 5));
            cwr.entries.Add(new entryItem("2", "public", "string", "name", "numele", 50));
            cwr.entries.Add(new entryItem("2", "public", "string", "prenume", "prenumele", 50));
            cwr.entries.Add(new entryItem("3", "public", "float", "numericf", "1.0f", 10));
            cwr.entries.Add(new entryItem("4", "public", "double", "numericd", "19090329032", 10));
            cwr.entries.Add(new entryItem("5", "public", "bool", "isEmpty", "true", 5));
            cwr.entries.Add(new entryItem("6", "public", "bool", "IsNotEmpty", "false", 5));
            string ss = cwr.writeTheClass();
            this.textBox1.Text = ss;    
        }
    }
}
