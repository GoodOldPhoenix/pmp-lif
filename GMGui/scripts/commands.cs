//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
//\\//\\//\\//\\//\\//\\ GoodOldPhoenix's LiF Super Mod //\\//\\//\\//\\//\\//\\
//\\//\\//\\//\\//\\//\\             GM GUI             //\\//\\//\\//\\//\\//\\
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\

// Wouldn't really recommend changing anything here unless you need to or have
// the knowhow to do so safely. 
//
// If you spot a bug, a faster method of doing something, please don't change
// it and then let it be, please report it to GoodOldPhoenix or to the GitHub
// where I will be able to make the change globally for everyone, don't worry, 
// I will credit your edits if I choose to use them!

function pGMToggleMode()
{
	%password = pGMGuiPassword.GetValue();

	%cmd = "/GM " @ %password;

	doSlashCommand(%cmd);

	pGMGuiPassword.setActive(false); pGMGuiPassword.setActive(true);		

	$pref::PMP::Password = %password;

	export("$pref::*", "data/prefs.cs", False);
}

function pGMMorning()
{	
	onChatMessage("<spush><color:FF4500>Morning Sweetheart!<spop>", null, null);
	
	morning();
}

function pGMAllSkills()
{

	for (%i = 0; %i < 4; %i++)
	{
		%cmd = "/SETMYSTAT " @ %i @ " 100";
		
		onChatMessage("<spush><color:FF4500>Stats set to max!<spop>", null, null);
		
		doSlashCommand(%cmd);
	}

	for (%i = 1; %i < 66; %i++)
	{
		%cmd = "/SETMYSKILL " @ %i @ " 100";
		
		onChatMessage("<spush><color:FF4500>Skills set to max!<spop>", null, null);
		
		doSlashCommand(%cmd);
	}
}

function pGMHealSelf()
{
	%cmd = "/HEALSELF";
	
	onChatMessage("<spush><color:FF4500>You are healed!<spop>", null, null);
	
	doSlashCommand(%cmd);	
}

function pGMRemoveEffects()
{
	%cmd = "/REMOVEEFFECTS";
	
	onChatMessage("<spush><color:FF4500>All Effects Removed<spop>", null, null);
	
	doSlashCommand(%cmd);	
}
 
function pGMInvul()
{
	%cmd = "/INVUL";
	
	onChatMessage("<spush><color:FF4500>You are invulnerable!<spop>", null, null);
	
	doSlashCommand(%cmd);	
}

function pGMTPToPlayer()
{
	%player = pGMGuiTPPlayerName.GetValue();
	
	%cmd = "/TPTOPLAYER " @ %player;
	
	onChatMessage("<spush><color:FF4500>Teleported to " @ %player @ "<spop>", null, null);
	
	doSlashCommand(%cmd);

	pGMGuiTPPlayerName.setActive(false);
	pGMGuiTPPlayerName.setActive(true);	
	
	$pref::PMP::TPPlayerName = %player;
	
	export("$pref::*", "data/prefs.cs", False);		
}

function pGMSpawnAnimal()
{
	%animal = pGMGuiAnimal.getSelected();
	%animalText = pGMGuiAnimal.getText();
	%quality = pGMGuiAnimalQuality.GetValue();
	
	%cmd = "/ANIMAL " @ %animalText @ " " @ %quality;
	
	onChatMessage("<spush><color:FF4500>Spawned " @ %animalText @ "<spop>", null, null);
	
	doSlashCommand(%cmd);

	pGMGuiAnimalQuality.setActive(false);
	pGMGuiAnimalQuality.setActive(true);	
	
	$pref::PMP::Animal = %animal;
	$pref::PMP::AnimalQuality = %quality;
	
	export("$pref::*", "data/prefs.cs", False);	
}

function pGMWeather()
{
	%weather = pGMGuiWeather.getSelected();
	%weatherText = pGMGuiWeather.getText();
	
	%cmd = "/WEATHER " @ %weatherText;
	
	onChatMessage("<spush><color:FF4500>Weather set to " @ %weatherText @ "<spop>", null, null);
	
	doSlashCommand(%cmd);
	
	$pref::PMP::Weather = %weather;
	
	export("$pref::*", "data/prefs.cs", False);
}

