using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Opdracht_3_en_4
{
    public partial class Leeftijd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime vandaag = DateTime.Now;
            DateTime pasen = new DateTime(2017, 4, 16);

            TimeSpan periode = pasen - vandaag;

            litVandaag.Text = DateTime.Now.Date.ToString("dd-MM-yyyy");
            litTijd.Text = DateTime.Now.TimeOfDay.ToString("hh\\:mm\\:ss");

            lblUren.Text = "" + Convert.ToInt32(periode.TotalHours) + " uren";
            lblMin.Text = "" + Convert.ToInt32(periode.TotalMinutes) + " minuten";
            lblSec.Text = "" + Convert.ToInt32(periode.TotalSeconds) + " seconden";
                                                                                                                         
            if(pasen == vandaag)
            {
                lblUren.Text = "Het is vandaag Pasen!";
                lblMin.Text = "";
                lblSec.Text = "";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = kalVerjaardag.SelectedDate.ToString("dd-MM-yyyy");
        }

        protected void btnLeeftijd_Click(object sender, EventArgs e)
        {
            if (kalVerjaardag.SelectedDate == DateTime.MinValue.Date)
                return;

            int age = DateTime.Now.Year - kalVerjaardag.SelectedDate.Year;

            if (DateTime.Now.Month < kalVerjaardag.SelectedDate.Month || (DateTime.Now.Month == kalVerjaardag.SelectedDate.Month && DateTime.Now.Day < kalVerjaardag.SelectedDate.Day))
                age--;

            Label2.Text = "" + age;

            if (DateTime.Now.Month == kalVerjaardag.SelectedDate.Month && DateTime.Now.Day == kalVerjaardag.SelectedDate.Day)
            {
                Label2.Text += ", gefeliciteerd!";
            }
        }
    }
}