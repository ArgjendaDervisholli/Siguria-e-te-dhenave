using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;



namespace Parulla_OneTimePad
{
    public partial class Form1 : Form
    {
        bool indikatori = false;
        string connectionstring = ("Server=.;Database=Projekti1;Integrated Security = True;");
          
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void btnKerko_Click(object sender, EventArgs e)
        {
            SqlConnection connection1 = new SqlConnection(connectionstring);
            string query = "Select * from Parullat";
            
            SqlDataAdapter adapteri = new SqlDataAdapter(query, connection1);
            connection1.Open();
            DataSet ds1 = new DataSet();
            adapteri.Fill(ds1);
            dgvparullat.DataSource = ds1.Tables[0].DefaultView;
            connection1.Close();

        }//po

        private void btnShto_Click(object sender, EventArgs e)
        {
           
            SqlConnection connectioni = new SqlConnection(connectionstring);
            OTP onetimepad = new OTP();

            string sparulla = rtbparullat.Text;
            string qelesi = onetimepad.GjeneroCelesin(sparulla.Length);

            StringBuilder plaintekst = new StringBuilder(sparulla);
            StringBuilder celesi = new StringBuilder(qelesi);
            StringBuilder cipher = onetimepad.Enkriptimi(plaintekst, celesi);

            string cipher_tekst = cipher.ToString();
            cipher_tekst.Replace(" ","");
          
            //string _query = "INSERT INTO Parullat(Nr,parullatt) VALUES('" +""+ txtnr.Text+ "," + cipher_tekst + "" + "');";
                
            connectioni.Open();
            
           SqlCommand komanda = new SqlCommand("InsertoParullat",connectioni);
            komanda.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@Nr", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = Convert.ToInt32(txtnr.Text);
            komanda.Parameters.Add(param);

            param = new SqlParameter("@Parulla", SqlDbType.NVarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = cipher_tekst;
            komanda.Parameters.Add(param);

            try { 
                 komanda.ExecuteNonQuery();
             }
            catch(SqlException ex) {
                string message = ex.Message;
            connectioni.Close();
                 }
        }

        private void btnShfaqParullen_Click(object sender, EventArgs e)
        {
            SqlConnection connectioni = new SqlConnection(connectionstring);
            OTP padi = new OTP();
            // string query_cipheri = " SELECT Parulla " + "FROM Parullat  "+
            //  " WHERE Nr='" + txtnr.Text + "'";
            DataTable dt = new DataTable();
          
            SqlCommand Komanda = new SqlCommand("ListaEParullave", connectioni);
            Komanda.CommandType = CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter("@ID", SqlDbType.Int);
            param.Direction = ParameterDirection.Input;
            param.Value = Convert.ToInt32(txtnr.Text);
            Komanda.Parameters.Add(param);
            SqlDataAdapter adapter = new SqlDataAdapter(Komanda);
            string ciphertext = "";
            string key = "";
            try {
                connectioni.Open();
                adapter.Fill(dt);

                dgvparullat.DataSource = dt;
            }
            catch(SqlException ex) {
                string message = ex.Message;
                connectioni.Close(); }
            

            StringBuilder Ciphertexti = new StringBuilder(ciphertext);
            StringBuilder Key = new StringBuilder(key);
            StringBuilder Plaintexti = padi.Enkriptimi(Ciphertexti, Key);

            rtbparullat.Text = Plaintexti.ToString();
            btnFshij.Visible = true;
           
            indikatori = false;
        }
        

        private void rtbparullat_TextChanged(object sender, EventArgs e)
        {
            indikatori = true;
        }

        

        private void btnFshij_Click(object sender, EventArgs e)
        {
            SqlConnection connectioni = new SqlConnection(connectionstring);

            string query = " DELETE FROM parullat WHERE Nr= " + Convert.ToInt32(txtnr.Text);


            SqlCommand Komanda = new SqlCommand(query, connectioni);
            connectioni.Open();
            Komanda.ExecuteNonQuery();
            connectioni.Close();
        }
    }
}