function pGMAddConstructionItems()
{
	%construct = pGMGuiConstruct.getSelected();
	%constructText = pGMGuiConstruct.getText();

	// TorqueScript has an inbuilt method for an .equals() or == method.
	// We call this using switch$ (%variableWeAreMatchingAgainst)
	// and then use case "string": to assign our matches. 
	// Once correct match is found, runs specified funciton.
	switch$ (%constructText)
	{
		case "Small Stable":
			pSpawnSmallStableItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Large Stable":
			pSpawnLargeStableItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Barn":
			pSpawnBarnItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Alchemist's Table":
			pSpawnAlchTableItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Barn (Wooden)":
			pSpawnWBarnItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Beehive":
			pSpawnBeehiveItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Blacksmith's Shop":
			pSpawnBSmithShopItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Bloomery":
			pSpawnBloomeryItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Brewing Station":
			pSpawnBrewingStationItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Carpenter's Shop":
			pSpawnCarpShopItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Carpenter's Shop (Wood)":
			pSpawnWCarpShopItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Coop":
			pSpawnCoopItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Drying Frame":
			pSpawnDFrameItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Forge & Anvil":
			pSpawnFandAItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Furnace":
			pSpawnFurnaceItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Gatehouse (Castle)":
			pSpawnGHCastleItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Gatehouse (Castle w/ Bridge)":
			pSpawnGHCastleBridgeItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Gatehouse (Stone)":
			pSpawnGHStoneItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Herbalist's Shop":
			pSpawnHerbShopItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Herbalist's Shop (Wood)":
			pSpawnWHerbShopItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (3Story Plaster)":
			pSpawn3StoryPHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (3Story Wood)":
			pSpawn3StoryWHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (L3Story Plaster)":
			pSpawnL3StoryPHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (L3Story Wood)":
			pSpawnL3StoryWHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (Large Stone)":
			pSpawnLStoneHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (Large Wood)":
			pSpawnLWoodHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (Plaster)":
			pSpawnPlasterHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (Small Plaster)":
			pSpawnSPlasterHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (Small Wood)":
			pSpawnSWoodHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "House (Wooden)":
			pSpawnWoodenHouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Keep":
			pSpawnKeepItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Keep (Castle)":
			pSpawnCastleKeepItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Keep (Small)":
			pSpawnSmallKeepItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Keep (Wooden)":
			pSpawnWoodKeepItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Kilm":
			pSpawnKilnItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Kitchen":
			pSpawnKitchenItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Potter's Wheel":
			pSpawnPWheelItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Siege Workshop":
			pSpawnSWorksopItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Siege Workshop (Wood)":
			pSpawnWSWorkshopItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "School":
			pSpawnSchoolItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "School (Wooden)":
			pSpawnWoodSchoolItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Tailor's Bench":
			pSpawnTBenchItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Tanning Tub":
			pSpawnTTubItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Tower (Castle)":
			pSpawnTowerCastleItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Tower (Castle Angle)":
			pSpawnTowerCastleAngleItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Tower (Castle Trans)":
			pSpawnTowerCastleTransItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Tower (Stone)":
			pSpawnTowerStoneItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Tower (Stone Inner)":
			pSpawnTowerStoneInnerItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Training Field":
			pSpawnTrainingFieldItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Wall (Castle)":
			pSpawnWallCastleItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Wall (Palisade)":
			pSpawnWallPalisadeItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Wall (Stone)":
			pSpawnWallStoneItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Wall (Wooden)":
			pSpawnWallWoodItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Warehouse":
			pSpawnWarehouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Warehouse (Large)":
			pSpawnLWarehouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Warehouse (Wooden)":
			pSpawnWWarehouseItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Windmill":
			pSpawnWindmillItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Windmill (Wooden)":
			pSpawnWoodWindmillItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
		case "Workbench":
			pSpawnWorkbenchItems();
			onChatMessage("<spush><color:FF4500>Spawned Materials For " @ %constructText @ "<spop>");
	}
}

function pSpawnSmallStableItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 241 100 " @ %quality @ "");
	doSlashCommand("/ADD 362 50 " @ %quality @ "");
	doSlashCommand("/ADD 326 40 " @ %quality @ "");
}

function pSpawnLargeStableItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 100 " @ %quality @ ""); 
	doSlashCommand("/ADD 362 250 " @ %quality @ "");
	doSlashCommand("/ADD 528 120 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 16 " @ %quality @ ""); 
	doSlashCommand("/ADD 269 100 " @ %quality @ ""); 
}

function pSpawnBarnItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 281 200 " @ %quality @ ""); 
	doSlashCommand("/ADD 362 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 244 200 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 40 " @ %quality @ "");
}

function pSpawnAlchTableItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 327 8 " @ %quality @ ""); 
	doSlashCommand("/ADD 374 2 " @ %quality @ ""); 
	doSlashCommand("/ADD 222 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 223 1 " @ %quality @ "");
}

function pSpawnWBarnItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 327 40 " @ %quality @ "");
	doSlashCommand("/ADD 233 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 281 200 " @ %quality @ ""); 
	doSlashCommand("/ADD 362 50 " @ %quality @ ""); 
}

function pSpawnBeehiveItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 325 2 " @ %quality @ "");
	doSlashCommand("/ADD 281 45 " @ %quality @ ""); 
	doSlashCommand("/ADD 362 10 " @ %quality @ "");
}

function pSpawnBSmithShopItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 269 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 428 8 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 110 1 " @ %quality @ "");
}

function pSpawnBloomeryItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 269 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 283 8 " @quality @ "");
	doSlashCommand("/ADD 528 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 324 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 428 4 " @ %quality @ "");
}

function pSpawnBrewingStationItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 281 40 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 4 " @ %quality @ ""); 
	doSlashCommand("/ADD 283 8 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 4 " @ %quality @ "");  
}

function pSpawnCarpShopItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 3 " @ %quality @ ""); 
	doSlashCommand("/ADD 244 300 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 40 " @ %quality @ ""); 
}

function pSpawnWCarpShopItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 120 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 40 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 3 " @ %quality @ "");
}

function pSpawnCoopItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 30 " @ %quality @ ""); 
	doSlashCommand("/ADD 471 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 281 60 "); 
}

function pSpawnDFrameItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 237 4 " @ %quality @ ""); 
	doSlashCommand("/ADD 374 1 " @ %quality @ ""); 
}

function pSpawnFandAItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 269 30 " @ %quality @ ""); 
	doSlashCommand("/ADD 244 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 110 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 324 1 " @ %quality @ ""); 
}

function pSpawnFurnaceItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 471 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 244 100 " @ %quality @ ""); 
	doSlashCommand("/ADD 204 5 " @ %quality @ ""); 
}

function pSpawnGHCastleItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 200 " @ %quality @ ""); 
	doSlashCommand("/ADD 269 80 " @ %quality @ ""); 
	doSlashCommand("/ADD 271 1600 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 200 " @ %quality @ ""); 
	doSlashCommand("/ADD 287 2 " @ %quality @ ""); 
}

function pSpawnGHCastleBridgeItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 269 80 " @ %quality @ "");
	doSlashCommand("/ADD 326 200 " @ %quality @ "");
	doSlashCommand("/ADD 271 1600 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 200 " @ %quality @ "");
	doSlashCommand("/ADD 287 200 " @ %quality @ "");
}

function pSpawnGHStoneItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 150 " @ %quality @ ""); 
	doSlashCommand("/ADD 269 250 " @ %quality @ "");
	doSlashCommand("/ADD 244 1400 " @ %quality @ "");
	doSlashCommand("/ADD 287 1 " @ %quality @ ""); 
}

function pSpawnHerbShopItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 50 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 3 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 40 " @ %quality @ "");
	doSlashCommand("/ADD 244 300 " @ %quality @ "");
}

function pSpawnWHerbShopItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 40 " @ %quality @ "");
	doSlashCommand("/ADD 233 120 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 20 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 3 " @ %quality @ ""); 
}

function pSpawn3StoryPHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 268 400 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 200 " @ %quality @ "");
	doSlashCommand("/ADD 528 200 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 22 " @ %quality @ ""); 
}

function pSpawn3StoryWHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 300 " @ %quality @ "");
	doSlashCommand("/ADD 268 400 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 24 " @ %quality @ "");
	doSlashCommand("/ADD 326 200 " @ %quality @ "");
}

