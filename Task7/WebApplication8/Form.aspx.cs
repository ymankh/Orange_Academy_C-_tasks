using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void NameText_TextChanged(object sender, EventArgs e)
        {
            string id = IDTextBox.Text;
            string name = NameText.Text;
            string email = EmailTextBox.Text;
            List<string> languages = new List<string>();
            if (CheckBox1.Checked)
                languages.Add("C++");
            if (CheckBox2.Checked)
                languages.Add("C#");
            if (CheckBox3.Checked)
                languages.Add("C");
            string gender = "";
            if (Gender.SelectedItem.Selected)
                gender = Gender.SelectedItem.Text;
            string description = TextArea1.Value;


            Label8.Text = $"Name: {name}";
            Label10.Text = $"ID: {id}\n";
            Label11.Text = $"Email: {email} \n";
            Label12.Text = $"Langages: {string.Join(", ", languages)} ";
            Label13.Text = $"gender: {gender}";
            Label14.Text = $"description: {description}";

        }
    }
}