using System;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace api
{
    public class Functions
    {
        private readonly HttpClient client = new HttpClient();

        public async Task<DataTable> GetUsersAsync()
        {
            HttpResponseMessage response = await client.GetAsync("http://localhost/api.php");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Authority Level");

            var users = JArray.Parse(responseBody);
            foreach (var user in users)
            {
                dataTable.Rows.Add(user["id"], user["name"], user["email"], user["level_name"]);
            }

            return dataTable;
        }

        public async Task<JObject> GetUserByIdAsync(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"http://localhost/api.php?id={id}");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var user = JObject.Parse(responseBody);
            return user;
        }

        public async Task<bool> PostUserAsync(string name, string email, int authorityLevelId)
        {
            var values = new JObject
            {
                { "name", name },
                { "email", email },
                { "authority_level_id", authorityLevelId }
            };

            var content = new StringContent(values.ToString(), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("http://localhost/api.php", content);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody.Contains("User added successfully");
        }
    }
}
