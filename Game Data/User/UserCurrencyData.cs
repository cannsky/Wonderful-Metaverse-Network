using System.Collections.Generic;

namespace WonderfulMetaverseNetwork.GameData.User
{
    public class UserCurrencyData
    {
        public Dictionary<string, string> currencyData = new Dictionary<string, string>();

        public UserCurrencyData()
        {
            currencyData["Gold"] = "0";
            currencyData["Diamond"] = "0";
        }

        public bool UpdateUserCurrencyData(string dataKey, string dataValue)
        {
            currencyData[dataKey] = dataValue;
            return true;
        }

        public bool UpdateAllUserCurrencyData(Dictionary<string, string> currencyData)
        {
            this.currencyData = currencyData;
            return true;
        }
    }
}
