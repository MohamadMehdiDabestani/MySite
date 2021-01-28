using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Backend.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace Backend.Data
{
    public class HomeServices : IHomeServices
    {
        private readonly Context _db;
        public HomeServices(Context db)
        {
            this._db = db;
        }

        public async Task AddProject(Projects project)
        {
            await _db.AddAsync(project);
            await _db.SaveChangesAsync();
        }

        public async Task<int> PageCount()
        {
            return await _db.Post.CountAsync();
        }

        public async Task CreatePost(Post post)
        {
            await _db.Post.AddAsync(post);
            await _db.SaveChangesAsync();
        }

        public void DeleteImage(string ImageName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PostImages", ImageName);
            if (File.Exists(path))
                File.Delete(path);

        }

        public async Task DeletePost(Post post)
        {
            _db.Remove(post);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteProject(Projects project)
        {
            _db.Remove(project);
            await _db.SaveChangesAsync();
        }
        public async Task<List<GetAllPostViewModel>> GetAllPost(int take, int pageId = 1)
        {
            if (take == 0)
                take = 3;
            int skip = (pageId - 1) * take;
            return await _db.Post.OrderBy(p => p.CreateData).Select(p => new GetAllPostViewModel
            {
                AltImage = p.AltImage,
                Description = p.Description,
                id = p.PostId,
                ImageName = p.imageName,
                Title = p.Title,
            }).Skip(skip).Take(take).ToListAsync();
        }

        public async Task<List<Projects>> GetAllProjects()
        {

            return await _db.Prjects.ToListAsync();
        }

        public async Task<List<MyXp>> GetAllXp()
        {
            return await _db.MyXp.ToListAsync();
        }

        public async Task<Projects> GetFirstProject(string status, string? url)
        {
            return await _db.Prjects.FirstOrDefaultAsync(p => p.Status == status && p.Url == url);
        }

        public async Task<Post> GetPost(int id)
        {
            return await _db.Post.FindAsync(id);
        }

        public async Task UpdatePost(Post post)
        {
            _db.Update(post);
            await _db.SaveChangesAsync();
        }

        public async Task<string> UploadImage(IFormFile Image)
        {
            var imageSaveName = Guid.NewGuid().ToString() + Path.GetFileName(Image.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PostImages", imageSaveName);
            using (var streame = new FileStream(path, FileMode.Create))
            {
                await Image.CopyToAsync(streame);
            }
            return imageSaveName;
        }

        public async Task AddComment(Comments comment)
        {
            await _db.Comment.AddAsync(comment);
            await _db.SaveChangesAsync();
        }

        public async Task<List<Comments>> GetAllComment()
        {
            return await _db.Comment.Where(c => c.IsShowing == true).ToListAsync();
        }

        public async Task<List<Comments>> GetAllCommentInAdmin()
        {
            return await _db.Comment.Where(c=> c.IsShowing == false).ToListAsync();
        }

        public async Task DeleteComment(int id)
        {
            var comment = await _db.Comment.FindAsync(id);
            _db.Comment.Remove(comment);
            await _db.SaveChangesAsync();
        }

        public async Task OkComment(int id)
        {
            var comment = await _db.Comment.FindAsync(id);
            comment.IsShowing = true;
            _db.Comment.Update(comment);
            await _db.SaveChangesAsync();
        }
    }
}