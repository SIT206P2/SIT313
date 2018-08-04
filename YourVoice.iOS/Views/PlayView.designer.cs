// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace YourVoice.iOS.Views
{
    [Register ("PlayView")]
    partial class PlayView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPlay { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPlay { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnPlay != null) {
                btnPlay.Dispose ();
                btnPlay = null;
            }

            if (txtPlay != null) {
                txtPlay.Dispose ();
                txtPlay = null;
            }
        }
    }
}