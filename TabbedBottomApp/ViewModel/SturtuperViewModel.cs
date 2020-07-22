using System;
using System.Collections.Generic;
using System.Text;
using TabbedBottomApp.Model;

namespace TabbedBottomApp.ViewModel
{
    public class SturtuperViewModel
    {
        public List<Startuper> Startupers { get; set; }

        public SturtuperViewModel()
        {
            Startupers = new Startuper().GetStartupers();
        }
    }
}
