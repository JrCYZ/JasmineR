using UnrealBuildTool;

public class HuanJingZuoPingServerTarget : TargetRules
{
	public HuanJingZuoPingServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("HuanJingZuoPing");
	}
}
