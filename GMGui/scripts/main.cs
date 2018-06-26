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

if (!$pGMVersion)
{
    pGMGuiWindowCtrl.text = "Phoenix's GM Tools::" @ $pGMVersion;
}

// Toggle Window
function pGMWindowToggle(%val)
{
    if (%val)
    {
        if (pGMGuiWindow.isAwake())
        {
            PlayGui.remove(pGMGuiWindow);
            onChatMessage("<spush><color:ffff00>Closed Phoenix's GM Tools GUI<spop>", null, null);
        }
        else
        {
            PlayGui.add(pGMGuiWindow);
            onChatMessage("<spush><color:ffff00>Opened Phoenix's GM Tools GUI<spop>", null, null);
        }
    }
}

// Set up keybind to open menu
moveMap.bind(keyboard, "ctrl g", pGMWindowToggle);