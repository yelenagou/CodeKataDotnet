using List.Core;
using System.Collections.Generic;
using System.Text;

namespace List.Data
{
    public interface IListItemData
    {
        IEnumerable<ListItem> GetListItems(string listItem);
        IEnumerable<StorageInfo> GetStorageInfo(string containerName);
        ListItem GetById(int id);
        ListItem Update(ListItem updatedListItem);
        ListItem Add(ListItem newListItem);
        ListItem Delete(int id);
        int Commit();
        StorageInfo GetContainerById(int id);
        StorageInfo UpdateContainers(StorageInfo updateStorageInfo);
    }
}
