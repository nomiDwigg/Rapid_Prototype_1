// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Grappling_Hook_GameEditorTarget : TargetRules
{
	public Grappling_Hook_GameEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Grappling_Hook_Game");
	}
}
