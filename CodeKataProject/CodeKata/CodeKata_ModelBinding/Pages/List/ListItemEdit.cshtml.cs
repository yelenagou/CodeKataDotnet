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
    public class ListItemEditModel : PageModel
    {
        private readonly IListItemData listItemData;
        private readonly IHtmlHelper htmlHelper;
        [BindProperty]
        public ListItem ListItem { get; set; }
        public IEnumerable<SelectListItem> ListItemTypes { get; set; }
        public ListItemEditModel(IListItemData listItemData, IHtmlHelper htmlHelper)
        {
            this.listItemData = listItemData;
            this.htmlHelper = htmlHelper;
        }
            
        public IActionResult OnGet(int listItemId)
        {
            ListItem = listItemData.GetById(listItemId);
            ListItemTypes = htmlHelper.GetEnumSelectList<ListItemType>();
            if (ListItem == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                ListItem = listItemData.Update(ListItem);
                listItemData.Commit();
                return RedirectToPage("./ListItemDetails", new { listItemId = ListItem.Id });
            }
            ListItemTypes = htmlHelper.GetEnumSelectList<ListItemType>();
          
            return Page();
        }
    }
}