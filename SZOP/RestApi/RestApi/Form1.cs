using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;

namespace RestApi
{
    public partial class Form1 : Form
    {
        static Random rnd = new Random();
        String url = "http://localhost/Rest";
        String Route = "index.php?auth=VLNGFW";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest(Route, Method.GET);
            IRestResponse<List<Music>> response = client.Execute<List<Music>>(restRequest);
            if(response.Content.Substring(1,response.Content.Length-2)!= "Wrong connection")
            {
                foreach(Music music in response.Data)
                {
                    listBox1.Items.Add(music.Id + " " + music.Link);
                }
            }
            else MessageBox.Show(response.Content);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest(Route+"&id="+tbID.Text, Method.GET);
            IRestResponse<Music> response = client.Execute<Music>(restRequest);
            if (response.Content.Substring(1, response.Content.Length - 2) != "Wrong connection")
            {
                if (response.Content != "[]")
                {
                    string content = response.Content.Split(',')[2].Split(':')[1].ToString();
                    tbName.Text = content.Substring(1, content.Length - 2);
                }
                else MessageBox.Show("No ID");
            }
            else MessageBox.Show(response.Content);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest(Route, Method.POST);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddBody(new Music
            {
                Link = tbName.Text
            });
            IRestResponse response = client.Execute(restRequest);
            if(response.Content.Substring(1,response.Content.Length-2)== "Wrong connection")
            {
                MessageBox.Show(response.Content);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest(Route + "&id=" + tbID.Text, Method.PUT);
            restRequest.RequestFormat = DataFormat.Json;
            restRequest.AddBody(new Music
            {
                Link = tbName.Text
            });
            IRestResponse response = client.Execute(restRequest);
            if (response.Content.Substring(1, response.Content.Length - 2) == "Wrong connection")
            {
                MessageBox.Show(response.Content);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient(url);
            RestRequest restRequest = new RestRequest(Route + "&id=" + tbID.Text, Method.DELETE);
            IRestResponse response = client.Execute(restRequest);
            if (response.Content.Substring(1, response.Content.Length - 2) == "Wrong connection")
            {
                MessageBox.Show(response.Content);
            }

        }
    }
    public class Music
    {
        public int Id { get; set; }
        public string Link { get; set; }
    }
}

