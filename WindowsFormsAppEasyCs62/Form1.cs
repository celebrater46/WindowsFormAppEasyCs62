using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEasyCs62
{
    public partial class Form1 : Form
    {
        private Label label;
        private Button button;

        public void Display()
        {
            Application.Run(new Form1());
        }
        public Form1()
        {
            InitializeComponent();
            this.Text = "Sample";
            this.Width = 250;
            this.Height = 100;

            label = new Label();
            label.Text = "Welcome!";
            label.Width = 150;
            button = new Button();
            button.Text = "Buy";
            button.Top = this.Top + label.Height;
            button.Width = label.Width;
            
            button.Parent = this;
            label.Parent = this;

            button.Click += new EventHandler(ClickButton);
        }

        public void ClickButton(Object sender, EventArgs e)
        {
            label.Text = "Thank You.";
        }
    }
}