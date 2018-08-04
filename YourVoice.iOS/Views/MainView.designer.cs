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
    [Register ("MainView")]
    partial class MainView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnPlayVoice { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnShortcuts { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnPlayVoice != null) {
                btnPlayVoice.Dispose ();
                btnPlayVoice = null;
            }

            if (btnShortcuts != null) {
                btnShortcuts.Dispose ();
                btnShortcuts = null;
            }
        }
    }
}