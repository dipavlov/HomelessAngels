namespace HomelessAngels.Web.Areas.Administration.Controllers
{
    using HomelessAngels.Common;
    using HomelessAngels.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
