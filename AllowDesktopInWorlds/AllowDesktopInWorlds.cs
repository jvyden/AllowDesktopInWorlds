using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using FrooxEngine;

using HarmonyLib;
using ResoniteModLoader;

namespace AllowDesktopInWorlds;
//More info on creating mods can be found https://github.com/resonite-modding-group/ResoniteModLoader/wiki/Creating-Mods
[SuppressMessage("ReSharper", "InconsistentNaming")]
public class AllowDesktopInWorlds : ResoniteMod
{
	internal const string VersionConstant = "1.0.0"; // Changing the version here updates it in all locations needed
	public override string Name => "AllowDesktopInWorlds";
	public override string Author => "jvyden";
	public override string Version => VersionConstant;
	public override string Link => "https://github.com/jvyden/AllowDesktopInWorlds";

	public override void OnEngineInit()
	{
		Harmony harmony = new("xyz.jvyden.AllowDesktopInWorlds");
		harmony.PatchAll();
	}

	[HarmonyPatch(typeof(DesktopTextureProvider), "UpdateAsset")]
	private static class DesktopTextureProvider_UpdateAsset_Patch
	{
		private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
		{
			int i = 0;
			foreach (CodeInstruction instruction in instructions)
			{
				// skip first few instructions

				//     if (base.World != Userspace.UserspaceWorld)
				// IL_0000: ldarg.0
				// IL_0001: call      instance class FrooxEngine.World FrooxEngine.Worker::get_World()
				// IL_0006: call      class FrooxEngine.World FrooxEngine.Userspace::get_UserspaceWorld()
				// IL_000B: beq.s     IL_000E

				//         return;
				// IL_000D: ret

				if (i >= 5)
					yield return instruction;

				i++;
			}
		}
	}
}
