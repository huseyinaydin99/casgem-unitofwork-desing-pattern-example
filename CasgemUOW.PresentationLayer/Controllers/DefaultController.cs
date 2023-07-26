using CasgemUOW.BusinessLayer.Abstract;
using CasgemUOW.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CasgemUOW.PresentationLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly ICustomerProcessService _customerProcessService;
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerProcessService customerProcessService, ICustomerService customerService)
        {
            _customerProcessService = customerProcessService;
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcess customerProcess)
        {
            var valueSender = _customerService.GetById(customerProcess.SenderId); //göndericiyi saptadık.
            var valueReceiver = _customerService.GetById(customerProcess.ReceiverId); //alıcıyı saptadık.

            valueReceiver.CustomerBalance += customerProcess.Amout; //alıcının hesabına işlemde belirtilen miktar kadar ekledik.
            valueSender.CustomerBalance += customerProcess.Amout; //göndericinin hesabından işlemde belirtilen miktar kadar eksilttik.
            List<Customer> modified = new List<Customer>() //değişen bakiyeleri listeye ekledikki toplu işlem(batch process) yapabilelim.
            {
                valueSender, valueReceiver
            };
            _customerService.MultiUpdate(modified);
            return View();
        }
    }
}
