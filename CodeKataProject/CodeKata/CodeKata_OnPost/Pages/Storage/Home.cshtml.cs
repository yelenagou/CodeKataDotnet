using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List.Core;
using List.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeKata_OnPost.Pages.Storage
{
    public class HomeModel : PageModel
    {
        //Inject the service
        private readonly IListItemData listItemData;
        public HomeModel(IListItemData listItemData)
        {
            this.listItemData = listItemData;
        }

        public IEnumerable<StorageInfo> StorageInfo { get; set; }
        public string containerName = "";
        public void OnGet()
        {

            StorageInfo = listItemData.GetStorageInfo(containerName);
        }
    }
}