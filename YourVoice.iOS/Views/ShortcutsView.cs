using System;
using System.Collections.Generic;
using Foundation;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Binding.Views;
using MvvmCross.Platforms.Ios.Views;
using UIKit;
using System.Linq;
using YourVoice.Core.Helpers;
using YourVoice.Core.ViewModels;

namespace YourVoice.iOS.Views
{
    public partial class ShortcutsView :MvxViewController<ShortcutsViewModel>
    {
        public Dictionary<string,string> Data;
        public List<string> keys;
        public List<string> values;

        public ShortcutsView() : base("ShortcutsView", null)
        {
            keys = new List<string>();
            values = new List<string>();
            Data = new Dictionary<string, string>();
        }

        void BtnAdd_TouchUpInside(object sender, EventArgs e)
        {
            var linq = (from p in Settings.DataList
                        where txtKey.Text == p.Key
                        select p).Any();
            if (linq)
            {
                var okAlertController = UIAlertController.Create("No Duplicate Key", "Key already exists. Choose another one.", UIAlertControllerStyle.Alert);
                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));
                PresentViewController(okAlertController, true, null);
            }
            else
            {
                var oldList = Settings.DataList;
                oldList.Add(txtKey.Text, txtWord.Text);
                Settings.DataList = oldList;
                Inits();
            }
                
               
           
        }

 
        public void Inits()
        {
           
            Data = Settings.DataList;
            keys = new List<string>();
            values = new List<string>();
            foreach (var item in Data)
            {
                keys.Add(item.Key);
                values.Add(item.Value);
            }
            var source = new ShortcutsTableViewSource(listview, this, keys, values);
            listview.Source = source;

            listview.ReloadData();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

          


            this.NavigationController.NavigationBar.TopItem.Title = "Shortcuts";
            this.EdgesForExtendedLayout = UIRectEdge.None;
            Inits();
            var source = new ShortcutsTableViewSource(listview,this,keys,values);
            listview.Source = source;

            listview.ReloadData();
            btnAdd.TouchUpInside+= BtnAdd_TouchUpInside;
            // Perform any additional setup after loading the view, typically from a nib.
        }

       



        public class ShortcutsTableViewSource : UITableViewSource
        {
            List<string> _values;
            List<string> _keys;
            ShortcutsView parent;
            public ShortcutsTableViewSource(UITableView tableView,ShortcutsView p,List<string> keys,List<string> values)
            {
                tableView.RegisterNibForCellReuse(UINib.FromName("ShortcutCell", NSBundle.MainBundle),
                
                                                  ShortcutCell.Key);
                parent = p;
                _keys = keys;
                _values = values;
            }
            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = (ShortcutCell)tableView.DequeueReusableCell("ShortcutCell", indexPath);
                cell.KeyLabel.Text = _keys[indexPath.Row];
                cell.ValueLabel.Text = _values[indexPath.Row];
                return cell;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return _keys.Count;
            }

            public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, Foundation.NSIndexPath indexPath)
            {
                switch (editingStyle)
                {
                    case UITableViewCellEditingStyle.Delete:
                        // remove the item from the underlying data source
                        parent.Data.Remove(_keys[indexPath.Row]);
                        Settings.DataList = parent.Data;

                        parent.Inits();
                        // delete the row from the table
                        break;
                   
                }
            }
           
          

        }
    }




}

