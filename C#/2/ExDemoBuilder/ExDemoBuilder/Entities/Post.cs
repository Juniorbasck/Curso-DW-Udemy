using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExDemoBuilder.Entities
{
    internal class Post
    {

        public DateTime Moment { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public int Likes { get; set; }

        public List<Commennt> Commennts{ get; set;} = new List<Commennt>();

        public Post() 
        {
        
        }

        public Post(DateTime moment, string title, string content, int likes, List<Commennt> commennts)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Commennt comment)
        {
            Commennts.Add(comment);
        }

        public void RemoveComment(Commennt comment)
        {
            Commennts.Remove(comment);
        }
    }
}
