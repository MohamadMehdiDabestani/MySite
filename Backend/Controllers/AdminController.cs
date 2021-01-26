using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Drawing;
using System;
using Microsoft.AspNetCore.Mvc;
using Backend.ViewModels;
using Backend.Data;

namespace Backend.Controllers
{
    public class AdminController : Controller
    {
        private readonly IHomeServices _services;
        public AdminController(IHomeServices services)
        {
            this._services = services;
        }

        #region Post
        public ActionResult CreatePost()
        {
            return View();
        }
        [HttpPost]
        [Route("/Admin/CreatePost")]
        public async Task<ActionResult> CreatePost(CreatePostViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var newPost = new Post
            {
                AltImage = model.AltImage,
                Category = model.Category,
                CreateData = DateTime.Now,
                Description = model.Description,
                imageName = await _services.UploadImage(model.Image),
                Tags = model.Tags,
                Text = model.Text,
                Title = model.Title,
            };
            await _services.CreatePost(newPost);
            return Redirect("/");
        }
        [Route("/Admin/EditePost/{id}")]
        public async Task<ActionResult> EditePost(int id)
        {
            var post = await _services.GetPost(id);
            if (post == null)
            {
                return NotFound();
            }
            var model = new EditePostViewModel
            {
                AltImage = post.AltImage,
                Category = post.Category,
                Description = post.Description,
                id = post.PostId,
                ImageName = post.imageName,
                Tages = post.Tags,
                Text = post.Text,
                Title = post.Title
            };
            return View(model);
        }
        [HttpPost]
        [Route("/Admin/EditePost/{id}")]
        public async Task<ActionResult> EditePost(EditePostViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            var post = await _services.GetPost(model.id);
            if (post == null)
            {
                return NotFound();
            }
            if (model.NewImage != null)
            {
                _services.DeleteImage(post.imageName);
                post.imageName = await _services.UploadImage(model.NewImage);
            }
            post.Title = model.Title;
            post.Description = model.Description;
            post.AltImage = model.AltImage;
            post.Text = model.Text;
            post.Tags = model.Tages;
            post.Category = model.Category;
            await _services.UpdatePost(post);
            return Redirect("/");
        }
        public async Task<ActionResult> DeletePost(int id)
        {
            var post = await _services.GetPost(id);
            if (post == null)
                return NotFound();
            await _services.DeletePost(post);
            return Redirect("/");
        }
        #endregion
        #region Project
        [HttpPost]
        public async Task<ActionResult> AddOrDeleteProject(AddProject model)
        {
            if (model.isDelete)
            {
                var project = await _services.GetFirstProject(model.Status, model.URL);
                if (project != null)
                {
                    await _services.DeleteProject(project);
                    return Redirect("/");
                }
                return NotFound();
            }
            var NewProject = new Projects
            {
                Status = model.Status,
                Url = model.URL
            };
            await _services.AddProject(NewProject);
            return Redirect("/");
        }
        #endregion
    }
}