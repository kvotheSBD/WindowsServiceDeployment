using DotNetCoreApp.Models;
using DotNetCoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreApp.Controllers
{
    public class MainController : Controller
    {
        private readonly IMemberRepository _memberRepository;

        public MainController(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public ViewResult Index()
        {
            var model =  _memberRepository.GetAllMembers();
            return View(model);
        }

        public ViewResult Details(int? id)
        {
            MainDetailsViewModel mainDetailsViewModel = new MainDetailsViewModel()
            {
                Member = _memberRepository.GetMemberById(id??1),
                PageTitle = "Información detallada"
            };
            return View(mainDetailsViewModel);
        }
    }
}
