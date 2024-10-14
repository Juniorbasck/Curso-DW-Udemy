using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Commennt c in Commennts)
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
