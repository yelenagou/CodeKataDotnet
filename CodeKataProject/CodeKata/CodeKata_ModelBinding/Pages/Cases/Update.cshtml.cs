using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List.Core;
using List.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeKata_ModelBinding.Pages.Cases
{
    public class UpdateModel : PageModel
    {
        private readonly IListItemData listItemData;
        private readonly IHtmlHelper htmlHelper;
        [BindProperty]
        public ListItem ListItem { get; set; }  
        public IEnumerable<SelectListItem> ListItemTypes { get; set; }

        public UpdateModel(IListItemData listItemData, IHtmlHelper htmlHelper)
        {
            this.listItemData = listItemData;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int listItemId)
        {
            ListItemTypes = htmlHelper.GetEnumSelectList<ListItemType>();
            ListItem = listItemData.GetById(listItemId);
            if(ListItemTypes == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
    }
}