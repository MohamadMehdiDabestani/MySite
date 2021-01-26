using System.Runtime.InteropServices;
using System;
using Backend.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Linq;
using Backend.ViewModels;

namespace Backend.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeServices _service;
        public HomeController(IHomeServices service)
        {
            this._service = service;
        }
        public async Task<ActionResult> Index(int pageid = 1)
        {
            // Post and paggination
            ViewBag.ListPost = await _service.GetAllPost(3,pageid);
            ViewBag.pageCount = await _service.PageCount() / 3;
            ViewBag.PageId = pageid;

            // Xp view bag
            ViewBag.ListXp = await _service.GetAllXp();

            // Projects view bags
            var ListProject = await _service.GetAllProjects();
            ViewBag.ProjectSucces = ListProject.Where(p => p.Status == "Complete").Count();
            ViewBag.ProjectWorking = ListProject.Where(p => p.Status == "Working").Count();
            ViewBag.ProjectFaild = ListProject.Where(p => p.Status == "Faild").Count();
            ViewBag.ProjectSuccesUrl = ListProject.Where(p => p.Status == "Complete").Select(p => p.Url).ToList();
            return View();
        }
        public ActionResult PageNotFound()
        {
            return View();
        }
        [Route("/Post/{id}")]
        public async Task<ActionResult> GetPost(int id)
        {
            var post = await _service.GetPost(id);
            if (post == null)
            {
                return NotFound();
            }
            var model = new GetPostViewModel
            {
                CreateDate = post.CreateData.ToShamsi(),
                AltImage = post.AltImage,
                Category = post.Category,
                Description = post.Description,
                id = post.PostId,
                Tags = post.Tags.Split("-").ToList(),
                ImageName = post.imageName,
                Text = post.Text,
                Title = post.Title,
            };
            return View(model);
        }
    }
}