using List.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace List.Data
{
    public class InMemoryListData : IListItemData
    {
        readonly List<ListItem> listItems;
        readonly List<StorageInfo> storageItems;
   
        public InMemoryListData()
        {
            listItems = new List<ListItem>()
            {
                 new ListItem { Id = 1, Name = "Scott's Pizza", Location="Maryland", ListItemType=ListItemType.Italian},
                new ListItem { Id = 2, Name = "Cinnamon Club", Location="London", ListItemType=ListItemType.Italian},
                new ListItem { Id = 3, Name = "La Costa", Location = "California", ListItemType=ListItemType.Mexican}
            };

            storageItems = new List<StorageInfo>()
            {
                new StorageInfo { Id = 1, ContainerName="Container One", BlobName = "Blob One", FileType = FileType.text},
                new StorageInfo { Id = 2, ContainerName="Container One", BlobName = "Blob Two", FileType = FileType.excel},
                new StorageInfo { Id = 3, ContainerName="Container One", BlobName = "Blob Three", FileType = FileType.other}

            };
        }
        public ListItem GetById(int id)
        {
            return listItems.SingleOrDefault(r => r.Id == id);
        }
        /// <summary>
        /// Get all list items that match input criteria
        /// </summary>
        /// <param name="listItem">search criteria</param>
        /// <returns>List of ListItem</returns>
        public IEnumerable<ListItem> GetListItems(string listItem) 
        {
            return from r in listItems
                   where string.IsNullOrEmpty(listItem) || r.Name.StartsWith(listItem)
                   orderby r.Name
                   select r;
        }
        /// <summary>
        /// Add new list item 
        /// </summary>
        /// <param name="newListItem">pass a populated instance of an object</param>
        /// <returns>new record with an faux Id</returns>
        public ListItem Add(ListItem newListItem)
        {
            listItems.Add(newListItem);
            newListItem.Id = listItems.Max(r => r.Id) + 1;
            return newListItem;

        }
        public ListItem Update(ListItem updatedListItem)
        {
            var listItem = listItems.SingleOrDefault(r => r.Id == updatedListItem.Id);
            if(listItem != null)
            {
                listItem.Name = updatedListItem.Name;
                listItem.Location = updatedListItem.Location;
                listItem.ListItemType = updatedListItem.ListItemType;
            }
            
            return listItem;

        }
        public int Commit()
        {
            return 0;
        }
        /// <summary>
        /// Get Storage info by container name
        /// </summary>
        /// <param name="containerName"></param>
        /// <returns></returns>
        public IEnumerable<StorageInfo> GetStorageInfo(string containerName = null)
        {
            return from s in storageItems
                   where string.IsNullOrEmpty(containerName) || s.BlobName.StartsWith(containerName)
                   orderby s.ContainerName
                   select s;
        }
        /// <summary>
        /// Get Container by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Container Information</returns>
        public StorageInfo GetContainerById(int id)
        {
           return storageItems.SingleOrDefault(r => r.Id == id);
        }
        /// <summary>
        /// update storage info
        /// </summary>
        /// <param name="updateStorageInfo"></param>
        /// <returns>returns update storage info</returns>
        public StorageInfo UpdateContainers(StorageInfo updateStorageInfo)
        {
            var listItem = storageItems.SingleOrDefault(r => r.Id == updateStorageInfo.Id);
            if (listItem != null)
            {
                listItem.ContainerName = updateStorageInfo.ContainerName;
                listItem.BlobName = updateStorageInfo.BlobName;
                listItem.FileType = updateStorageInfo.FileType;
            }

            return listItem;

        }

        public ListItem Delete(int id)
        {
            var listItem = listItems.FirstOrDefault(r => r.Id == id);
            if(listItem != null)
            {
                listItems.Remove(listItem);
            }
            return listItem;
        }
    }
}
