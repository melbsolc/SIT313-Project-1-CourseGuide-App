using Foundation;
using System;
using UIKit;

namespace CourseGuide
{
    public partial class TopicTableViewController : UITableViewController
    {
        String[] topicArray = new String[] { "Arts", "Law", "Business", "Technology", "Engineering", "Science", "Other" };

		UIColor[] rowColorArray = new UIColor[] { new UIColor(255/255.0f, 102/255.0f, 102/255.0f, 1.0f),
												  new UIColor(204/255.0f, 204/255.0f, 0/255.0f, 1.0f),
												  new UIColor(255/255.0f, 178/255.0f, 102/255.0f, 1.0f),
												  new UIColor(51/255.0f, 153/255.0f, 255/255.0f, 1.0f),
												  new UIColor(51/255.0f, 255/255.0f, 153/255.0f, 1.0f),
												  new UIColor(0/255.0f, 153/255.0f, 153/255.0f, 1.0f),
												  new UIColor(255/255.0f, 255/255.0f, 204/255.0f, 1.0f)
												};

		 
		public TopicTableViewController(IntPtr handle) : base(handle)
		{
			View.BackgroundColor = UIColor.Black;
		}

		public override nint NumberOfSections(UITableView tableView)
		{
			return 1;
		}

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return topicArray.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell("topicCellID");

			cell.TextLabel.Text = topicArray[indexPath.Row];
			cell.BackgroundColor = rowColorArray[indexPath.Row];

			return cell;
		}

		public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
		{
			return 90f;
		}


    }
}