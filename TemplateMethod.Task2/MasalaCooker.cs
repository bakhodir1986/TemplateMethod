using System;
using TemplateMethod.Task1.Menu;
using TemplateMethod.Task2.Cookers;

namespace TemplateMethod.Task2
{
    public class MasalaCooker
    {
        private ICooker cooker;

        public MasalaCooker(ICooker cooker)
        {
            this.cooker = cooker;
        }

        public void CookMasala(Country country)
        {
            MenuFactory menuFactory;

            if (country == Country.India)
            {
                menuFactory = new IndianMenu();
            }
            else
            {
                menuFactory = new UkraineMenu();
            }

            menuFactory.CreateMenu().CookMasala(cooker);
        }
    }
}
