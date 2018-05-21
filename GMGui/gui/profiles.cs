//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\
//\\//\\//\\//\\//\\//\\ GoodOldPhoenix's LiF Super Mod //\\//\\//\\//\\//\\//\\
//\\//\\//\\//\\//\\//\\             GM GUI             //\\//\\//\\//\\//\\//\\
//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\//\\

singleton GuiControlProfile(pGuiTextEditAlphaProfile : GuiTextEditProfile)
{

};

singleton GuiControlProfile(pGuiTextEditProfile : GuiTextEditProfile)
{
    numbersOnly = true;
};

singleton GuiControlProfile(pGuiTextEditAlphaCenterProfile : GuiTextEditProfile)
{
    justify = "center";
};

singleton GuiControlProfile(pGuiTextEditProfileCenter : GuiTextEditProfile)
{
	numbersOnly = true;
	justify = "center";
};

singleton GuiControlProfile(pGuiTitleTextProfile : GuiBaseTextProfile)
{
	fontSize = 16;
};

singleton GuiControlProfile(pGuiTextProfile : GuiBaseTextProfile)
{
};

singleton GuiControlProfile(pGuiTextProfileRight : GuiBaseTextProfile)
{
	justify = "right";
};

singleton GuiControlProfile(pGuiTextProfileCenter : GuiBaseTextProfile)
{
	justify = "center";
};

singleton GuiControlProfile(pGuiTextClock : GuiBaseTextProfile)
{
	fontSize = 38;
	fontColor = "255 255 255";
	justify = "center";
};

singleton GuiControlProfile(pGuiInv : GuiBaseTextProfile)
{
	fontSize = 12;
	fontType = "Arial";
};

singleton GuiControlProfile(pGuiCheckBoxProfile : GuiCheckBoxProfile)
{
	fontSize = 12;
	//bitmap = "./images/checkbox";
	//hasBitmapArray = true;
};

singleton GuiControlProfile(pGuiDropdownProfile : GuiBaseTextProfile)
{
	border = "";
	
	textOffset = "5 0";
	fontColor = "255 255 255";
	fontColorHL = "255 255 255";
	fontColorNA = "0 0 0";
	fontColorSEL= "0 0 0";	
};

singleton GuiControlProfile(pGuiDropdownCenterProfile : GuiBaseTextProfile)
{
	border = "";
	
	justify = "center";
	
	textOffset = "3 0";
	fontColor = "255 255 255";
	fontColorHL = "255 255 255";
	fontColorNA = "0 0 0";
	fontColorSEL= "0 0 0";	
};

singleton GuiControlProfile(pGuiWindowOverlayProfile : GuiOverlayProfile)
{
	modal = false;
	border = "rect1_color";
	borderColor = "0 0 0";
};

singleton GuiControlProfile(pGuiSmallWindowProfile : GuiBaseCaptionProfile)
{
	opaque = false;
	border = "all_tiling";
	globalImageIndex = "small_window";
	bottomDecorOffset = "2 34";
	bottomDecorSize = "-47 0";
	fontSize = "20";
	textOffset = "8 -2";
	fontColor = "30 29 27";
};

singleton GuiControlProfile(pGuiButtonTabProfile : GuiButtonTabProfile)
{
	opaque = true;
	border = "rect1_color";

	fillColor = "28 28 28";
	fontColor = "175 175 175";
	fontColorHL = "255 255 255";
	fontColorNA = "94 78 60";
	fontColorSEL= "255 255 255";
	fixedExtent = false;
	justify = "center";
	canKeyFocus = false;
	bitmap = "";
	hasBitmapArray = false;
	category = "Core";
};