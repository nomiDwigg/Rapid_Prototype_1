// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Grappling_Hook_GameTarget : TargetRules
{
	public Grappling_Hook_GameTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Grappling_Hook_Game");
	}
}
