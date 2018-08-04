using System;

using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using UIKit;
using YourVoice.Core.ViewModels;

namespace YourVoice.iOS.Views
{
    public partial class ShortcutCell : UITableViewCell
    {
        public static readonly UINib Nib = UINib.FromName("ShortcutCell", NSBundle.MainBundle);
        public static readonly NSString Key = new NSString("ShortcutCell");

        public ShortcutCell(IntPtr ptr):base(ptr)
        {

        }
        public UILabel KeyLabel
        {
            get
            {
                return lblKey;
            }
        }

        public UILabel ValueLabel
        {
            get
            {
                return lblWord;
            }
        }
        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        public override void SetSelected(bool selected, bool animated)
        {
            base.SetSelected(selected, animated);
        }

    }
}
