using List.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace List.Data
{
    public interface IListItemData
    {
        IEnumerable<ListItem> GetListItems(string listItem);
        ListItem GetById(int id);
        ListItem Update(ListItem updatedListItem);
        int Commit();
    }
    public class InMemoryListData : IListItemData
    {
        readonly List<ListItem> listItems;
        public InMemoryListData()
        {
            listItems = new List<ListItem>()
            {
                 new ListItem { Id = 1, Name = "Scott's Pizza", Location="Maryland", ListItemType=ListItemType.Italian},
                new ListItem { Id = 2, Name = "Cinnamon Club", Location="London", ListItemType=ListItemType.Italian},
                new ListItem { Id = 3, Name = "La Costa", Location = "California", ListItemType=ListItemType.Mexican}
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
      
    }
}
