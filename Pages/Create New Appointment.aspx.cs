using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Pages_Create_New_Appointment : System.Web.UI.Page

{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Raghav Gupta\Documents\Appointment.mdf;Integrated Security=True;Connect Timeout=30");
  
    protected void Page_Load(object sender, EventArgs e)
    {
       // String mycon = "Data Source=Hospital.mdf;Integrated Security=True;Connect Timeout=30";

        //SqlConnection con = new SqlConnection(mycon);

        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C: \Users\Raghav Gupta\Documents\Hospital.mdf;Integrated Security=True;Connect Timeout=30");
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into AppointmentTable values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + DropDownList1.SelectedItem + "','" + DropDownList2.SelectedItem + "','" + DropDownList3.SelectedItem + "','" + Calendar1.SelectedDate + "','" + DropDownList4.SelectedItem + "','" + TextBox8.Text + "')";
        cmd.ExecuteNonQuery(); 
       

        con.Close();





    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        
    }
}