using UnrealBuildTool;

public class HuanJingZuoPingClientTarget : TargetRules
{
	public HuanJingZuoPingClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("HuanJingZuoPing");
	}
}
