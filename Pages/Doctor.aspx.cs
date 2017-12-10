using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Pages_Doctor : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["HospitalConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
      
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        //con.Open();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = System.Data.CommandType.Text;
        //cmd.CommandText = "select * from PatientTable";
        //cmd.ExecuteNonQuery();
        //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //PatientTable dt = new PatientTable();
        //da.Fill(dt);
        //GridView2.DataSource = dt;
        //GridView2.DataBind();
        //con.Close(); 
         



        //SqlCommand cmd = new SqlCommand("SELECT [PatientId],[PName],[PAddress],[PCity],[PState] ,[PContact],[PUserName] FROM [dbo].[PatientTable] where PatientId=("+txtpatient.Text.ToString()+"");
        //cmd.CommandType = System.Data.CommandType.Text;
        //cmd.Connection = con;

        //string temp = "";
        

        //SqlDataReader reader = cmd.ExecuteReader();
        //while(reader.Read())
        //{
        //    temp += reader["PatientId"].ToString();
        //    temp += reader["PName"].ToString();
        //    temp += reader["PAddress"].ToString();
        //    temp += reader["PCity"].ToString();
        //    temp += reader["PState"].ToString();
        //    temp += reader["PContact"].ToString();
        //    temp += reader["PUserName"].ToString();

        //}
        ////GridView1.DataBind();
        // //TextBox1.Text = ToString(select * from PatientTable where txtpatient.Text);
        con.Close();
        //TextBox1.Text = temp;
       

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}