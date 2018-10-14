using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Media.Imaging;
using DotaLass.API.Enums;

namespace DotaLass.API
{
    public class RankTierIcons
    {
        private static Dictionary<int, BitmapImage> _rankTierIcons;
        private static Dictionary<int, BitmapImage> RankTiersIcons
        {
            get
            {
                if (_rankTierIcons == null)
                {
                    _rankTierIcons = new Dictionary<int, BitmapImage>();

                    var dir = Directory.GetCurrentDirectory() + "/Resources/Images/RankTierIcons/";

                    var files = Directory.GetFiles(dir, "*.png", SearchOption.AllDirectories);

                    foreach (var item in files)
                    {
                        var fileName = Path.GetFileNameWithoutExtension(item);

                        int id;
                        if (int.TryParse(fileName, out id))
                        {
                            _rankTierIcons[id] = new BitmapImage(new Uri(item));
                        }
                    }
                }

                return _rankTierIcons;
            }
        }

        public static BitmapImage GetRankTierIcon(RankTier? rankTier)
        {
            if (!rankTier.HasValue)
                return BlankRankTierIcon;

            return RankTiersIcons.TryGetValue((int) rankTier, out var output) 
                ? output 
                : BlankRankTierIcon;
        }

        private static BitmapImage _blankRankTierIcon;
        public static BitmapImage BlankRankTierIcon
        {
            get
            {
                if (_blankRankTierIcon == null)
                {
                    var uriSource = new Uri(@"/Resources/Images/RankTierIcons/Empty.png", UriKind.Relative);
                    _blankRankTierIcon = new BitmapImage(uriSource);
                }

                return _blankRankTierIcon;
            }
        }
    }
}