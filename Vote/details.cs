using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote
{
    class details
    {
        public string President { get; set; }
        public string Status { get; set; }
        public string IndexNo { get; set; }


         private static string error = "Invalid Index Number!";

         private static string IndexVoted = "Student Has Already Voted!";

         public static void ShowError()
         {
             System.Windows.Forms.MessageBox.Show(error);
         }

         public static void VoterError()
         {
             System.Windows.Forms.MessageBox.Show(error);
         }



          public static bool isEqual(details invalid1, details invalid2)
          {
              if (invalid1 == null || invalid2 == null) { return false; }

              if (invalid1.IndexNo != invalid2.IndexNo)
              { 
                       error = "Username does not exist!";
              return false;
              }
                return true;
              }



          public static bool validateVoter(details voted1, details voted2)
          {
              if (voted1.Status == "Voted")
              {
                  IndexVoted = "Student Has Already Voted!";
                  return false;
              }
              else if (voted1 == null || voted2 == null) 

              {
                  details voted = new details()
                  {
                      Status = "Voted"
                  };
                  return false;
              }
              return true;
          }

  
    }

    }

