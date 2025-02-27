using System.Data;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace ProductDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=.;Initial Catalog=armstrong;Integrated Security=True;TrustServerCertificate=True";
            con = new SqlConnection(conString);
            cmd = new SqlCommand("Select * from Product", con);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds);
            MessageBox.Show("Data loaded");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = ds.Tables[0].TableName;
        }

        //show product name
        private void button3_Click(object sender, EventArgs e)
        {
            DataRow? dr = ds.Tables[0].Rows.Find(textBox1.Text);
            if (dr != null)
            {
                label2.Text = dr[1].ToString();
            }
            else
            {
                label2.Text = "Not Present";
            }

            textBox1.Clear();
            textBox1.Focus();
        }

        //delete product
        private void button4_Click(object sender, EventArgs e)
        {
            DataRow? dr = ds.Tables[0].Rows.Find(textBox2.Text);
            if (dr != null)
            {
                dr.Delete();
                MessageBox.Show("Product deleted");
                textBox2.Clear();
            }
        }

        DataRow? dr = null;
        private void textBox3_Leave(object sender, EventArgs e)
        {

            dr = ds.Tables[0].Rows.Find(textBox3.Text);
            textBox4.Text = dr[1].ToString();
            textBox5.Text = dr[2].ToString();
            textBox6.Text = dr[3].ToString();

        }


        //update product
        private void button5_Click(object sender, EventArgs e)
        {
            dr[1] = textBox4.Text;
            dr[2] = textBox5.Text;
            dr[3] = textBox6.Text;
        }


        //add product
        private void button6_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables[0].NewRow();

            dr[1] = textBox9.Text;
            dr[2] = textBox8.Text;
            dr[3] = textBox7.Text;

            ds.Tables[0].Rows.Add(dr);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds);

            MessageBox.Show("Database Updated succesfully..");

        }
    }
}
