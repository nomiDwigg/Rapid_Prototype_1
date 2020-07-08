// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

#include "Grappling_Hook_GameGameMode.h"
#include "Grappling_Hook_GameHUD.h"
#include "Grappling_Hook_GameCharacter.h"
#include "UObject/ConstructorHelpers.h"

AGrappling_Hook_GameGameMode::AGrappling_Hook_GameGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPersonCPP/Blueprints/FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

	// use our custom HUD class
	HUDClass = AGrappling_Hook_GameHUD::StaticClass();
}
