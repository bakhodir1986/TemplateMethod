﻿using System;
using TemplateMethod.Task1.Cookers;
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
            MenuFactory.CreateMenu(country).CookMasala(cooker);
        }
    }
}
