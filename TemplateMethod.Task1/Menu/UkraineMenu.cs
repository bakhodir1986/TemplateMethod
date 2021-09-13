namespace TemplateMethod.Task1.Menu
{
    public class UkraineMenu : MenuFactory
    {
        public override void CookMasala(ICooker cooker)
        {
            CookRice(cooker);
            CookChicken(cooker);
            CookTea(cooker);
        }

        private void CookRice(ICooker cooker)
        {
            cooker.FryRice(500, Level.Strong);
            cooker.SaltRice(Level.Strong);
            cooker.PepperRice(Level.Low);
        }

        private void CookChicken(ICooker cooker)
        {
            cooker.FryChicken(300, Level.Medium);
            cooker.SaltChicken(Level.Medium);
            cooker.PepperChicken(Level.Low);
        }

        private void CookTea(ICooker cooker)
        {
            cooker.PrepareTea(10, TeaKind.Black, 10);
        }
    }
}
