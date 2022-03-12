using WonderfulMetaverseNetwork.Manager;

namespace WonderfulMetaverseNetwork.GameData.User
{
    public class UserData
    {
        public enum DataType
        {
            UserCurrencyData
        }

        public UserCurrencyData userCurrencyData;

        public UserData()
        {
            userCurrencyData = new UserCurrencyData();
        }

        public void UpdateUserData(DataType dataType, string dataKey, string dataValue)
        {
            UpdateUserDataBeforeWorkerUpdate(dataType, dataKey, dataValue);
            MetaverseManager.Instance.userInterfaceManager.currencyUIWorker.OnCurrencyValueChanged();
        }

        public bool UpdateUserDataBeforeWorkerUpdate(DataType dataType, string dataKey, string dataValue)
        {
            return dataType switch
            {
                DataType.UserCurrencyData => userCurrencyData.UpdateUserCurrencyData(dataKey, dataValue),
                _ => true
            };
        }

        /*public bool UpdateAllUserData(DataType dataType, Dictionary<string, string> dataDictionary)
        {
            return dataType switch
            {
                DataType.UserCurrencyData => userCurrencyData.UpdateAllUserCurrencyData(dataDictionary),
                _ => true
            };
        }*/
    }
}
