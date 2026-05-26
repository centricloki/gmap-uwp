public class CustomAlternateRowColorListView : ListView
{
    protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
    {
        base.PrepareContainerForItemOverride(element, item);
        var listViewItem = element as ListViewItem;
        if (listViewItem != null)
        {
            var index = IndexFromContainer(element);

            if (index % 2 == 0)
            {  
                //Grey background
                listViewItem.Background = new SolidColorBrush(Color.FromArgb(223, 223, 223, 223));
            }
            else
            {
                //Match #FFFFFF for pure white background
                listViewItem.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
            }
        }
    }
}