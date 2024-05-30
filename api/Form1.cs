using System;
using System.Data;
using System.Windows.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace api
{
    public partial class Form1 : Form
    {
        private readonly Functions functions = new Functions();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optionally, load all users when the form loads
            // await GetAllUsers();
        }

        private async void buttonGetAllUsers_Click(object sender, EventArgs e)
        {
            await GetAllUsers();
        }

        private async void buttonGetUserById_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(textBoxUserId.Text, out id))
            {
                await GetUserById(id);
            }
            else
            {
                MessageBox.Show("Please enter a valid user ID.");
            }
        }

        private async void buttonAddUser_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            int authorityLevelId;

            if (int.TryParse(textBoxAuthorityLevelId.Text, out authorityLevelId))
            {
                await AddUser(name, email, authorityLevelId);
            }
            else
            {
                MessageBox.Show("Please enter a valid authority level ID.");
            }
        }

        private async Task GetAllUsers()
        {
            var users = await functions.GetUsersAsync();
            dataGridViewUsers.DataSource = users;
        }

        private async Task GetUserById(int id)
        {
            var user = await functions.GetUserByIdAsync(id);
            if (user != null)
            {
                MessageBox.Show($"ID: {user["id"]}\nName: {user["name"]}\nEmail: {user["email"]}\nAuthority Level: {user["level_name"]}");
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private async Task AddUser(string name, string email, int authorityLevelId)
        {
            var result = await functions.PostUserAsync(name, email, authorityLevelId);
            MessageBox.Show(result ? "User added successfully." : "Failed to add user.");
            await GetAllUsers(); // Refresh the user list after adding a new user
        }
    }
}
