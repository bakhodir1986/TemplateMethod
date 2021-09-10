using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Task1.Cookers;

namespace TemplateMethod.Task1.Menu
{
    public class UkraineMenu : MenuFactory
    {
        protected override CookerBase AssignCooker()
        {
            return new UkraineCooker();
        }
    }
}
