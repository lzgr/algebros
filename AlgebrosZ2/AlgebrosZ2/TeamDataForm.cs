using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgebrosZ2
{
    public partial class TeamDataForm : Form
    {
        public TeamDataForm(TeamData tim, string Token, string Id)
        {
            InitializeComponent();

            tName.Text += tim.TeamName;
            tID.Text += tim.Id;

            name1.Text += tim.Members[0].Name;
            surname1.Text += tim.Members[0].Surname;
            mail1.Text += tim.Members[0].Mail;

            name2.Text += tim.Members[1].Name;
            surname2.Text += tim.Members[1].Surname;
            mail2.Text += tim.Members[1].Mail;

            name3.Text += tim.Members[2].Name;
            surname3.Text += tim.Members[2].Surname;
            mail3.Text += tim.Members[2].Mail;

            name4.Text += tim.Members[3].Name;
            surname4.Text += tim.Members[3].Surname;
            mail4.Text += tim.Members[3].Mail;

            nxtAPI.Text += tim.NextApi;

            sendBtn.Click += (sender, EventArgs) => { sendBtn_Click(sender, EventArgs, Token, Id); };

        }

        private void sendBtn_Click(object sender, EventArgs e, string Token, string Id)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://52.233.158.172/change/api/hr/team/confirm?id=" + Id + "&repository=" + gHubTB + ")");
            req.Method = "GET";
            req.Headers["X-Authorization"] = "Basic " + Token;
            var odgovor = (HttpWebResponse)req.GetResponse();
            var odgString = new StreamReader(odgovor.GetResponseStream()).ReadToEnd();
            MessageBox.Show("Done", "Team data form", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

