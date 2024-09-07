using System;
using System.Collections.Generic;
using System.Text;
using ProducrManagmentAPI.Localization;
using Volo.Abp.Application.Services;

namespace ProducrManagmentAPI;

/* Inherit your application services from this class.
 */
public abstract class ProducrManagmentAPIAppService : ApplicationService
{
    protected ProducrManagmentAPIAppService()
    {
        LocalizationResource = typeof(ProducrManagmentAPIResource);
    }
}
