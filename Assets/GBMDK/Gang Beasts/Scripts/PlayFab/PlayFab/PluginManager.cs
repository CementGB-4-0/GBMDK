using System.Collections.Concurrent;

namespace PlayFab
{
    public class PluginManager
    {
        private static readonly PluginManager Instance;
        private ConcurrentDictionary<PluginContractKey, IPlayFabPlugin> plugins;

        private PluginManager()
        {
        }

        public static T GetPlugin<T>(PluginContract contract, string instanceName = "") where T : IPlayFabPlugin
        {
            return default(T);
        }

        public static void SetPlugin(IPlayFabPlugin plugin, PluginContract contract, string instanceName = "")
        {
        }

        private IPlayFabPlugin GetPluginInternal(PluginContract contract, string instanceName)
        {
            return null;
        }

        private void SetPluginInternal(IPlayFabPlugin plugin, PluginContract contract, string instanceName)
        {
        }

        private IPlayFabPlugin CreatePlugin<T>() where T : IPlayFabPlugin, new()
        {
            return null;
        }

        private ITransportPlugin CreatePlayFabTransportPlugin()
        {
            return null;
        }
    }
}