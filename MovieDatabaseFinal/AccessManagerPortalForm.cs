using MovieDatabaseFinal.MovieTheatreDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDatabaseFinal
{
    public partial class AccessManagerForm : Form
    {
        bool managerFound = false;
        bool clientFound = false;
        public AccessManagerForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            if (userName == "")
            {
                MessageBox.Show("Please enter your user name.");
            } else if (password == "")
            {
                MessageBox.Show("Please enter your password.");
            }
            else
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\LE2176022\OneDrive - Champlain Regional College\Documents\Semester 3\OOP 2\FinalProject\MovieDatabaseFinal\MovieDatabaseFinal\MovieTheatre.mdf"";Integrated Security=True;Connect Timeout=30";
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from UserData";
                cmd.Connection = conn;

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader[1].ToString() == userName && reader[2].ToString() == password)
                    {
                        if (reader[3].ToString() == "Manager")
                        {
                            managerFound = true;
                            break;
                        }
                        else if(reader[3].ToString() == "Client")
                        {
                            clientFound = true;
                            break;
                        }
                    }
                }

                if (managerFound)
                {
                    //ManagerForm myManagerForm = new ManagerForm;
                    //myManagerForm.showDialogue();

                }
                else if (clientFound)
                {
  
                }else
                {
                    MessageBox.Show("The data that you entered is incorrect.");
                }
            }
        }
    }
}
