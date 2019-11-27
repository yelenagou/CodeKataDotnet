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
    public class DetailsModel : PageModel
    {
        private readonly IListItemData listItemData;
        [TempData]
        public string Message { get; set; }
        public ListItem ListItem { get; set; }

        public DetailsModel(IListItemData listItemData)
        {
            this.listItemData = listItemData;
        }
        public IActionResult OnGet(int listItemId)
        {
            ListItem = listItemData.GetById(listItemId);
            if(ListItem == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}