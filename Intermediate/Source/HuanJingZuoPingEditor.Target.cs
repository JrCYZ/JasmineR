using UnrealBuildTool;

public class HuanJingZuoPingEditorTarget : TargetRules
{
	public HuanJingZuoPingEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V3;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("HuanJingZuoPing");
	}
}
