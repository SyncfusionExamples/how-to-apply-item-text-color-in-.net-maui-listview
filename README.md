**[View document in Syncfusion .NET MAUI Knowledge Base](https://www.syncfusion.com/kb/13090/how-to-apply-the-item-text-color-in-net-maui-listview-sflistview)**

## Sample

```xaml
<ContentPage.Resources>
    <ResourceDictionary>
        <local:ColorConverter x:Key="ColorConverter"/>
    </ResourceDictionary>
</ContentPage.Resources>

<syncfusion:SfListView x:Name="listView" ItemSize="60" ItemsSource="{Binding ContactsInfo}">
    <syncfusion:SfListView.ItemTemplate >
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>

C#:

public class ColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value == null)
            return false;
        var itemdata = value as Contacts;
        if (itemdata.ContactType == "HOME")
            return Colors.RoyalBlue;
        else if (itemdata.ContactType == "WORK")
            return Colors.PaleGreen;
        else if (itemdata.ContactType == "MOBILE")
            return Colors.HotPink;
        else if (itemdata.ContactType == "OTHER")
            return Colors.DarkGoldenrod;
        else
            return Colors.BlueViolet;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}
```