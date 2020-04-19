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
    public partial class President : Form
    {

        public string president 
        { get; set; }


        public string indexno
          { get; set; }
       


        public President()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "YSv44ecN1DUdKnvTWf9qn8iMuxcNLScFC5N2emRM",
            BasePath = "https://vbeng-25e59.firebaseio.com/"
        };

        IFirebaseClient client;



        private void President_Load(object sender, EventArgs e)
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
                //Check if Student has voted
          FirebaseResponse Ivoter = client.Get(@"/StudentList/" + indexNo.Text + "/Status" ); //Get student Vote status From Database
                 
            var status = Ivoter.ResultAs<string>(); //Assign index to Name

            if (status == "Voted") 
            {
                MessageBox.Show("You Have Already Voted!");
                this.Close();
            }
               else if (status == null)

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
                else MessageBox.Show("Please Select a Presidential Candidate");
            }
            else
            {
                details.ShowError(); // If index is invalid an error Gets thrown from details Class 
            }
         

            #endregion


            //Validating if student has Voted or not from Database

                if (Voted != "")
                {

                    string message = "You Voted For " + Voted + " As President?";
                    string title = "Confirm Candidate";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;


                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {

                        president = Voted;

                        FirebaseResponse res = client.Set("VotedStudent/" + indexNo.Text + @"/President", president);
                        this.Hide();


                    }
                    secretary secretary = new secretary();


                    secretary.ShowDialog();

                                     
                        }
          


        }

  

    }
}
