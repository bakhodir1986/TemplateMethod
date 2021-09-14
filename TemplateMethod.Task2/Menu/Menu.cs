namespace TemplateMethod.Task2.Menu
{
    public abstract class RestoranMenu
    {
        public void CookMasala(ICooker cooker)
        {
            CookRice(cooker);
            CookChicken(cooker);
            CookTea(cooker);
        }

        protected abstract void CookRice(ICooker cooker);
        protected abstract void CookChicken(ICooker cooker);
        protected abstract void CookTea(ICooker cooker);
    }
}
