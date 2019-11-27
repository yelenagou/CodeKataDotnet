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
    public class DeleteModel : PageModel
    {
        private readonly IListItemData listItemData;
        public ListItem ListItem { get; set; }

        public DeleteModel(IListItemData listItemData)
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
        public IActionResult OnPost(int listItemId)
        {
            var listItems = listItemData.Delete(listItemId);
            listItemData.Commit();
            if (listItems == null)
            {
                return RedirectToPage("./NotFound");
            }
            TempData["Message"] = $"{listItems.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}