using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TechMate_Inventory
{
    public partial class frmLogin : Form
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["local.TechMateInventoryConnectionString"].ConnectionString;

        public frmLogin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '\u25CF'; // Configurar para ocultar la contraseña inicialmente

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckCredentials();
        }

        private void CheckCredentials()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    if (isUserInDB(connection, textBoxUserName) && isPasswordCorrect(connection, textBoxUserName, textBoxPassword))
                    {
                        Login();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("POPUP ERROR: " + ex.Message);
                }
            }
        }

        private void Login()
        {
            Form1 application = new Form1(textBoxUserName.Text, this);
            application.Show();
            this.Hide();
        }

        private void Login(string forcedUser)
        {
            Form1 application = new Form1(forcedUser, this);
            application.Show();
            this.Hide();
        }

        private bool isUserInDB(SqlConnection connection, TextBox userName)
        {
            string query = @"SELECT COUNT(1) FROM Users WHERE Name = @textBoxUserName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Añadiendo los parámetros al comando
                    command.Parameters.AddWithValue("@textBoxUserName", userName.Text);

                    // Ejecutar el comando y obtener el resultado
                    int userCount = (int)command.ExecuteScalar();

                    // Devolver verdadero si el usuario existe, de lo contrario falso
                    return userCount > 0;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR isUserInDB: " + ex.Message);
                    return false;
                }
            }
        }

        private bool isPasswordCorrect(SqlConnection connection, TextBox inputUserName, TextBox inputPassword)
        {
            string query = @"SELECT password FROM Users WHERE Name = @textBoxUserName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                try
                {
                    // Añadiendo los parámetros al comando
                    command.Parameters.AddWithValue("@textBoxUserName", inputUserName.Text);

                    // Ejecutar el comando
                    object result = command.ExecuteScalar();

                    // contraseña correcta a string para comparar
                    string correctPwd = result.ToString();

                    //compare input with actual pwd
                    if (correctPwd == inputPassword.Text)
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR ValidatePassword: " + ex.Message);
                    return false;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AlternatePwdFont(textBoxPassword);
        }

        private void AlternatePwdFont(TextBox pwdBox)
        {
            if (pwdBox.PasswordChar == '\u25CF')
            {
                pwdBox.PasswordChar = '\0'; // Mostrar texto
            }
            else
            {
                pwdBox.PasswordChar = '\u25CF'; // Ocultar texto con puntos
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función no implementada aún");
        }

        private void forceLoginBtn_Click(object sender, EventArgs e)
        {
            string forcedUser = "Developer";
            Login(forcedUser);
        }
    }
}
