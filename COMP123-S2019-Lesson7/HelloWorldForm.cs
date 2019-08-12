using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson7
{
    public partial class HelloWorldForm : Form
    {
        //<summary>
        // This is the constructor for the HelloWorldForm
        //<summary>
        public HelloWorldForm()
        {
            InitializeComponent();
            Start();
        }
        /// <summary>
        ///  This method initializes Form and Control properties
        /// </summary>
        public void Start()
        {
            HelloWorldLabel.Text = "Hello, Minyoung!";
            HelloWorldLabel.BackColor = Color.Black;
            HelloWorldLabel.ForeColor = Color.White;

            generateRandomNumber();
        }

        /// <summary>
        /// This method is an event handler for the ClickMeButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickMeButton_Click(object sender, EventArgs e)
        {
            // use the ternary operator
            HelloWorldLabel.Text = (HelloWorldLabel.Text == "Clicked!") ? "Unclicked!" : "Clicked!";

            //if(HelloWorldLabel.Text == "Clicked!")
            //{
            //    HelloWorldLabel.Text = "Unclicked!";
            //}
            //else
            //{
            //    HelloWorldLabel.Text = "Clicked!";
            //} 

            generateRandomNumber();
        }
        /// <summary>
        /// This method generates a random number between 1 and 49
        /// </summary>

        private void generateRandomNumber()
        {
            int randomNumber = new Random().Next(1, 49) + 1;
            RandomNumberLabel.Text = randomNumber.ToString();

            //RandomNumberLabel.Text = (new Random().Next(1, 49) + 1).ToString();
        }
    }
}
