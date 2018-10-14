using System.Windows;
using System.Windows.Controls;
using DotaLass.API;

namespace DotaLass.FieldManagement.FieldGenerators.Fields
{
    public class RankTierIconField : FieldBase
    {
        public RankTierIconField(Window window, string fieldName) : base(window, nameof(PlayerDisplay.DisplayData.RankTier), fieldName, double.NaN)
        {
        }

        protected override UIElement CreateFieldElement(PlayerDisplay playerDisplay)
        {
            var image = new Image {Source = RankTierIcons.BlankRankTierIcon, Margin = new Thickness(1)};

            playerDisplay.Data.PropertyChanged += (o, a) =>
            {
                if (a.PropertyName == Path)
                    Window.Dispatcher.Invoke(() =>
                    {
                        if (playerDisplay.Data.RankTier != null)
                        {
                            image.Source = RankTierIcons.GetRankTierIcon(playerDisplay.Data.RankTier);
                        }
                    });
            };

            return image;
        }
    }
}