using WonderfulMetaverseNetwork.Manager;


namespace WonderfulMetaverseNetwork.UI.Currency
{
    public class CurrencyText : MetaverseText
    {
        public enum CurrencyType
        {
            Gold,
            Diamond
        }

        public CurrencyType currencyType;

        private void Start() => MetaverseManager.Instance.userInterfaceManager.currencyUIWorker.AddCurrencyText(this);
    }
}
