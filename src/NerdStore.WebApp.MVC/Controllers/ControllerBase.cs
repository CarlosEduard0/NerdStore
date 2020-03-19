using System;
using Microsoft.AspNetCore.Mvc;

namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected Guid ClienteId = Guid.Parse("7c0e3bc3-7937-4202-8832-b2bd59c3637d");
    }
}