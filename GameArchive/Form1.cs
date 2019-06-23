using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameArchive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((gamenameBox.TextLength > 3) && (gamelocBox.TextLength > 3))
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Server=localhost\MSSQLSERVER01;Database=gamearchive;Trusted_Connection=True;");
                    SqlCommand command = new SqlCommand
                        (
                            "INSERT     INTO    games   (game_name, game_loc)" +
                            "VALUES                     ('" + gamenameBox.Text + "', '" + gamelocBox.Text + "')", con

                        );

                    con.Open();

                    if (con.State == ConnectionState.Open)
                    {
                        command.ExecuteNonQuery();
                    }

                    con.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }

                Application.Restart();
            }

            else
            {
                MessageBox.Show("Input some data!", "ERROR");
            }
        }

        private void Removebutton_Click(object sender, EventArgs e)
        {

        }

        private void Ogfbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=localhost\MSSQLSERVER01;Database=gamearchive;Trusted_Connection=True;");
                SqlCommand command = new SqlCommand
                    (
                        "SELECT     game_name " +
                        "FROM       games " +
                        "WHERE      game_name = " + listBox1.SelectedItem.ToString(), con
                        
                    );


                con.Open();
                SqlDataReader sqlreader = command.ExecuteReader();
                if (con.State == ConnectionState.Open)
                {
                    MessageBox.Show("Working!");
                }

                con.Close();
            }

            catch (SqlException)
            {

            }
        }

        private void Fbutton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            gamelocBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=localhost\MSSQLSERVER01;Database=gamearchive;Trusted_Connection=True;");
                SqlCommand command = new SqlCommand
                    (
                        "SELECT     game_name " +
                        "FROM       games", con
                    );


                con.Open();
                SqlDataReader sqlreader = command.ExecuteReader();
                if (con.State == ConnectionState.Open)
                {
                    while (sqlreader.Read())
                    {
                        listBox1.Items.Add(sqlreader["game_name"]);
                    }
                }

                con.Close();
            }

            catch (SqlException)
            {

            }
        }
    }
}
