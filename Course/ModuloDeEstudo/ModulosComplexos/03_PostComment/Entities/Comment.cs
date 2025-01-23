using Course.Entities; 

namespace Course.ModuloDeEstudo.ModulosComplexos._03_PostComment.Entities
{
    internal class Comment
    {
        public string Text { get; set; }

        public Comment()
        {
        }
        public Comment(string text)
        {
            Text = text;
        }
    }
}
