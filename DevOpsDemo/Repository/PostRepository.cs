using DevOpsDemo.Models;

namespace DevOpsDemo.Repository
{
    public class PostRepository : IPostRepository
    {
        public List<PostViewModel> GetPosts()
        {
            var posts = new List<PostViewModel>
            {
                new PostViewModel(){PostId =101, Title = "DevOps Demo Title 1", Description ="DevOps Demo Description 1", Author="Prithvi Singh"},
                new PostViewModel(){PostId =102, Title = "DevOps Demo Title 2", Description ="DevOps Demo Description 2", Author="Ankit Jain"},
                new PostViewModel(){PostId =103, Title = "DevOps Demo Title 3", Description ="DevOps Demo Description 3", Author="Rahul Agarwal"},
                new PostViewModel(){PostId =104, Title = "DevOps Demo Title 4", Description ="DevOps Demo Description 4", Author="Ramesh kumar"}
            };
            return posts;
        }
    }
}
