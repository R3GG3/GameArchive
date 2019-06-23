using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((gamenameBox.TextLength > 3) && (gamelocBox.TextLength > 3) && (gamelocBox.Text!="Game Location") && (gamenameBox.Text!="Game Name"))
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
            try
            {
                SqlConnection con = new SqlConnection(@"Server=localhost\MSSQLSERVER01;Database=gamearchive;Trusted_Connection=True;");
                SqlCommand command = new SqlCommand
                    (
                        "DELETE FROM games " +
                        "WHERE game_name = '" + listBox1.SelectedItem.ToString() + "';", con
                    );
                SqlCommand command2 = new SqlCommand
                    (
                        "DBCC CHECKIDENT ('[games]', RESEED, 0);", con
                    );


                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    listBox1.Items.Remove(listBox1.SelectedItem);
                    listBox1.Update();
                }

                con.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void Ogfbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=localhost\MSSQLSERVER01;Database=gamearchive;Trusted_Connection=True;");
                SqlCommand command = new SqlCommand
                    (
                        "SELECT * FROM games "+
                        "WHERE game_name = '"+listBox1.SelectedItem.ToString()+"';", con
                    );


                con.Open();
                SqlDataReader sqlreader = command.ExecuteReader();
                if (con.State == ConnectionState.Open)
                {
                    while(sqlreader.Read())
                    {
                        Process.Start("explorer.exe", sqlreader["game_loc"].ToString());
                    }
                }

                con.Close();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

            catch(FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
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
                        listBox1.Sorted = true;
                    }
                }

                con.Close();
            }

            catch (SqlException)
            {

            }

            gamenameBox.Click += new EventHandler(textbox_clicked);
            gamelocBox.Click += new EventHandler(textbox_clicked2);
        }

        private void textbox_clicked(object ob, EventArgs e)
        {
            panel2.BackColor = Color.White;

            panel1.BackColor = Color.Blue;

            if (gamenameBox.Text == "Game Name")
            {
                gamenameBox.Text = "";
            }

            if (gamelocBox.TextLength < 1)
            {
                gamelocBox.Text = "Game Location";
            }
        }

        private void textbox_clicked2(object ob, EventArgs e)
        {
            panel2.BackColor = Color.Blue;

            panel1.BackColor = Color.White;

            if(gamelocBox.Text=="Game Location")
            {
                gamelocBox.Text = "";
            }

            if(gamenameBox.TextLength<1)
            {
                gamenameBox.Text = "Game Name";
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
