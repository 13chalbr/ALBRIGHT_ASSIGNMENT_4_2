using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ALBRIGHT_ASSIGNMENT_4_2.Data;
using ALBRIGHT_ASSIGNMENT_4_2.Views;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ALBRIGHT_ASSIGNMENT_4_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataSource.CreateData();
            DataSource.Students.Sort();
            GotoLogon();

            //Design a mini learning management for Teacher Role. Allow the Teacher to login. If the User id is “Teacher”
            //and password “Admin” allow the user to get into the system and open another form. Allow teacher to add student with following fields:
            //Student Id, Student name, GPA. Use any suitable generic list to save students in it. Save the details of the student with highest GPA in a text file.
            //Allow teacher to delete the student. *Write class for Student and include necessary properties in them. ** If you want more properties in Student add them as needed.

            #region Pseudo Code

            //PSEUDO CODE FOR ASSIGNMENT 4_2:

            //COMPONENETS NEEDED: 

            //CONTROLS:

            //1) ADD STUDENT

            //2) DELETE STUDENT

            //3) ...

            //CLASSES:

            // ROLE ENUM (MAYBE EXEMPT SINCE JUST TEACHER?)
            //1) STUDENT CLASS
            // INFO GET/SETS
            // NEW STUDENT CONSTRUCTOR AND METHOD (STORE TO COLLECTION AND WRITE TO TEXT FILE)
            //2) DELETE STUDENT CLASS
            // REMOVE STUDENT FROM COLLECTION METHOD WITH LOOKUP?
            // MODIFY TEXT FILE BY REMOVING STUDENT?
            //3) TEACHER CLASS
            // INFO GET/SETS
            // PASSWORD ROUTINE
            // VERIFY PASSWORD ROUTINE
            //4) MOCKDATA CLASS
            //5) CONTEXT CLASS

            //TEXT FILE REPOSITORY:

            //VIEWS (OR SEPERATE SCREENS)
            //

            #endregion

        }

        public void GotoLogon()
        {
            logonPage.Visibility = Visibility.Visible;
            studentsPage.Visibility = Visibility.Collapsed;
        }

        public void GotoStudentPage()
        {
            logonPage.Visibility = Visibility.Visible;
            StudentsPage.Visibility = Visibility.Collapsed;
        }
        
    }
}