using MVP_Task.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Task
{
    public partial class MainView : Form,IMainView
    {
        public MainView()
        {
            InitializeComponent();
        }

        public EventHandler<EventArgs> ClickButton { get; set; }
        public string NameText { get => nametxtb.Text; set => nametxtb.Text = value; }
        public string SurnameText { get => surnametxtb.Text; set => surnametxtb.Text = value; }

        private void MainView_Load(object sender, EventArgs e)
        {

        }

        private void nametxtb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickButton.Invoke(sender, e);
        }
    }
}
