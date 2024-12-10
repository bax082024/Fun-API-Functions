using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DotNetEnv;

namespace GUI_API_Formss
{
    public partial class Form1 : Form
    {
        // API Key and Base URL
        private readonly string ApiKey;
        private const string QuotesApiUrl = "https://api.api-ninjas.com/v1/quotes";

        public Form1()
        {
            InitializeComponent();

            // Load API Key from .env
            string envPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
            Env.Load(envPath);
            ApiKey = Env.GetString("API_KEY");

            // Validate API Key
            if (string.IsNullOrWhiteSpace(ApiKey))
            {
                MessageBox.Show("API Key not found. Please check your .env file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        // Fetch a random quote from the API
        private async void btnFetchQuote_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    // Send GET request to the Quotes API
                    HttpResponseMessage response = await client.GetAsync(QuotesApiUrl);
                    response.EnsureSuccessStatusCode();

                    // Deserialize the JSON response
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var quotes = JsonSerializer.Deserialize<Quote[]>(jsonResponse);

                    if (quotes?.Length > 0)
                    {
                        // Display the first quote in the response
                        var quote = quotes[0];
                        txtOutput.Text = $"\"{quote.Text}\"\r\n- {quote.Author}";
                    }
                    else
                    {
                        txtOutput.Text = "No quotes found.";
                    }
                }
                catch (Exception ex)
                {
                    // Handle errors
                    txtOutput.Text = "Error fetching quote: " + ex.Message;
                }
            }
        }

        // Fetch a static message
        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Hello from your local application!";
        }

        // Quote class to map the API response
        public class Quote
        {
            [JsonPropertyName("quote")]
            public string? Text { get; set; }

            [JsonPropertyName("author")]
            public string? Author { get; set; }

            [JsonPropertyName("category")]
            public string? Category { get; set; }
        }
    }
}
