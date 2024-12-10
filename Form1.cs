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
        private readonly string ApiKey;
        private const string QuotesApiUrl = "https://api.api-ninjas.com/v1/quotes";
        private const string JokesApiUrl = "https://api.api-ninjas.com/v1/jokes";
        private const string FactsApiUrl = "https://api.api-ninjas.com/v1/facts";
        private const string ChuckNorrisApiUrl = "https://api.api-ninjas.com/v1/chucknorris";
        private const string TriviaApiUrl = "https://api.api-ninjas.com/v1/trivia";
        private const string HobbiesApiUrl = "https://api.api-ninjas.com/v1/hobbies";
        private const string RiddleApiUrl = "https://api.api-ninjas.com/v1/riddles";
        private const string LoremIpsumApiUrl = "https://api.api-ninjas.com/v1/loremipsum";
        private const string DadJokesApiUrl = "https://api.api-ninjas.com/v1/dadjokes";


        public Form1()
        {
            InitializeComponent();

            string envPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");
            Env.Load(envPath);
            ApiKey = Env.GetString("API_KEY");

            if (string.IsNullOrWhiteSpace(ApiKey))
            {
                MessageBox.Show("API Key not found. Please check your .env file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }

        }

        private async void btnFetchQuote_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(QuotesApiUrl);
                    response.EnsureSuccessStatusCode();



                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var quotes = JsonSerializer.Deserialize<Quote[]>(jsonResponse);

                    if (quotes?.Length > 0)
                    {
                        var quote = quotes[0];
                        txtOutput.Text = $"\"{quote.Text}\"\r\n- {quote.Author}";
                    }
                    else
                    {
                        txtOutput.Text = "No quotes found. ";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching quote: " + ex.Message;

                }
            }
        }

        private void btnGetMessage_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "Hello from your local application!";
        }

        public class Quote
        {
            [JsonPropertyName("quote")]
            public string? Text { get; set; }

            [JsonPropertyName("author")]
            public string? Author { get; set; }

            [JsonPropertyName("category")]
            public string? Category { get; set; }
        }

        public class Joke
        {
            [JsonPropertyName("joke")]
            public string? Text { get; set; }
        }

        public class Fact
        {
            [JsonPropertyName("fact")]
            public string? Text { get; set; }
        }

        public class ChuckNorris
        {
            [JsonPropertyName("joke")]
            public string? Text { get; set; }
        }

        public class Trivia
        {
            [JsonPropertyName("category")]
            public string? Category { get; set; }

            [JsonPropertyName("question")]
            public string? Question { get; set; }

            [JsonPropertyName("answer")]
            public string? Answer { get; set; }
        }

        public class Riddle
        {
            [JsonPropertyName("title")]
            public string? Title { get; set; }

            [JsonPropertyName("question")]
            public string? Question { get; set; }

            [JsonPropertyName("answer")]
            public string? Answer { get; set; }
        }

        public class Hobbies
        {
            [JsonPropertyName("hobby")]
            public string? Hobby { get; set; }

            [JsonPropertyName("link")]
            public string? Link { get; set; }

            [JsonPropertyName("category")]
            public string? Category { get; set; }
        }

        public class LoremIpsum
        {
            [JsonPropertyName("text")]
            public string? Text { get; set; }
        }

        public class DadJoke
        {
            [JsonPropertyName("joke")]
            public string? Text { get; set; }
        }



        private async void btnGetJoke_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(JokesApiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var jokes = JsonSerializer.Deserialize<Joke[]>(jsonResponse);

                    if (jokes?.Length > 0)
                    {
                        var joke = jokes[0];
                        txtOutput.Text = joke.Text;
                    }
                    else
                    {
                        txtOutput.Text = "No jokes found.";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching joke: " + ex.Message;
                }
            }
        }

        private async void btnGetFact_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(FactsApiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var facts = JsonSerializer.Deserialize<Fact[]>(jsonResponse);

                    if (facts?.Length > 0)
                    {
                        var fact = facts[0];
                        txtOutput.Text = fact.Text;
                    }
                    else
                    {
                        txtOutput.Text = "No facts found.";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching fact: " + ex.Message;
                }
            }
        }

        private async void btnGetChuckNorris_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(ChuckNorrisApiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var chuckNorrisJoke = JsonSerializer.Deserialize<ChuckNorris>(jsonResponse);

                    if (chuckNorrisJoke != null)
                    {
                        txtOutput.Text = chuckNorrisJoke.Text;
                    }
                    else
                    {
                        txtOutput.Text = "No Chuck Norris joke found.";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching Chuck Norris joke: " + ex.Message;
                }
            }
        }

        private async void btnGetTrivia_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    string triviaUrl = "https://api.api-ninjas.com/v1/trivia";
                    HttpResponseMessage response = await client.GetAsync(triviaUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var triviaItems = JsonSerializer.Deserialize<Trivia[]>(jsonResponse);

                    if (triviaItems?.Length > 0)
                    {
                        var trivia = triviaItems[0];
                        txtOutput.Text = $"Category: {trivia.Category}\n\nQuestion: {trivia.Question}\n\nAnswer: {trivia.Answer}";
                    }
                    else
                    {
                        txtOutput.Text = "No trivia found.";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching trivia: " + ex.Message;
                }
            }
        }


        private async void btnGetHobbies_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(HobbiesApiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var hobby = JsonSerializer.Deserialize<Hobbies>(jsonResponse);

                    if (hobby != null)
                    {
                        txtOutput.Text = $"Hobby: {hobby.Hobby}\nCategory: {hobby.Category}\nLink: {hobby.Link}";
                    }
                    else
                    {
                        txtOutput.Text = "No hobbies found.";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching hobbies: " + ex.Message;
                }
            }
        }

        private async void btnGetRiddle_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(RiddleApiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var riddles = JsonSerializer.Deserialize<Riddle[]>(jsonResponse);

                    if (riddles?.Length > 0)
                    {
                        var riddle = riddles[0];
                        txtOutput.Text = $"Title: {riddle.Title}\n\nQuestion: {riddle.Question}\n\nAnswer: {riddle.Answer}";
                    }
                    else
                    {
                        txtOutput.Text = "No riddles found.";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching riddle: " + ex.Message;
                }
            }
        }

        private async void btnGetLoremIpsum_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(LoremIpsumApiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var loremIpsum = JsonSerializer.Deserialize<LoremIpsum>(jsonResponse);

                    if (loremIpsum != null)
                    {
                        txtOutput.Text = loremIpsum.Text;
                    }
                    else
                    {
                        txtOutput.Text = "No Lorem Ipsum found.";
                    }
                }
                catch (Exception ex)
                {
                    txtOutput.Text = "Error fetching Lorem Ipsum: " + ex.Message;
                }
            }
        }

        private async void btnGetDadJoke_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Api-Key", ApiKey);

                try
                {
                    HttpResponseMessage response = await client.GetAsync(DadJokesApiUrl);
                    response.EnsureSuccessStatusCode();

                    string jsonResponse = await response.Content.ReadAsStringAsync();
                   
                    var dadJokes = JsonSerializer.Deserialize<DadJoke[]>(jsonResponse);

                    if (dadJokes != null && dadJokes.Length > 0)
                    {

                        txtOutput.Text = dadJokes[0].Text;
                    }
                    else
                    {
                        txtOutput.Text = "No Dad joke found.";
                    }
                }
                catch (Exception ex)
                {

                    txtOutput.Text = "Error fetching Dad joke: " + ex.Message;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (System.Drawing.Drawing2D.LinearGradientBrush gradientBrush =
                new System.Drawing.Drawing2D.LinearGradientBrush(
                    this.ClientRectangle,
                    Color.LightSkyBlue, 
                    Color.White,        
                    System.Drawing.Drawing2D.LinearGradientMode.Vertical))
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            }
        }


        private void btnFetchQuote_Enter(object sender, EventArgs e)
        {

        }

        private void btnFetchQuote_Leave(object sender, EventArgs e)
        {

        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                button.BackColor = Color.LightBlue;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
                button.BackColor = SystemColors.Control; 
        }



    }
}

