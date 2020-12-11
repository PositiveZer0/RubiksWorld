namespace RubiksWorld.Web.Areas.Administration.Controllers
{
    using RubiksWorld.Common;
    using RubiksWorld.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
