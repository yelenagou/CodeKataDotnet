using System.Collections.Generic;
using System.Linq;
using List.Core;
using Microsoft.EntityFrameworkCore;

namespace List.Data
{
    public class SqlListData : IListItemData
    {
        private readonly ListItemsDbContext db;

        public SqlListData(ListItemsDbContext db)
        {
            this.db = db;
        }
        public ListItem Add(ListItem newListItem)
        {
            db.Add(newListItem);
            return newListItem;
        }

        public int Commit()
        {
           return db.SaveChanges();

        }

        public ListItem Delete(int id)
        {
            var listItem = GetById(id);
            if(listItem != null)
            {
                db.ListItems.Remove(listItem);
            }
            return listItem;
        }

        public ListItem GetById(int id)
        {
           return db.ListItems.Find(id);
        }

        public StorageInfo GetContainerById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ListItem> GetListItems(string listItemName)
        {
            if (listItemName != null)
            {
                return db.ListItems.Where(r => r.Name.StartsWith(listItemName));
            }
            else 
                return db.ListItems.ToList();

  
        }

        public IEnumerable<StorageInfo> GetStorageInfo(string containerName)
        {
            throw new System.NotImplementedException();
        }

        public ListItem Update(ListItem updatedListItem)
        {
            var entity = db.ListItems.Attach(updatedListItem);
            entity.State = EntityState.Modified;
           
            return updatedListItem;
        }

        public StorageInfo UpdateContainers(StorageInfo updateStorageInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}
