namespace LTPTranslations.Web.Areas.Administration.Controllers
{
    using LTPTranslations.Common;
    using LTPTranslations.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
