using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List.Core;
using List.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeKata_ModelBinding.Pages.List
{
    public class ListItemDetailsModel : PageModel
    {
        private readonly IListItemData listItemData;
        private readonly IHtmlHelper htmlHelper;

        public ListItemDetailsModel(IListItemData listItemData, IHtmlHelper htmlHelper)
        {
            this.listItemData = listItemData;
            this.htmlHelper = htmlHelper;
        }
        public ListItem ListItem { get; set; }
        public IEnumerable<SelectListItem> ListItemTypes { get; set; }
        public IActionResult OnGet(int listItemId)
        {
            ListItem = listItemData.GetById(listItemId);
           
            if(ListItem == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
            //ListItem.Id = listItemId;
        }
    }
}