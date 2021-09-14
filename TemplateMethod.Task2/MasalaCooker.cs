﻿using System;
using TemplateMethod.Task1.Menu;
using TemplateMethod.Task2.Menu;


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
            RestoranMenu menu;

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
