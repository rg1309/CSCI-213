using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class Work_CreateNewAppointment : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Vishal Ranjan\Documents\Appoint.mdf;Integrated Security=True;Connect Timeout=30");
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandText = "select * from AppointmentTable where Contact=764117";
        cmd.ExecuteNonQuery();

        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            if (!reader.HasRows)
            {
                reader.Close();
                cmd.CommandText = "insert into AppointmentTable values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox8.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + DropDownList2.SelectedItem + "','" + DropDownList6.SelectedItem + "','" + DropDownList5.SelectedItem + "','" + Calendar1.SelectedDate + "','" + DropDownList5.SelectedItem + "','" + TextBox7.Text + "')";
                cmd.ExecuteNonQuery();

            }
        }


        cmd.CommandType = CommandType.Text;
            
       
        
        con.Close();
       


    }

  
}