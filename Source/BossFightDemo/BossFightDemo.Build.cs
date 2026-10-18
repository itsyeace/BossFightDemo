// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BossFightDemo : ModuleRules
{
	public BossFightDemo(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"BossFightDemo",
			"BossFightDemo/Variant_Platforming",
			"BossFightDemo/Variant_Platforming/Animation",
			"BossFightDemo/Variant_Combat",
			"BossFightDemo/Variant_Combat/AI",
			"BossFightDemo/Variant_Combat/Animation",
			"BossFightDemo/Variant_Combat/Gameplay",
			"BossFightDemo/Variant_Combat/Interfaces",
			"BossFightDemo/Variant_Combat/UI",
			"BossFightDemo/Variant_SideScrolling",
			"BossFightDemo/Variant_SideScrolling/AI",
			"BossFightDemo/Variant_SideScrolling/Gameplay",
			"BossFightDemo/Variant_SideScrolling/Interfaces",
			"BossFightDemo/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
