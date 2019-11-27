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
        public IActionResult OnGet(int? listItemId)
        {
            ListItemTypes = htmlHelper.GetEnumSelectList<ListItemType>();
            if (listItemId.HasValue)
            {
                ListItem = listItemData.GetById(listItemId.Value);
            }
            else
            {
                ListItem = new ListItem();

            }
            if(ListItemTypes == null)
            {
                return RedirectToPage("./NotFound");
            }

            return Page();
        }
        public IActionResult OnPost()
        {
           
            if (!ModelState.IsValid)
            {
                ListItemTypes = htmlHelper.GetEnumSelectList<ListItemType>();
                return Page();
                
            }
            if(ListItem.Id > 0)
            {
                ListItem = listItemData.Update(ListItem);
            }
           else
            {
                listItemData.Add(ListItem);
            }
            listItemData.Commit();
            TempData["Message"] = $"List Itemis saved";
            return RedirectToPage("./Details", new { listItemId = ListItem.Id });

        }
    }
}