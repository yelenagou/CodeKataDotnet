using List.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeKata_ModelBinding.ViewComponents
{
    public class ListCountViewComponent : ViewComponent
    {
        private readonly IListItemData listItemData;

        public ListCountViewComponent(IListItemData listItemData)
        {
            this.listItemData = listItemData;
        }
        public IViewComponentResult Invoke()
        {
            var count =  listItemData.GetCountOfItems();
            return View(count);
        }
    }
}
