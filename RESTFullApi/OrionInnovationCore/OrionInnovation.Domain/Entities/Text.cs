using System;

namespace OrionInnovation.Domain
{
    public class Text
    {
        public string Content { get; }

        private Text(string content)
        {
            Content = content;
        }

        public Text Create(string content) 
        {
            return new Text(content);
        }
    }
}
