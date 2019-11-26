using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List.Core;
using List.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeKata_ModelBinding.Pages.Cases
{
    public class ListModel : PageModel
    {
        private readonly IListItemData listItemData;
        public IEnumerable<ListItem> ListItems { get; set; }


        public ListModel(IListItemData listItemData)
        {
            this.listItemData = listItemData;
        }
        public void OnGet()
        {
            string listItem = null;
            ListItems = listItemData.GetListItems(listItem);   
        }
    }
}