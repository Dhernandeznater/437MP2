using UnrealBuildTool;

public class MP_2Target : TargetRules
{
	public MP_2Target(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("MP_2");
	}
}
