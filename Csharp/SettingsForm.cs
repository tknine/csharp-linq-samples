using SampleQueries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuerySamples
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();

        }
        
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NorthwindConnection = this.ConnectionTextBox.Text;
            LinqToSqlSamples.ConnString = QuerySamples.Properties.Settings.Default.NorthwindConnection;

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.ConnectionTextBox.Text = Properties.Settings.Default.NorthwindConnection;
        }
    }
}
