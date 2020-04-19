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



namespace login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "YSv44ecN1DUdKnvTWf9qn8iMuxcNLScFC5N2emRM",
            BasePath = "https://vbeng-25e59.firebaseio.com/"
        };

        IFirebaseClient client;

        private void LoginForm_Load(object sender, EventArgs e)
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

 
        private void LGbtn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(index.Text) &&
               string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            #endregion

            FirebaseResponse res = client.Get(@"StudentList/" + index.Text);
            User ResUser = res.ResultAs<User>();// database result

            User CurUser = new User() // USER GIVEN INFO
            { 
                IndexNo = index.Text,
                Password = password.Text
            };

            if (User.IsEqual(ResUser, CurUser))
            {
                MessageBox.Show("Welcome");

            }

            else
            {
                User.ShowError();
            }
        }
    }
}