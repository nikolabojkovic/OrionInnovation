using System;
using System.Linq;

namespace OrionInnovation.Domain
{
    public class Text
    {
        public string Content { get; }

        private Text(string content)
        {
            Content = content;
        }

        public static Text Create(string content) 
        {
            return new Text(content);
        }

        public int CountWords()
        {
            return Content.Count();
        }
    }
}
