﻿using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using EasyAbp.CacheManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.CacheManagement.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits EasyAbp.CacheManagement.Web.Pages.CacheManagementPage
     */
    public abstract class CacheManagementPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<CacheManagementResource> L { get; set; }
    }
}
