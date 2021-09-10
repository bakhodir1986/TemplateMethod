using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Task1.Cookers;

namespace TemplateMethod.Task1.Menu
{
    public abstract class MenuFactory
    {
        protected abstract CookerBase AssignCooker();

        public CookerBase CreateMenu()
        {
            return AssignCooker();
        }
    }
}
