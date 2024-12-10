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

namespace GUI_API_Formss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGetMessage_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // API URL
                    string apiUrl = "http://localhost:5000/api/test/message";

                    // Send GET request
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    // Ensure success
                    if (response.IsSuccessStatusCode)
                    {
                        string message = await response.Content.ReadAsStringAsync();
                        lblMessage.Text = message; // Display the message
                    }
                    else
                    {
                        lblMessage.Text = "Error: " + response.StatusCode;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Exception: " + ex.Message;
                }
            }
        }
    }
}
