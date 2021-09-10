using System;
using System.Collections.Generic;
using System.Text;
using TemplateMethod.Task1.Cookers;

namespace TemplateMethod.Task1.Menu
{
    public static class MenuFactory
    {
        public static CookerBase CreateMenu(Country country)
        {
            CookerBase cookerBase;

            if (country == Country.India)
            {
                cookerBase = new IndiaCooker();
            }
            else if (country == Country.Ukraine)
            {
                cookerBase = new UkraineCooker();
            }
            else
            {
                throw new ApplicationException("Invalid Country");
            }

            return cookerBase;
        }

    }
}
