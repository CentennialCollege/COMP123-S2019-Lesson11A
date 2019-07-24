using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson11A
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static MainForm mainform;
        public static AboutForm aboutForm;
        public static StudentInfoForm studentInfoForm;

        public static Student student;
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashForm = new SplashForm();
            mainform = new MainForm();
            aboutForm = new AboutForm();
            studentInfoForm = new StudentInfoForm();

            student = new Student();

            Application.Run(splashForm);
        }
    }
}
