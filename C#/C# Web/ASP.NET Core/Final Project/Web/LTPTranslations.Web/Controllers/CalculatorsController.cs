namespace LTPTranslations.Web.Controllers
{
    using System.Threading.Tasks;

    using LTPTranslations.Services.Data.Orders;
    using LTPTranslations.Web.ViewModels.Calculator;
    using LTPTranslations.Web.ViewModels.ViewModels.Calculator;
    using Microsoft.AspNetCore.Mvc;

    public class CalculatorsController : Controller
    {
        private readonly IOrderTypeService orderTypeService;
        private readonly IDocumentTypeService documentTypeService;
        private readonly IOrderFullfillmentTypeService orderFullfilmentTypeService;
        private readonly ILanguageFromService languageFromService;
        private readonly ILanguageToTypeService languageToService;
        private readonly IWaysToReceiveTypeService waysToReceiveTypeService;
        private readonly IOfferService offerService;

        public CalculatorsController(
            IOrderTypeService orderTypeService,
            IDocumentTypeService documentTypeService,
            IOrderFullfillmentTypeService orderFullfilmentTypeService,
            ILanguageFromService languageFromService,
            ILanguageToTypeService languageToService,
            IWaysToReceiveTypeService waysToReceiveTypeService,
            IOfferService offerService)
        {
            this.orderTypeService = orderTypeService;
            this.documentTypeService = documentTypeService;
            this.orderFullfilmentTypeService = orderFullfilmentTypeService;
            this.languageFromService = languageFromService;
            this.languageToService = languageToService;
            this.waysToReceiveTypeService = waysToReceiveTypeService;
            this.offerService = offerService;
        }

        public IActionResult Index()
        {
            var viewModel = new CalculatorOptionsInputModel();
            viewModel.OrderTypeItems = this.orderTypeService.GetAllOrderTypes();
            viewModel.DocumentTypeItems = this.documentTypeService.GetAllDocumentTypes();
            viewModel.OrderFullfilmentTypeItems = this.orderFullfilmentTypeService.GetAllFullfillmentTypes();
            viewModel.LanguageFromItems = this.languageFromService.GetAllLanguagesFromTypes();
            viewModel.LanguageToItems = this.languageToService.GetAllLanguagesToTypes();
            viewModel.WayToReceiveItems = this.waysToReceiveTypeService.GetWaysOfReceivingTypes();

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(CalculatorOptionsInputModel input)
        {
            var languageFrom = this.languageFromService.GetAllLanguagesFromTypes();
            var languageTo = this.languageToService.GetAllLanguagesToTypes();

            if (!this.ModelState.IsValid || languageFrom == languageTo)
            {
                input.OrderTypeItems = this.orderTypeService.GetAllOrderTypes();
                input.DocumentTypeItems = this.documentTypeService.GetAllDocumentTypes();
                input.OrderFullfilmentTypeItems = this.orderFullfilmentTypeService.GetAllFullfillmentTypes();
                input.LanguageFromItems = this.languageFromService.GetAllLanguagesFromTypes();
                input.LanguageToItems = this.languageToService.GetAllLanguagesToTypes();
                input.WayToReceiveItems = this.waysToReceiveTypeService.GetWaysOfReceivingTypes();

                return this.View(input);
            }

            var offerId = await this.offerService.CreateAsync(input);

            return this.RedirectToAction("Offer", new { id = offerId });
        }

        public IActionResult Offer(string id)
        {
            var viewModel = this.offerService.GetById(id);

            return this.View(viewModel);
        }
    }
}
