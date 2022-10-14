
using BepInEx;
using HarmonyLib;

namespace MC_SVFastRefining
{
    [BepInPlugin(pluginGuid, pluginName, pluginVersion)]
    public class Main : BaseUnityPlugin
    {
        public const string pluginGuid = "mc.starvalor.fastrefining";
        public const string pluginName = "SV Fast Refining";
        public const string pluginVersion = "1.0.0";

        public void Awake()
        {
            Harmony.CreateAndPatchAll(typeof(Main));
        }

        [HarmonyPatch(typeof(BuffRefinery), "Begin")]
        [HarmonyPrefix]
        private static void BuffRefineryBegin_Pre(ref float ___refineTime)
        {
            ___refineTime = 0.2f;
        }
    }
}
