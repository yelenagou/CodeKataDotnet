using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using List.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CodeKata_OnPost.Pages.Storage
{
    public class DetailModel : PageModel
    {
        public StorageInfo StorageInfo { get; set; }

        public void OnGet()
        {

        }
    }
}