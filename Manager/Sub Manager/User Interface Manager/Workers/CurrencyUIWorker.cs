using TMPro;
using System.Collections.Generic;
using WonderfulMetaverseNetwork.UI.Currency;

namespace WonderfulMetaverseNetwork.Manager.Sub.UserInterface.Worker
{
    public class CurrencyUIWorker
    {
        public List<CurrencyText> currencyTexts = new List<CurrencyText>();

        public void OnCurrencyValueChanged()
        {
            foreach (CurrencyText currencyText in currencyTexts)
                UpdateCurrencyText(currencyText);
        }

        public void AddCurrencyText(CurrencyText currencyText)
        {
            currencyTexts.Add(currencyText);
            UpdateCurrencyText(currencyText);
        }

        public void UpdateCurrencyText(CurrencyText currencyText) => currencyText.text.text = MetaverseManager.Instance.dataManager.data.userData.userCurrencyData.currencyData[currencyText.currencyType.ToString()];
    }
}