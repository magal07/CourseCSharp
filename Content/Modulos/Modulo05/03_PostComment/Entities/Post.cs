using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.ModuloDeEstudo.ModulosComplexos._03_PostComment.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int  Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>(); // pra garantir que a lista será instânciada acrescentar o new List<Comment>();

        public Post() 
        { 
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comments)
        {
            Comments.Add(comments);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
                        /// USANDO STRING BUILDER PARA MONTAR UM TOSTRING MAIS EFICIENTE E COMPLEXO /// 

            StringBuilder sb = new StringBuilder(); // pertence ao namespace System.Text 
            sb.AppendLine(Title);
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments: ");

            foreach (Comment c in Comments) // pra cada comentário c da minha lista comment
            {
                sb.AppendLine(c.Text);
            }
            return sb.ToString();
        }
    }
}
