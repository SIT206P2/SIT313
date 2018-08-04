using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Views;
using UIKit;
using YourVoice.Core.ViewModels;

namespace YourVoice.iOS.Views
{
    public partial class MainView : MvxViewController<MainViewModel>
    {
        public MainView() : base("MainView", null)
        {
            
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.NavigationController.NavigationBar.TopItem.Title = "Your Voice";
            this.NavigationController.NavigationBar.BackgroundColor = UIColor.Blue;
            this.EdgesForExtendedLayout = UIRectEdge.None;


            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(btnPlayVoice).To(vm => vm.ShowPlayCommand);
            set.Bind(btnShortcuts).To(vm => vm.ShowShortcutsCommand);
            set.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

