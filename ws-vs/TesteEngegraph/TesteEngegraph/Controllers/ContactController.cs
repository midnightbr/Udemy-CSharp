using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TesteEngegraph.Models;
using TesteEngegraph.Services;

namespace TesteEngegraph.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contatoService;
        private readonly ITypeService _tipoService;

        public ContactController(IContactService contatoService, ITypeService tipoService)
        {
            _contatoService = contatoService;
            _tipoService = tipoService;
        }

        public IActionResult Index()
        {
            Common common = new Common();
            common.ListContacts = _contatoService.GetAll();
            common.ListTypes = _tipoService.GetAll();

            return View(common);
        }

        public IActionResult List()
        {
            return PartialView();
        }


        [HttpPost]
        public IActionResult Create(Contact contato)
        {
            _contatoService.Insert(contato);
            return RedirectToAction("Index");
        }
    }
}
