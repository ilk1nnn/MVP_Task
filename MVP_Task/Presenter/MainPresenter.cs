using MVP_Task.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP_Task.Presenter
{
    public class MainPresenter
    {

        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.ClickButton += ViewClickButton;

        }

        private void ViewClickButton(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog() == DialogResult.OK)
            {
                using(StreamWriter writer = new StreamWriter(save.FileName))
                {

                    writer.Write(_view.NameText+" " + _view.SurnameText + " " + DateTime.Now.ToString());

                }
            }
        }
    }
}
