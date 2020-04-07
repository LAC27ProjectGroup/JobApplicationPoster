using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JobApplicationPoster.ViewComponents
{
    public class StudentStickerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(int id)
        {
            return Task.FromResult<IViewComponentResult>(View("StickerLayout", id));
        }
    }
}
