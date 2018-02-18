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


namespace AlgebrosZ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            TeamData teamdata= new TeamData();
            teamdata.Teamname = tmName.Text;
            teamdata.Password = pswd.Text;
            Member clan1 = new Member(), clan2 = new Member(), clan3 = new Member(), clan4 = new Member();

            clan1.name = name1.Text;
            clan1.surname = surname1.Text;
            clan1.mail = email1.Text;
            teamdata.Members.Add(clan1);

            clan2.name = name2.Text;
            clan2.surname = surname2.Text;
            clan2.mail = email2.Text;
            teamdata.Members.Add(clan2);

            clan3.name = name3.Text;
            clan3.surname = surname3.Text;
            clan3.mail = email3.Text;
            teamdata.Members.Add(clan3);

            clan4.name = name4.Text;
            clan4.surname = surname4.Text;
            clan4.mail = email4.Text;
            teamdata.Members.Add(clan4);

            string json = new JavaScriptSerializer().Serialize(teamdata);
            HttpWebRequest req;
            if (cro.Checked == true)
            {
                req = (HttpWebRequest)WebRequest.Create("http://52.233.158.172/change/api/hr/account/register/");
            }
            else
            {
                req = (HttpWebRequest)WebRequest.Create("http://52.233.158.172/change/api/en/account/register/");
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
            Next slijedeci = JsonConvert.DeserializeObject<Next>(rezultat.Result);
            Slijedeci nextTask = new Slijedeci(slijedeci.NextApi);

        }
    }
}
public class Member
{
    public string name;
    public string surname;
    public string mail;
}
public class TeamData
{
    public string Teamname;
    public string Password;
    public List<Member> Members;

    public TeamData()
    {
        this.Members = new List<Member>();
    }
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

public class Next
{
    public List<string> Errors;
    public string NextApi;

    public Next()
    {
        this.Errors = new List<string>();
    }
}
