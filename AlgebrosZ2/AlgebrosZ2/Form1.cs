using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AlgebrosZ2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getTokButton_Click(object sender, EventArgs e)
        {
            LoginData login = new LoginData();
            login.Teamname = teamNameTB.Text;
            login.Password = passTB.Text;
            string json = new JavaScriptSerializer().Serialize(login);
            HttpWebRequest req;
            if (cro.Checked == true)
            {
                req = (HttpWebRequest)WebRequest.Create("http://52.233.158.172/change/api/hr/account/login");
            }
            else
            {
                req = (HttpWebRequest)WebRequest.Create("http://52.233.158.172/change/api/en/account/login");
            }
            req.ContentType = "application/json";
            req.Method = "POST";

            using (var streamWrite = new StreamWriter(req.GetRequestStream()))
            {
                streamWrite.Write(json);
            }

            var odg = (HttpWebResponse)req.GetResponse();
            string result;
            using (var streamReader = new StreamReader(odg.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            Rezultat rezultat = JsonConvert.DeserializeObject<Rezultat>(result);
            Logindata podaci = JsonConvert.DeserializeObject<Logindata>(rezultat.Result);

            HttpWebRequest req2 = (HttpWebRequest)WebRequest.Create("http://52.233.158.172/change/api/hr/team/details/" + podaci.TeamId.ToString());
            req2.Method = "GET";
            req2.Headers["X-Authorization"] = "Basic " + podaci.AuthorizationToken;
            var odgovor = (HttpWebResponse)req2.GetResponse();
            var odgString = new StreamReader(odgovor.GetResponseStream()).ReadToEnd();

            Rezultat rezultat2 = JsonConvert.DeserializeObject<Rezultat>(odgString);
            TeamData tim = JsonConvert.DeserializeObject<TeamData>(rezultat2.Result);

            TeamDataForm teamPodaci = new TeamDataForm(tim);
            this.Hide();
            teamPodaci.ShowDialog();
            Application.Exit();

        }
    }
}
public class LoginData
{
    public string Teamname;
    public string Password;
}

public class Rezultat
{
    public List<string> Errors;
    public string Result;

    public Rezultat()
    {
        this.Errors = new List<string>();
    }
}

public class Logindata
{
    public int TeamId;
    public string TeamName;
    public string Password;
    public string AuthorizationToken;
    public string NextApi;
    public List<string> Errors;
    public Logindata()
    {
        this.Errors = new List<string>();
    }
}

public class Members
{
    public int Id;
    public string Name;
    public string Surname;
    public string Mail;
    public string NextApi;
    public List<string> Errors;

    public Members()
    {
        this.Errors = new List<string>();
    }
}
public class TeamData
{
    public string Id;
    public string TeamName;
    public string Password;
    public List<Members> Members;
    public string NextApi;
    public List<string> Errors;

    public TeamData()
    {
        this.Errors = new List<string>();
    }
}