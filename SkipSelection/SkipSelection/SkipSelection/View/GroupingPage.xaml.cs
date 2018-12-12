using Syncfusion.DataSource;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Grouping
{
    [Preserve(AllMembers = true)]
    public partial class GroupingPage : ContentPage
    {
        public GroupingPage()
        {
            InitializeComponent();
        }

        private void listView_SelectionChanging(object sender, Syncfusion.ListView.XForms.ItemSelectionChangingEventArgs e)
        {
            var addedItemCount = e.AddedItems.Count;
            if (addedItemCount == 0)
                return;

            var items = e.AddedItems;
            var index = listView.DataSource.DisplayItems.IndexOf(items[0]);
            if (index == 1)
                e.Cancel = true;     //Selection cancelled for 1st item

            if (listView.SelectedItems.Count>=3 && addedItemCount != 0)
            {
                e.Cancel = true;
                DisplayAlert("Message", "You can select only 3 items.Can you please deselect any one item", "Ok");
            }
        }
    }
}
