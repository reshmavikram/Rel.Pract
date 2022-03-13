using System;
using System.Collections.Generic;
using System.Text;
using Rel.Pract.Localization;
using Volo.Abp.Application.Services;

namespace Rel.Pract;

/* Inherit your application services from this class.
 */
public abstract class PractAppService : ApplicationService
{
    protected PractAppService()
    {
        LocalizationResource = typeof(PractResource);
    }
}
