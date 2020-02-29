using System;
using System.Collections.Generic;

using UIKit;
using Foundation;
using SharedCode;

namespace iOSSolution
{
    public partial class MasterViewController : UITableViewController
    {
        DataSource dataSource;

        protected MasterViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Challenges";
            SplitViewController.PreferredDisplayMode = UISplitViewControllerDisplayMode.AllVisible;

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {

            var controller = (DetailViewController)((UINavigationController)segue.DestinationViewController).TopViewController;
            var indexPath = TableView.IndexPathForSelectedRow;

            // TODO: LOAD YOUR VIEW FOR THE RELEVANT CHALLENGE INTO THE DETAIL VIEW.
            //var item = dataSource.Objects[indexPath.Row];

            //Example challenge 2 will show the shared string applied to the label.
            if (indexPath.Row == 1)
            {
                Class1 cls = new Class1();
                controller.SetDetailItem(cls.SOME_TEST_STRING + " Checkpoints challenge (4 to 9)"); // CURRENTLY WILL JUST ToString. Must instead set a subview representing your challenge UI.
            }
            //Example challenge 1 and challenge 3 will load a WKWebview to google.ca. Instead of a WKWebview this can be any custom UIView designed and outletted into this project.
            //This is merely to show a view loading into the panel in a quick/dirty way. Feel free to do this any way you like.
            else
            {
                var wv = new WebKit.WKWebView(controller.View.Frame, new WebKit.WKWebViewConfiguration());
                wv.LoadRequest(new NSUrlRequest(new NSUrl("https://www.google.ca")));
                controller.SetDetailItem(wv);
            }
            controller.NavigationItem.LeftBarButtonItem = SplitViewController.DisplayModeButtonItem;
            controller.NavigationItem.LeftItemsSupplementBackButton = true;

        }

        class DataSource : UITableViewSource
        {
            static readonly NSString CellIdentifier = new NSString("Cell");
            readonly List<object> objects = new List<object>();
            readonly MasterViewController controller;

            public DataSource(MasterViewController controller)
            {
                this.controller = controller;
            }

            public IList<object> Objects
            {
                get { return objects; }
            }

            // Customize the number of sections in the table view.
            public override nint NumberOfSections(UITableView tableView)
            {
                return 1;
            }

            public override nint RowsInSection(UITableView tableview, nint section)
            {
                return objects.Count;
            }

            // Customize the appearance of table view cells.
            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell(CellIdentifier, indexPath);

                cell.TextLabel.Text = objects[indexPath.Row].ToString();

                return cell;
            }

            public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
            {
                // Return false if you do not want the specified item to be editable.
                return false;
            }

            public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
            {
                if (editingStyle == UITableViewCellEditingStyle.Delete)
                {
                    // Delete the row from the data source.
                    objects.RemoveAt(indexPath.Row);
                    controller.TableView.DeleteRows(new[] { indexPath }, UITableViewRowAnimation.Fade);
                }
                else if (editingStyle == UITableViewCellEditingStyle.Insert)
                {
                    // Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view.
                }
            }
        }
    }
}
