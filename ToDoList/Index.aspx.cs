using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;


namespace ToDoList
{
    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                Calendar1.Visible = false;
                Display();
            }
        }
        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            if (Calendar1.Visible == true)
            { Calendar1.Visible = false; }
            else { Calendar1.Visible = true; }
        }

        protected void SelectedEvent(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToString("d");
            Calendar1.Visible = false;
        }
        protected void Display()
        {
            string CString = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CString))
            {
                SqlCommand cmd = new SqlCommand("select date = (Convert(varchar(101),date,106)), list from list where date= Convert(date,GetDate());", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                string label = ""; string para= "";
                while (reader.Read())
                {
                   label = reader["date"].ToString();
                   para += "<br />" + reader["list"].ToString();

                }
                heading.InnerText = label;
                paragraph.InnerHtml = para;
                    /**
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "list");
                this.paragraph.InnerText = ds.Tables["list"].Rows[0]["date"].ToString();
                this.paragraph.InnerText = ds.Tables["list"].Rows[0]["list"].ToString();
                //  GridView1.DataSource = cmd.ExecuteReader();
                // GridView1.DataBind();
                **/
            }

          }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            try
            {
                string NewLineStr = TextBox2.Text.Replace("\r\n", "<br />");
                string CString = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CString))
                {
                    SqlCommand cmd = new SqlCommand("Insert into list (date, list) values ('"+TextBox1.Text+"','"+NewLineStr+"');",con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                Label1.Visible = true;
                Label1.Text = "Successfully Inserted!";
                Display();
            }
            catch (SqlException ex)
            {

                Label1.Text = ex.ToString();            
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            Label1.Text = "";
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            heading.InnerHtml = "";
            paragraph.InnerHtml = "";
            string CString = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CString))
            {
                SqlCommand cmd = new SqlCommand("select date = (Convert(varchar(101),date,106)), list from list where date ='" + TextBox1.Text+"';", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    heading.InnerHtml = reader["date"].ToString();
                    paragraph.InnerHtml += "<br />" + reader["list"].ToString();                    
                }
                // GridView1.DataSource = cmd.ExecuteReader();
                //GridView1.DataBind();
           }
        }
    }
}