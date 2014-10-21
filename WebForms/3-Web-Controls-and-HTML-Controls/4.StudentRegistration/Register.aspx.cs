using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _4.StudentRegistration
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumbit_Click(object sender, EventArgs e)
        {
            var firstName = new HtmlGenericControl("p");
            firstName.InnerText = "Firstname: " + this.tbFirstname.Text;
            var lastName = new HtmlGenericControl("p");
            lastName.InnerText = "Lastname: " + this.tbLastname.Text;
            var facultyNumber = new HtmlGenericControl("p");
            facultyNumber.InnerText = "Faculty Number: " + this.tbFacultyNumber.Text;
            var university = new HtmlGenericControl("p");
            university.InnerText = "University: " + this.ddlUniversities.SelectedValue;

            var container = new HtmlGenericControl("div");

            container.Controls.Add(firstName);
            container.Controls.Add(lastName);
            container.Controls.Add(facultyNumber);
            container.Controls.Add(university);

            var specialtyIndexes = this.lbSpecialty.GetSelectedIndices();
            var specialtyNames = new List<string>();

            foreach (var index in specialtyIndexes)
            {
                specialtyNames.Add(this.lbSpecialty.Items[index].Text);
            }

            var specialties = new HtmlGenericControl("p");
            specialties.InnerText = "Specialty: " + string.Join(", ", specialtyNames);
            container.Controls.Add(specialties);

            this.phDetails.Controls.Add(container);
        }
    }
}