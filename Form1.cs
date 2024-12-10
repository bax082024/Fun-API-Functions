using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using DotNetEnv;
using System.Text.Json;
using System.Collections;

namespace GUI_API_Formss
{
    public partial class Form1 : Form
    {
        private const string QuotesApiUrl = "https://api.api-ninjas.com/v1/quotes";
        private readonly string ApiKey;

        public Form1()
        {
            InitializeComponent();

            // Load .env
            Env.Load();
            ApiKey = Env.GetString("API_KEY");

            if (string.IsNullOrWhiteSpace(ApiKey))
            {
                MessageBox.Show("API Key not found. Please check your .env file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private async void btnGetMessage_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiUrl = "http://localhost:5000/api/test/message";
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string message = await response.Content.ReadAsStringAsync();
                        txtOutput.Text = message;
                    }
                    else
                    {
                        txtOutput.Text = "Error: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Exception: " + ex.Message;
                }
            }
        }

        private async void btnFetchQuote_Click(object sender, EventArgs e)
        {
            string category = cmbCategory.SelectedItem?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace (category))
            {
                MessageBox.Show("Please select a category before fetching a quote.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    string requestUrl = $"https://api.api-ninjas.com/v1/quotes?category={category}";
                    HttpResponseMessage response = await client.GetAsync(requestUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var quotes = JsonSerializer.Deserialize<Quote[]>(jsonResponse);

                    if (quotes?.Lenght > 0)
                    {
                        var quote = quotes[0];
                        txtOutput.Text = $"\"{quote.Quote}\"\r\n- {quote.Author}";
                    }
                    else
                    {
                        txtOutput.Text = "No quotes found.";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching quote: " + ex.Message;
                }

            }
        }
    }
}
