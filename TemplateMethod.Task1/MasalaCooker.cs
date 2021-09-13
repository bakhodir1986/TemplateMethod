using System;
using TemplateMethod.Task1.Menu;

namespace TemplateMethod.Task1
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
            Menu.Menu menu;

            if (country == Country.India)
            {
                menu = new IndianMenu();
            }
            else
            {
                menu = new UkraineMenu();
            }

            menu.CookMasala(cooker);
        }
    }
}
