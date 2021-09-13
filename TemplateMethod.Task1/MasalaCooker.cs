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
            Menu.Menu menuFactory;

            if (country == Country.India)
            {
                menuFactory = new IndianMenu();
            }
            else
            {
                menuFactory = new UkraineMenu();
            }

            menuFactory.CookMasala(cooker);
        }
    }
}
