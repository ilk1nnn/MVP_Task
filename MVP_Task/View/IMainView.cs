using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Task.View
{
    public interface IMainView
    {

        EventHandler<EventArgs> ClickButton { get; set; }   
        string NameText { get; set; }
        string SurnameText { get; set; }


    }
}
