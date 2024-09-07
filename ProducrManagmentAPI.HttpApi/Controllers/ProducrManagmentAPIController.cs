using ProducrManagmentAPI.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ProducrManagmentAPI.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ProducrManagmentAPIController : AbpControllerBase
{
    protected ProducrManagmentAPIController()
    {
        LocalizationResource = typeof(ProducrManagmentAPIResource);
    }
}
