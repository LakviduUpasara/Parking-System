using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DBconnection con = new DBconnection();


        string TokenNo;
        string VhicleNumber;
        string NIcNumber;
        string VehicleType;
        string gate;
        int price = 0;
        void Varible()
        {
             TokenNo = textToken.Text;
             VhicleNumber = textNumberPlae.Text;
             NIcNumber = TextNic.Text;
             VehicleType = vehicleTypecom.Text;
             gate  = Comgate.Text;
             

            if (VehicleType == "Moter Cycle")
            {
                price = 50;
                MessageBox.Show(price.ToString());
            }
            else if (VehicleType == "Three Wheel ")
            {
                price = 100;
            }
            else if (VehicleType == "Other")
            {
                price = 250;
            }

            

        }

        int[] count;
        int[] fines ;
        void finans ()
        {



        }

        void cler()
        {
            textToken.Text = " ";
            textNumberPlae.Text = " ";
            TextNic.Text = " ";
            vehicleTypecom.Text = " ";
            Comgate.Text = " ";
        }

        void loaddetail()
        {
            string sql = " SELECT * FROM Vehicle_OwerDetail ORDER BY TokenId DESC ";
            DataTable dt = con.search(sql);
           // dataGridView1.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

            }else 
            {
                MessageBox.Show("Fail Data Show");
            }


        }

        private void Serctext_MouseClick(object sender, MouseEventArgs e)
        {
            Serctext.Clear();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            loaddetail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            if (String.IsNullOrWhiteSpace(textToken.Text) || (String.IsNullOrWhiteSpace(textNumberPlae.Text)) || (String.IsNullOrWhiteSpace(vehicleTypecom.Text)))
            {
                MessageBox.Show("Some Thing Is Emty");
            }
            else
            {
                Varible();

                string sql = $"INSERT INTO  Vehicle_OwerDetail VALUES ( '{TokenNo}', '{VhicleNumber}','{NIcNumber}', '{VehicleType}','{gate}' )";
                bool result = con.exuxquary(sql);
                if (result)
                {
                    MessageBox.Show("Saved");
                    loaddetail();
                    cler();


                }else 
                {

                    MessageBox.Show("Fail");
                }

            }
        }

        private void btnCler_Click(object sender, EventArgs e)
        {
            cler(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrWhiteSpace(textToken.Text) || (String.IsNullOrWhiteSpace(textNumberPlae.Text)) || (String.IsNullOrWhiteSpace(vehicleTypecom.Text)))
            {
                MessageBox.Show("Some Thing Is Emty");
            }
            else
            {
                Varible();

                string sql = $"UPDATE  Vehicle_OwerDetail SET  Vehicle_Number ='{VhicleNumber}',Nic_Number ='{NIcNumber}', Vehicle_Type = '{VehicleType}', GetePass = '{gate}'  WHERE  TokenId ='{TokenNo}' ";
                bool result = con.exuxquary(sql);
                if (result)
                {
                    MessageBox.Show("Update");
                    cler();
                    loaddetail();


                }
                else
                {

                    MessageBox.Show("Fail");
                }

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            Varible() ;
            String sql = $"DELETE FROM Vehicle_OwerDetail WHERE  TokenId ='{TokenNo}'";
            bool result = con.exuxquary(sql);
            if (result)
            {
                MessageBox.Show("DELETE");
                cler();
                loaddetail();


            }
            else
            {

                MessageBox.Show("Fail");
                
            }

        }

        private void Searshbtn_Click(object sender, EventArgs e)
        {
            string serch = Serctext.Text;
            string sql = $"SELECT * FROM Vehicle_OwerDetail WHERE TokenId  LIKE '%{serch}%' OR Vehicle_Number LIKE'%{serch}%' OR Nic_Number LIKE '%{serch}%' OR Vehicle_Type LIKE '%{serch}%' OR GetePass LIKE '{gate}' ";
            DataTable dt = con.search(sql);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

                /*textToken.Text = dt.Rows[0][0].ToString();
                textNumberPlae.Text = dt.Rows[0][1].ToString();
                TextNic.Text = dt.Rows[0][2].ToString();
                vehicleTypecom.Text = dt.Rows[0][3].ToString();
                Comgate.Text = dt.Rows[0][5].ToString(); */
            } 
            else
            {
                MessageBox.Show("Serching Erro");
            }

        }

        private void Refechbtn_Click(object sender, EventArgs e)
        {
            loaddetail();
            cler();
            Serctext.Text="" ;
        }

        private void btnfill_Click(object sender, EventArgs e)
        {
            string serch = textToken.Text;
            string sql = $"SELECT * FROM Vehicle_OwerDetail WHERE TokenId  = '{serch}' ";
            DataTable dt = con.search(sql);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;

                textToken.Text = dt.Rows[0][0].ToString();
                textNumberPlae.Text = dt.Rows[0][1].ToString();
                TextNic.Text = dt.Rows[0][2].ToString();
                vehicleTypecom.Text = dt.Rows[0][3].ToString();
                Comgate.Text = dt.Rows[0][ 4].ToString();
            }
            else
            {
                MessageBox.Show("Serching Erro");
            }
        }

        private void textToken_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down )
            {
                textNumberPlae.Focus();
            }
        }

        private void TextNic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                vehicleTypecom.Focus();
            }
        }

        private void textNumberPlae_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                TextNic.Focus();    
            }
        }

        private void vehicleTypecom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Comgate .Focus();
            }
        }

        private void textToken_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Escape)
            {
                btnfill.Focus();
            }
        }

        private void textNumberPlae_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Escape)
            {
                textToken.Focus();
            }
        }

        private void TextNic_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Escape)
            {
                textNumberPlae.Focus();
            }
        }

        private void Comgate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void textToken_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void btnSave_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                textToken.Focus(); 
            }

           
        }

        private void Comgate_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                vehicleTypecom.Focus();
            }
        }

        private void vehicleTypecom_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                TextNic.Focus();
            }
        }

        private void btnCler_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Up)
            {
                btnSave.Focus();
            } 
        }
    }
}

