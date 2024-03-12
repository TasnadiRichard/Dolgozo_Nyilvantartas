using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Dolgozo_NyilvantartasForm
{
    public partial class Form1 : Form
    {
        private readonly HttpClient _httpClient;
        public Form1()
        {
            InitializeComponent();
            _httpClient = new HttpClient();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button_dolgozok_Click(object sender, EventArgs e)
        {
            try
            {
                var response = await _httpClient.GetAsync("https://retoolapi.dev/Kc6xuH/data\r\n"); 
                response.EnsureSuccessStatusCode();
                var responseBody = await response.Content.ReadAsStringAsync();
                var dolgozo = JsonConvert.DeserializeObject<List<Dolgozok>>(responseBody);

                dataGridView_dolgozok.Rows.Clear();
                foreach (var dolgozok in dolgozo)
                {
                    dataGridView_dolgozok.Rows.Add(dolgozok.name, dolgozok.id, dolgozok.salary, dolgozok.position);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Hiba történt a kéréskor: {ex.Message}");
            }

        }

        public class Dolgozok
        {
            public string name { get; set; }
            public int id { get; set; }
            public int salary { get; set; }
            public string position { get; set; }
        }

        private async void button_add_Click(object sender, EventArgs e)
        {

            
        }
    }
}
