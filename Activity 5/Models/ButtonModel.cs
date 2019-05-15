using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity4.Models
{
    public class ButtonModel
    {
        public bool State { get; set; }

        public ButtonModel(bool State)
        {
            this.State = State;
        }
    }
}