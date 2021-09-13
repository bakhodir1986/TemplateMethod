namespace TemplateMethod.Task1.Menu
{
    public class IndianMenu : MenuFactory
    {
        public override void CookMasala(ICooker cooker)
        {
            CookRice(cooker);
            CookChicken(cooker);
            CookTea(cooker);
        }

        private void CookRice(ICooker cooker)
        {
            cooker.FryRice(200, Level.Strong);
            cooker.SaltRice(Level.Strong);
            cooker.PepperRice(Level.Strong);
        }

        private void CookChicken(ICooker cooker)
        {
            cooker.FryChicken(100, Level.Strong);
            cooker.SaltChicken(Level.Strong);
            cooker.PepperChicken(Level.Strong);
        }

        private void CookTea(ICooker cooker)
        {
            cooker.PrepareTea(15, TeaKind.Green, 12);
        }
    }
}
