using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Task2.Cookers;

namespace TemplateMethod.Task1.Menu
{
    public class IndianMenu : MenuFactory
    {
        protected override CookerBase AssignCooker()
        {
            return new IndiaCooker();
        }
    }
}
