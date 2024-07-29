using UnrealBuildTool;

public class HuanJingZuoPingTarget : TargetRules
{
	public HuanJingZuoPingTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("HuanJingZuoPing");
	}
}
