using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List.Core;
using List.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeKata_ModelBinding.Pages.List
{
    public class ListItemsModel : PageModel
    {
        private readonly IListItemData listItemData;
        public IEnumerable<ListItem> ListOfItems { get; set; } 
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public ListItemsModel(IListItemData listItemData)
        {
            this.listItemData = listItemData;
        }
        public string Message { get; set; }
        public void OnGet()
        {
            ListOfItems = listItemData.GetListItems(SearchTerm);
            
        }
    }
}