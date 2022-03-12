using WonderfulMetaverseNetwork.Manager.Sub.UserInterface.Worker;

namespace WonderfulMetaverseNetwork.Manager.Sub.UserInterface
{
    public class UserInterfaceManager
    {
        public Settings settings;

        public MenuUIWorker menuUIWorker;
        public CurrencyUIWorker currencyUIWorker;

        public UserInterfaceManager(Settings settings)
        {
            this.settings = settings;
            menuUIWorker = new MenuUIWorker();
            currencyUIWorker = new CurrencyUIWorker();
        }
    }
}