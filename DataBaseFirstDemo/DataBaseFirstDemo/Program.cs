using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataBaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new DatabaseFirstDemoEntities();
            var post = new Post()
            {
                Body = "Body of the post which we want to publish",
                DatePublished = DateTime.Now,
                Title="My First Post",
                PostID=1
                
            };
            context.Posts.Add(post);//adding post object to the DbSet object
            context.SaveChanges();//Will commit changes to the Database
        }
    }
}
