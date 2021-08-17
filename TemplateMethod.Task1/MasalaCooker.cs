using System;

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
            if (country == Country.India)
            {
                cooker = new IndiaRecipy();
            }
            else
            {
                cooker = new UkrainaRecipy();
            }
        }
    }
}
