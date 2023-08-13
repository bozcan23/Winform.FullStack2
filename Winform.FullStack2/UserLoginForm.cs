using System.Data;
using System.Data.SqlClient;
using Winform.FullStack2.DTO;
using Winform.FullStack2.Forms;

namespace Winform.FullStack2
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                var response = GetUser(txtUsername.Text, txtPassword.Text);
                if (response!=null) 
                {
                    NavigationForm Form = new NavigationForm(response);
                    //ProductForm noteForm = new ProductForm(userFullName);
                    //form.username= txtUsername.Text;
                    Form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
                
            }
            else
            {
                MessageBox.Show("Alanları doldurunuz");
            }

        }

        private void UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private UserLoginResponseDto GetUser(string username, string password)
        {
            SqlConnection conneection = new SqlConnection("server=.\\SQLEXPRESS; database =DbTutorial;integrated security=true");
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conneection;
            command.CommandText = "select * from Users where Username=@username and Password=@password";

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            conneection.Open();
            var reader = command.ExecuteReader();
            command.Parameters.Clear();

            var id = 0;
            string fullname = "";
            UserLoginResponseDto responseDto = null;
            while (reader.Read())
            {
                responseDto = new UserLoginResponseDto();
                responseDto.Id = Convert.ToInt32(reader[0]);
               responseDto.FullName= Convert.ToString(reader[3]);
            }
            reader.Close();
            conneection.Close();
            return responseDto;
        }
    }
}
