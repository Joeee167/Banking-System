using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_project
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //LoginScreen loginScreen = new LoginScreen();
            Application.Run(new LoginScreen());

            //LinkedList<Person> list = new LinkedList<Person>();
            //list.AddLast(new Admin());
            //list.AddLast(new Employee());
            //list.AddLast(new Client());


            //foreach (Person person in list)
            //{
            //    Person.Login(loginScreen,loginScreen.username,loginScreen.password);
            //}
        }
    }
}