function pSpawnL3StoryPHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 528 300 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 250 " @ %quality @ "");
	doSlashCommand("/ADD 288 24 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 268 600 " @ %quality @ ""); 
}

function pSpawnL3StoryWHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 450 " @ %quality @ "");
	doSlashCommand("/ADD 326 300 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 30 " @ %quality @ ""); 
	doSlashCommand("/ADD 268 600 " @ %quality @ "");
}

function pSpawnLStoneHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 528 100 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 12 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 150 " @ %quality @ "");
	doSlashCommand("/ADD 268 300 " @ %quality @ "");
}

function pSpawnLWoodHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 160 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 250 " @ %quality @ ""); 
	doSlashCommand("/ADD 268 300 " @ %quality @ ""); 
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 16 " @ %quality @ "");
}

function pSpawnPlasterHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 150 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 60 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 14 " @ %quality @ "");
	doSlashCommand("/ADD 268 300 " @ %quality @ "");
}

function pSpawnSPlasterHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 30 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 4 " @ %quality @ "");
	doSlashCommand("/ADD 268 150 " @ %quality @ "");
}

function pSpawnSWoodHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 150 " @ %quality @ "");
	doSlashCommand("/ADD 281 200 " @ %quality @ ""); 
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 4 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 60 " @ %quality @ "");
}

function pSpawnWoodenHouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 200 " @ %quality @ "");
	doSlashCommand("/ADD 268 150 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 12 " @ %quality @ "");
	doSlashCommand("/ADD 326 100 " @ %quality @ "");
}

function pSpawnKeepItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 269 750 " @ %quality @ ""); 
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 200 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 400 " @ %quality @ ""); 
	doSlashCommand("/ADD 271 4000 " @ %quality @ "");
}

function pSpawnCastleKeepItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 271 8000 " @ %quality @ ""); 
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 1000 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 1000 " @ %quality @ "");
	doSlashCommand("/ADD 270 800 " @ %quality @ ""); 
}

function pSpawnSmallKeepItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 269 675 " @ %quality @ ""); 
	doSlashCommand("/ADD 271 3600 " @ %quality @ "");
	doSlashCommand("/ADD 528 135 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 300 " @ %quality @ ""); 
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
}

function pSpawnWoodKeepItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 600 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 300 " @ %quality @ "");
	doSlashCommand("/ADD 281 2000 " @ %quality @ "");
	doSlashCommand("/ADD 262 20 " @ %quality @ ""); 
}

function pSpawnKilnItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 204 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 244 400 " @ %quality @ "");
	doSlashCommand("/ADD 471 30 " @ %quality @ ""); 
}

function pSpawnKitchenItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 324 40 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 403 2 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 50 " @ %quality @ ""); 
}

function pSpawnPWheelItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 3 " @ %quality @ "");
	doSlashCommand("/ADD 374 2 " @ %quality @ ""); 
}

function pSpawnSWorkshopItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 244 300 " @ %quality @ "");
	doSlashCommand("/ADD 288 3 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 40 " @ %quality @ "");
	doSlashCommand("/ADD 262 20 " @ %quality @ "");
}

function pSpawnWSWorkshopItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 100 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 20 " @ %quality @ "");
	doSlashCommand("/ADD 288 3 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 262 20 " @ %quality @ "");
}

function pSpawnSchoolItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 3 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 40 " @ %quality @ "");
	doSlashCommand("/ADD 244 300 " @ %quality @ "");
}

function pSpawnWoodSchoolItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 40 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 120 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ "");
	doSlashCommand("/ADD 286 20 " @ %quality @ "");
	doSlashCommand("/ADD 288 3 " @ %quality @ ""); 
}

function pSpawnTBenchItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 327 12 " @ %quality @ "");
	doSlashCommand("/ADD 281 34 " @ %quality @ "");
	doSlashCommand("/ADD 262 1 " @ %quality @ ""); 
}

function pSpawnTTubItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 327 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 1 " @ %quality @ ""); 
}

function pSpawnTowerCastleItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 30 " @ %quality @ ""); 
	doSlashCommand("/ADD 269 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 271 600 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 75 " @ %quality @ "");
	doSlashCommand("/ADD 281 300 " @ %quality @ "");
}

function pSpawnTowerCastleAngleItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 100 " @ %quality @ "");
	doSlashCommand("/ADD 269 30 " @ %quality @ "");
	doSlashCommand("/ADD 271 800 " @ %quality @ "");
	doSlashCommand("/ADD 528 90 " @ %quality @ "");
	doSlashCommand("/ADD 281 600 " @ %quality @ "");
}

function pSpawnTowerCastleTransItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 30 " @ %quality @ "");
	doSlashCommand("/ADD 269 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 271 600 " @ %quality @ "");
	doSlashCommand("/ADD 528 75 " @ %quality @ ""); 
	doSlashCommand("/ADD 281 300 " @ %quality @ ""); 
}

function pSpawnTowerStoneItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 80 " @ %quality @ ""); 
	doSlashCommand("/ADD 269 100 " @ %quality @ "");
	doSlashCommand("/ADD 244 600 " @ %quality @ "");
}

function pSpawnTowerStoneInnerItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 80 " @ %quality @ "");
	doSlashCommand("/ADD 269 100 " @ %quality @ "");
	doSlashCommand("/ADD 244 600 " @ %quality @ ""); 
}

function pSpawnTrainingFieldItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 262 2 " @ %quality @ "");
	doSlashCommand("/ADD 326 40 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 281 20 " @ %quality @ "");
}

function pSpawnWallCastleItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 326 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 269 60 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 10 " @ %quality @ ""); 
	doSlashCommand("/ADD 271 400 " @ %quality @ ""); 
	doSlashCommand("/ADD 528 50 " @ %quality @ ""); 
}

function pSpawnWallPalisadeItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 5 " @ %quality @ "");
}

function pSpawnWallStoneItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 269 30 " @ %quality @ "");
	doSlashCommand("/ADD 326 10 " @ %quality @ "");
	doSlashCommand("/ADD 244 200 " @ %quality @ "");
}

function pSpawnWallWoodItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 7 " @ %quality @ "");
	doSlashCommand("/ADD 326 5 " @ %quality @ "");
}

function pSpawnWarehouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 50 " @ %quality @ "");
	doSlashCommand("/ADD 528 40 " @ %quality @ "");
	doSlashCommand("/ADD 288 6 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ "");
	doSlashCommand("/ADD 244 300 " @ %quality @ "");
}

function pSpawnLWarehouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 120 " @ %quality @ "");
	doSlashCommand("/ADD 286 2 " @ %quality @ "");
	doSlashCommand("/ADD 288 4 " @ %quality @ "");
	doSlashCommand("/ADD 269 100 " @ %quality @ "");
	doSlashCommand("/ADD 268 500 " @ %quality @ "");
}

function pSpawnWWarehouseItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 233 120 " @ %quality @ ""); 
	doSlashCommand("/ADD 326 40 " @ %quality @ "");
	doSlashCommand("/ADD 282 20 " @ %quality @ "");
	doSlashCommand("/ADD 286 1 " @ %quality @ ""); 
	doSlashCommand("/ADD 262 10 " @ %quality @ ""); 
}

function pSpawnWindmillItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 269 100 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 40 " @ %quality @ ""); 
	doSlashCommand("/ADD 261 40 " @ %quality @ ""); 
	doSlashCommand("/ADD 282 20 " @ %quality @ ""); 
	doSlashCommand("/ADD 268 200 " @ %quality @ ""); 
}

function pSpawnWoodWindmillItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 261 50 " @ %quality @ ""); 
	doSlashCommand("/ADD 288 3 " @ %quality @ ""); 
	doSlashCommand("/ADD 233 320 " @ %quality @ "");
	doSlashCommand("/ADD 326 70 " @ %quality @ "");
	doSlashCommand("/ADD 282 35 " @ %quality @ "");
}

function pSpawnWorkbenchItems()
{
	%quality = pGMGuiConstructQuality.GetValue();

	doSlashCommand("/ADD 327 12 " @ %quality @ "");
	doSlashCommand("/ADD 281 34 " @ %quality @ "");
	doSlashCommand("/ADD 262 1 " @ %quality @ "");
}
// Well we finally got to the end of that list of functions!
// Phoenix is happy!
// Now should I do a list for Items..? * insert troll face here *