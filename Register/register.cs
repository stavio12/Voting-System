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

namespace Register
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
             AuthSecret = "YSv44ecN1DUdKnvTWf9qn8iMuxcNLScFC5N2emRM",
             BasePath = "https://vbeng-25e59.firebaseio.com/"
        };

        IFirebaseClient client;
        private void register_Load(object sender, EventArgs e)
        {
            
                try
                {
                    client = new FireSharp.FirebaseClient(ifc);
                }

                catch
                {
                    MessageBox.Show("No Internet Or Connection Problem");
                }
            }

        private void Button1_Click(object sender, EventArgs e)
        {
                  #region Condition
            if (string.IsNullOrWhiteSpace(Fullname.Text) &&
               string.IsNullOrWhiteSpace(Session.Text) &&
               string.IsNullOrWhiteSpace(IndexNO.Text) &&
               string.IsNullOrWhiteSpace(Email.Text) &&
               string.IsNullOrWhiteSpace(Password.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            #endregion    



            user user = new user()
            {
                Fullname = Fullname.Text,
                Email = Email.Text,
                IndexNo = IndexNO.Text,
                Password = Password.Text,
                Session = Session.Text
            };
            
           
            SetResponse set = client.Set(@"StudentList/" + IndexNO.Text, user);


            FirebaseResponse res = client.Get(@"Count");
            int Count = int.Parse(res.ResultAs<string>());

            var set1 = client.Set(@"Count", ++Count);


            MessageBox.Show("Welcome To GTUC " + Fullname.Text);
            this.Close();
         
        }

        }
    }

