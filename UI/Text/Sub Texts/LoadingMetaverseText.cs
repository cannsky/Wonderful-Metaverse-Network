using WonderfulMetaverseNetwork.Manager;

namespace WonderfulMetaverseNetwork.UI
{
    public class LoadingMetaverseText : MetaverseText
    {
        private void Start()
        {
            base.text.text = "Loading " + MetaverseManager.Instance.userInterfaceManager.settings.name;
        }
    }
}