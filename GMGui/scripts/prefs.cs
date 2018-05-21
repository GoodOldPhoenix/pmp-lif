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

// Password
$pgmPassword = ""; 

if ($pref::PMP::GMPass  $= "")
{
    $pref::PMP::GMPass = $pgmPassword;
}
else
{
    $pgmPassword = $pref::PMP::GMPass;
}
pGMGuiPassword.setText($pref::PMP::GMPass);

// AddAmount
$pAddAmount = 10;

if ($pref::PMP::AddAmount  $= "")
{
    $pref::PMP::AddAmount = $pAddAmount;
}
else 
{ 
    $pAddAmount = $pref::PMP::AddAmount;
}
pGMGuiAddAmount.setText($pref::PMP::AddAmount);

// AddQuality
$pAddQuality = 50;

if ($pref::PMP::AddQuality  $= "")
{ 
    $pref::PMP::AddQuality = $pAddQuality;
}
else
{
    $pAddQuality = $pref::PMP::AddQuality;
}
pGMGuiAddQuality.setText($pref::PMP::AddQuality);

// AddDurability
$pAddDurability = 5000;

if ($pref::PMP::AddDurability  $= "")
{
    $pref::PMP::AddDurability = $pAddDurability;
}
else
{
    $pAddDurability = $pref::PMP::AddDurability;
}
pGMGuiAddDurability.setText($pref::PMP::AddDurability);

// TPPlayerName
$pTPPlayerName = "";

if ($pref::PMP::TPPlayerName  $= "")
{
    $pref::PMP::TPPlayerName = $pTPPlayerName;
}
else
{
    $pTPPlayerName = $pref::PMP::TPPlayerName;
}
pGMGuiTPPlayerName.setText($pref::PMP::TPPlayerName);

// Animal
$pAnimal = "0";

if ($pref::PMP::Animal  $= "")
{ 
    $pref::PMP::Animal = $pAnimal;
} 
else 
{ 
    $pAnimal = $pref::PMP::Animal; 
}
pGMGuiAnimal.setSelected($pAnimal);

// AnimalQuality
$pAnimalQuality = 50;

if ($pref::PMP::AnimalQuality  $= "") 
{ 
    $pref::PMP::AnimalQuality = $pAnimalQuality; 
} 
else 
{ 
    $pAnimalQuality = $pref::PMP::AnimalQuality; 
}
pGMGuiAnimalQuality.setText($pref::PMP::AnimalQuality);

// Weather
$pWeather = "0";

if ($pref::PMP::Weather  $= "") 
{ 
    $pref::PMP::Weather = $pWeather; 
} 
else 
{ 
    $pWeather = $pref::PMP::Weather; 
}
pGMGuiWeather.setSelected($pWeather);

// EXPORT ALL PREFS
export("$pref::*", "data/prefs.cs", False);