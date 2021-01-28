using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Backend.ViewModels;

namespace Backend.Data
{
    public interface IHomeServices
    {
        Task<List<MyXp>> GetAllXp();

        Task<List<Projects>> GetAllProjects();

        Task CreatePost(Post post);

        Task<string> UploadImage(IFormFile Image);

        void DeleteImage(string ImageName);

        Task<Post> GetPost(int id);

        Task<List<GetAllPostViewModel>> GetAllPost(int pageId = 1, int take = 0);
        
        Task<int> PageCount();

        Task DeletePost(Post post);

        Task UpdatePost(Post post);
        
        Task AddProject(Projects project);
        
        Task<Projects> GetFirstProject(string status, string? url);
        
        Task DeleteProject(Projects project);
        
        Task AddComment(Comments comment);

        Task<List<Comments>> GetAllComment();
        
        Task<List<Comments>> GetAllCommentInAdmin();
        Task DeleteComment(int id);
        Task OkComment(int id);
    }
}