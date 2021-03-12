using Domain.MailOrder;
using Domain.MailOrder.Models;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using CustomerPortal.Models;
using System.Threading.Tasks;

namespace CustomerPortal.Controllers
{
    public class MailOrderController : Controller
    {
        private IMailOrderFacade _mailOrderFacade;

        public MailOrderController(IMailOrderFacade mailOrderFacade)
        {
            _mailOrderFacade = mailOrderFacade;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMailOrder(CreateMailOrderViewModel createMailOrderViewModel)
        {
            var createMailOrderCommand = createMailOrderViewModel.Adapt<CreateMailOrderCommand>();
            var entity = await _mailOrderFacade.CreateMailOrderAsync(createMailOrderCommand);

            return Ok(entity.Adapt<CreateMailOrderViewModel>());
        }
    }
}
