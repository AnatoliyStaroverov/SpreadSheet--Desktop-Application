// <copyright file="Form1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AnatoliyStaroverov_PA4
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Form Application.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Load the form data.
        /// </summary>
        /// <param name="sender"> sender object.</param>
        /// <param name="e"> event argument.</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Clear();
            char alphabet = 'A';
            for (int x = 0; x < 26; x++, alphabet++)
            {
                this.dataGridView1.Columns.Add(alphabet.ToString(), alphabet.ToString());
            }

            this.dataGridView1.Rows.Clear();
            for (int i = 1; i <= 50; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i - 1].HeaderCell.Value = i.ToString();
                this.dataGridView1.AutoResizeRowHeadersWidth(0, DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            }

            //this.sheet.CellPropertyChanged += this.PropertyChanged;
        }
    }
}
