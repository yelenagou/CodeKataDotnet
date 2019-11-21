using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List.Core;
using List.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CodeKata_OnPost.Pages.Storage
{
    public class UpdateModel : PageModel
    {
        private readonly IListItemData listItemData;
        private readonly IHtmlHelper htmlHelper;
        [BindProperty]
        public StorageInfo StorageInfo { get; set; }
        public IEnumerable<SelectListItem> FileTypes { get; set; }
        public UpdateModel(IListItemData listItemData, IHtmlHelper htmlHelper)
        {
            this.listItemData = listItemData;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int containerId)
        {
            StorageInfo = listItemData.GetContainerById(containerId);
            FileTypes = htmlHelper.GetEnumSelectList<FileType>();
            if(StorageInfo == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            FileTypes = htmlHelper.GetEnumSelectList<FileType>();
            if (ModelState.IsValid)
            {
                StorageInfo = listItemData.UpdateContainers(StorageInfo);
                listItemData.Commit();
                return RedirectToPage("./Detail", new { containerId = StorageInfo.Id });
            }
            return Page();
           
        }
    }   
}
