using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;



namespace Vote
{
    public partial class Treasurer : Form
    {

        public string treasurer
            { get; set; }

        public Treasurer()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "YSv44ecN1DUdKnvTWf9qn8iMuxcNLScFC5N2emRM",
            BasePath = "https://vbeng-25e59.firebaseio.com/"
        };

        IFirebaseClient client;


        private void Treasurer_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    client = new FireSharp.FirebaseClient(ifc);
                }

                catch
                {
                    MessageBox.Show("No Internet or Connection Problem");
                }
            }
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {

            var Voted = "";

            //Validating Student Condition
            #region Condition

            if (string.IsNullOrWhiteSpace(indexNo.Text))
            {
                string msg = "Simple MessageBox";
                string title1 = "Title";
                MessageBox.Show(msg, title1);
            }

            FirebaseResponse Sname = client.Get("/StudentList/" + indexNo.Text); //Get student Index From Database

            details name = Sname.ResultAs<details>(); //Assign index to Name

            details User = new details()
            {
                IndexNo = indexNo.Text
            };

            if (details.isEqual(name, User)) //If index is correcct you get to choose candidate 
            {

                if (C1.Checked)
                {
                    Voted = "Kofi";
                }
                else if (C2.Checked)
                {
                    Voted = "Ama";

                }
                else if (C3.Checked)
                {
                    Voted = "Esi";

                }
                else if (C4.Checked)
                {
                    Voted = "Yaw";

                }
                else MessageBox.Show("Please Select a Treasurerial Candidate");
            }
            else
            {
                details.ShowError(); // If index is invalid an error Gets thrown from details Class 
            }


            if (Voted != "")
            {

                string message = "You Voted For " + Voted + " As Treasurer?";
                string title = "Confirm Candidate";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;


                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    treasurer = Voted;

                    FirebaseResponse res = client.Set("VotedStudent/" + indexNo.Text + @"/Treasurer", treasurer);
                    this.Hide();

                }

                Sports Sports = new Sports();

                Sports.ShowDialog();
            }


            #endregion

        }
    }
}
