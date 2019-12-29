using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Pong_Game
{
    public partial class Login_Form : Form
    {
        //This is a variable for if user has been found in the database.
        bool FoundUser;
        
        bool? AllowRegister;

        //This gives the database a c# name.
        string Filename = "Credentials.txt";

        public Login_Form()
        {
            InitializeComponent();
        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            //This is for if the fields have been left blank, a message box error will appear.
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your username and password");
                FoundUser = false;
            }
            else
            {
                //This sets up the StreamReader Routine.
                CheckLogin(Filename);
            }
        }

        void CheckLogin(string path)
        {
            //This names the StreamReader
            StreamReader Read = new StreamReader(path);

            //This reads the lines of the database
            string DataBase_Line = Read.ReadLine();

            //This is to keep it reading until it reaches either a match, or the end of the database.
            while (DataBase_Line != null)
            {
                //sets up username to add to message box later
                string user;


                if (DataBase_Line == txtUsername.Text)
                {
                    user = DataBase_Line;
                    DataBase_Line = Read.ReadLine();

                    if (DataBase_Line == txtPassword.Text)
                    {
                        //If a match is found, a welcome message is found, it changes found user to true and stops it reading.
                        MessageBox.Show("Welcome to the game " + user);
                        FoundUser = true;
                        DataBase_Line = null;
                    }
                }

                else
                    //if a match isn't found, this keeps it reading.
                    DataBase_Line = Read.ReadLine();

            }

            if (!FoundUser)
            {
                //If a match is not found, a error messagebox is displayed.
                MessageBox.Show("Username and/or Password is not correct");
                Read.Close();
            }
            else
            {
                //This sends you to the start menu if you have a valid login and found user is true.
                Read.Close();
                this.Hide();
                Start_Menu Start_Menu = new Start_Menu();
                Start_Menu.Show();
            }
        }




        void CheckRegister(string path)
        {
            //This names the StreamReader
            StreamReader Read = new StreamReader(path);

            //This reads the lines of the database
            string DataBase_Line = Read.ReadLine();

            //This is to keep it reading until it reaches either a match, or the end of the database.
            while (DataBase_Line != null)
            {

                if (DataBase_Line == txtUsername.Text)
                {
                    AllowRegister = false;
                    DataBase_Line = null;
                    Read.Close();

                }

                else
                    //if a match isn't found, this keeps it reading.
                    DataBase_Line = Read.ReadLine();
            }

                while (DataBase_Line == null && AllowRegister == null)
            {
                AllowRegister = true;
                Read.Close();
            }

            if (AllowRegister == false)
            {
                MessageBox.Show("You have already registered with this username, please login!");
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtRepassword.Text = "";
                btnLogin.Enabled = true;
                AllowRegister = null;
                Read.Close();     
            }
        }
        
                
            






    private void btnRegister_Click(object sender, EventArgs e)
        {

            if (txtRepassword.Visible == false)
            {
                //sets the fields to be blank until it is visible, including the repassword elements.
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtRepassword.Text = "";

                MessageBox.Show("To register please enter your desired username, and then input your password twice and press Register again!");

                lblRepassword.Visible = true;
                txtRepassword.Visible = true;
                btnLogin.Enabled = false;
            }


            else
            {
                //This code is to check whether what you have inputted is allowed and whether there are no blank fields.
                if (txtUsername.Text == "" || txtPassword.Text == "" || txtRepassword.Text == "")
                    MessageBox.Show("Please enter your details to register with!");
                else if (txtPassword.Text != txtRepassword.Text)
                {
                    MessageBox.Show("The two passwords entered do not match!");
                    AllowRegister = null;
                }


                CheckRegister(Filename);


                if (AllowRegister == true)
                {               
                        //This adds the inputted data, to the database.
                        AddCredentials(Filename, txtUsername.Text, txtPassword.Text);

                        AllowRegister = null;
                        
                        //This confirms it has registered successfuly and adds the new username in the box.
                        MessageBox.Show("Thank you for registering! Please enjoy PONG,  " + txtUsername.Text);
                        
                        //This sends you to the start menu if you have registered successfully.
                        this.Hide();
                        Start_Menu Start_Menu = new Start_Menu();
                        Start_Menu.Show();
                    
                           
                    }
                }
            }
        

        void AddCredentials(string path, string username, string password)
        {
            //This is the code to actually write the details obtained earlier in the reference to this, to the database.
            StreamWriter Write;

            if (File.Exists(path) == true)
            {
                Write = File.AppendText(path);


                Write.WriteLine(username);
                Write.WriteLine(password);


                Write.Flush();
                Write.Close();
            }
        }
    }
}

        
    
    

