using Domain;

namespace Infrastructure;

public class PostService
{
public List<Post> _posts=new List<Post>();

public List<Post> GetPost()
{
    return _posts;
}

public void AddPost(Post post)
{
    _posts.Add(post);
}


public void UpdatePost(Post post)
{
    foreach (var item in _posts)
    {
        if (item.Id==post.Id)
        {
            item.Title=post.Title;
            item.Description=post.Description;
            item.VoteAmount=post.VoteAmount;
            item.CreatedAt=post.CreatedAt;
            break;
        }
    }
}

public void DeletePost(int id)
{
    foreach (var item in _posts)
    {
        if (item.Id==id)
        {
            _posts.Remove(item);
        break;
        }
    }
}



}

