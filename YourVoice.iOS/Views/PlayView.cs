using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using Plugin.TextToSpeech;
using UIKit;
using System.Linq;
using YourVoice.Core.Helpers;
using YourVoice.Core.ViewModels;

namespace YourVoice.iOS.Views
{
    public partial class PlayView :MvxViewController<PlayViewModel>
    {
        public PlayView() : base("PlayView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.NavigationController.NavigationBar.TopItem.Title = "Play Voice";
            btnPlay.TouchUpInside+= BtnPlay_TouchUpInside;
            this.EdgesForExtendedLayout = UIRectEdge.None;
            var set = this.CreateBindingSet<PlayView, PlayViewModel>();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void BtnPlay_TouchUpInside(object sender, EventArgs e)
        {
            var linq = (from p in Settings.DataList
                        where txtPlay.Text == p.Key
                        select p).FirstOrDefault();
            if(linq.Key!=null)
            {
                CrossTextToSpeech.Current.Speak(linq.Value, null, 0.8f, 0.4f, 1f);
            }
            else
            {
                CrossTextToSpeech.Current.Speak(txtPlay.Text, null, 0.8f, 0.4f, 1f); 
            }

           
        }

    }
}

