// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace YourVoice.iOS.Views
{
    [Register ("ShortcutCell")]
    partial class ShortcutCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblKey { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblWord { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblKey != null) {
                lblKey.Dispose ();
                lblKey = null;
            }

            if (lblWord != null) {
                lblWord.Dispose ();
                lblWord = null;
            }
        }
    }
}