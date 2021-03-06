﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_Visual_Asset_Generator.Data
{

    public abstract class AssetTemplate
    {
        public abstract string FileName { get; }
        public abstract int ImageHeight { get; }
        public abstract int ImageWidth { get; }
        public abstract bool PaddingIsRecommended { get; }

    }

    #region SmallTile

    public class SmallTileScale100 : AssetTemplate
    {
        public override string FileName { get => "SmallTile.scale-100.png"; }
        public override int ImageHeight { get => 71; }
        public override int ImageWidth { get => 71; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class SmallTileScale125 : AssetTemplate
    {
        public override string FileName { get => "SmallTile.scale-125.png"; }
        public override int ImageHeight { get => 89; }
        public override int ImageWidth { get => 89; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class SmallTileScale150 : AssetTemplate
    {
        public override string FileName { get => "SmallTile.scale-150.png"; }
        public override int ImageHeight { get => 107; }
        public override int ImageWidth { get => 107; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class SmallTileScale200 : AssetTemplate
    {
        public override string FileName { get => "SmallTile.scale-200.png"; }
        public override int ImageHeight { get => 142; }
        public override int ImageWidth { get => 142; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class SmallTileScale400 : AssetTemplate
    {
        public override string FileName { get => "SmallTile.scale-400.png"; }
        public override int ImageHeight { get => 284; }
        public override int ImageWidth { get => 284; }
        public override bool PaddingIsRecommended { get => true; }
    }

    #endregion SmallTile
    
    #region MediumTile

    public class MediumTileScale100 : AssetTemplate
    {
        public override string FileName { get => "Square150x150Logo.scale-100.png"; }
        public override int ImageHeight { get => 150; }
        public override int ImageWidth { get => 150; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class MediumTileScale125 : AssetTemplate
    {
        public override string FileName { get => "Square150x150Logo.scale-125.png"; }
        public override int ImageHeight { get => 188; }
        public override int ImageWidth { get => 188; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class MediumTileScale150 : AssetTemplate
    {
        public override string FileName { get => "Square150x150Logo.scale-150.png"; }
        public override int ImageHeight { get => 225; }
        public override int ImageWidth { get => 225; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class MediumTileScale200 : AssetTemplate
    {
        public override string FileName { get => "Square150x150Logo.scale-200.png"; }
        public override int ImageHeight { get => 300; }
        public override int ImageWidth { get => 300; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class MediumTileScale400 : AssetTemplate
    {
        public override string FileName { get => "Square150x150Logo.scale-400.png"; }
        public override int ImageHeight { get => 600; }
        public override int ImageWidth { get => 600; }
        public override bool PaddingIsRecommended { get => true; }
    }

    #endregion MediumTile

    #region WideTile

    public class WideTileScale100 : AssetTemplate
    {
        public override string FileName { get => "Wide310x150Logo.scale-100.png"; }
        public override int ImageHeight { get => 150; }
        public override int ImageWidth { get => 310; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class WideTileScale125 : AssetTemplate
    {
        public override string FileName { get => "Wide310x150Logo.scale-125.png"; }
        public override int ImageHeight { get => 188; }
        public override int ImageWidth { get => 388; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class WideTileScale150 : AssetTemplate
    {
        public override string FileName { get => "Wide310x150Logo.scale-150.png"; }
        public override int ImageHeight { get => 225; }
        public override int ImageWidth { get => 465; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class WideTileScale200 : AssetTemplate
    {
        public override string FileName { get => "Wide310x150Logo.scale-200.png"; }
        public override int ImageHeight { get => 300; }
        public override int ImageWidth { get => 620; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class WideTileScale400 : AssetTemplate
    {
        public override string FileName { get => "Wide310x150Logo.scale-400.png"; }
        public override int ImageHeight { get => 600; }
        public override int ImageWidth { get => 1240; }
        public override bool PaddingIsRecommended { get => true; }
    }

    #endregion WideTile

    #region LargeTile

    public class LargeTileScale100 : AssetTemplate
    {
        public override string FileName { get => "LargeTile.scale-100.png"; }
        public override int ImageHeight { get => 310; }
        public override int ImageWidth { get => 310; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class LargeTileScale125 : AssetTemplate
    {
        public override string FileName { get => "LargeTile.scale-125.png"; }
        public override int ImageHeight { get => 388; }
        public override int ImageWidth { get => 388; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class LargeTileScale150 : AssetTemplate
    {
        public override string FileName { get => "LargeTile.scale-150.png"; }
        public override int ImageHeight { get => 465; }
        public override int ImageWidth { get => 465; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class LargeTileScale200 : AssetTemplate
    {
        public override string FileName { get => "LargeTile.scale-200.png"; }
        public override int ImageHeight { get => 620; }
        public override int ImageWidth { get => 620; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class LargeTileScale400 : AssetTemplate
    {
        public override string FileName { get => "LargeTile.scale-400.png"; }
        public override int ImageHeight { get => 1240; }
        public override int ImageWidth { get => 1240; }
        public override bool PaddingIsRecommended { get => true; }
    }

    #endregion LargeTile

    #region AppIcon

    public class AppIconAltformLightUnplated16 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.altform-lightunplated_targetsize-16.png"; }
        public override int ImageHeight { get => 16; }
        public override int ImageWidth { get => 16; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconAltformLightUnplated24 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.altform-lightunplated_targetsize-24.png"; }
        public override int ImageHeight { get => 24; }
        public override int ImageWidth { get => 24; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconAltformLightUnplated256 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.altform-lightunplated_targetsize-256.png"; }
        public override int ImageHeight { get => 256; }
        public override int ImageWidth { get => 256; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconAltformLightUnplated32 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.altform-lightunplated_targetsize-32.png"; }
        public override int ImageHeight { get => 32; }
        public override int ImageWidth { get => 32; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconAltformLightUnplated48 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.altform-lightunplated_targetsize-48.png"; }
        public override int ImageHeight { get => 48; }
        public override int ImageWidth { get => 48; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconScale100 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.scale-100.png"; }
        public override int ImageHeight { get => 44; }
        public override int ImageWidth { get => 44; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconScale125 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.scale-125.png"; }
        public override int ImageHeight { get => 55; }
        public override int ImageWidth { get => 55; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconScale150 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.scale-150.png"; }
        public override int ImageHeight { get => 66; }
        public override int ImageWidth { get => 66; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconScale200 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.scale-200.png"; }
        public override int ImageHeight { get => 88; }
        public override int ImageWidth { get => 88; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconScale400 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.scale-400.png"; }
        public override int ImageHeight { get => 176; }
        public override int ImageWidth { get => 176; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconTargetSize16 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.targetsize-16.png"; }
        public override int ImageHeight { get => 16; }
        public override int ImageWidth { get => 16; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconTargetSize24 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.targetsize-24.png"; }
        public override int ImageHeight { get => 24; }
        public override int ImageWidth { get => 24; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconTargetSize24Unplated : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.targetsize-24_altform-unplated.png"; }
        public override int ImageHeight { get => 24; }
        public override int ImageWidth { get => 24; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconTargetSize256 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.targetsize-256.png"; }
        public override int ImageHeight { get => 256; }
        public override int ImageWidth { get => 256; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconTargetSize32 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.targetsize-32.png"; }
        public override int ImageHeight { get => 32; }
        public override int ImageWidth { get => 32; }
        public override bool PaddingIsRecommended { get => false; }
    }

    public class AppIconTargetSize48 : AssetTemplate
    {
        public override string FileName { get => "Square44x44Logo.targetsize-48.png"; }
        public override int ImageHeight { get => 48; }
        public override int ImageWidth { get => 48; }
        public override bool PaddingIsRecommended { get => false; }
    }

    #endregion AppIcon

    #region SplashScreen

    public class SplashScreenScale100 : AssetTemplate
    {
        public override string FileName { get => "SplashScreen.scale-100.png"; }
        public override int ImageHeight { get => 300; }
        public override int ImageWidth { get => 620; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class SplashScreenScale125 : AssetTemplate
    {
        public override string FileName { get => "SplashScreen.scale-125.png"; }
        public override int ImageHeight { get => 375; }
        public override int ImageWidth { get => 775; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class SplashScreenScale150 : AssetTemplate
    {
        public override string FileName { get => "SplashScreen.scale-150.png"; }
        public override int ImageHeight { get => 450; }
        public override int ImageWidth { get => 930; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class SplashScreenScale200 : AssetTemplate
    {
        public override string FileName { get => "SplashScreen.scale-200.png"; }
        public override int ImageHeight { get => 600; }
        public override int ImageWidth { get => 1240; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class SplashScreenScale400 : AssetTemplate
    {
        public override string FileName { get => "SplashScreen.scale-400.png"; }
        public override int ImageHeight { get => 1200; }
        public override int ImageWidth { get => 2480; }
        public override bool PaddingIsRecommended { get => true; }
    }

    #endregion SplashScreen

    #region BadgeLogo



    #endregion BadgeLogo

    #region PackageLogo

    public class PackageLogoScale100 : AssetTemplate
    {
        public override string FileName { get => "StoreLogo.scale-100.png"; }
        public override int ImageHeight { get => 50; }
        public override int ImageWidth { get => 50; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class PackageLogoScale125 : AssetTemplate
    {
        public override string FileName { get => "StoreLogo.scale-125.png"; }
        public override int ImageHeight { get => 63; }
        public override int ImageWidth { get => 63; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class PackageLogoScale150 : AssetTemplate
    {
        public override string FileName { get => "StoreLogo.scale-150.png"; }
        public override int ImageHeight { get => 75; }
        public override int ImageWidth { get => 75; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class PackageLogoScale200 : AssetTemplate
    {
        public override string FileName { get => "StoreLogo.scale-200.png"; }
        public override int ImageHeight { get => 100; }
        public override int ImageWidth { get => 100; }
        public override bool PaddingIsRecommended { get => true; }
    }

    public class PackageLogoScale400 : AssetTemplate
    {
        public override string FileName { get => "StoreLogo.scale-400.png"; }
        public override int ImageHeight { get => 200; }
        public override int ImageWidth { get => 200; }
        public override bool PaddingIsRecommended { get => true; }
    }

    #endregion PackageLogo
}
