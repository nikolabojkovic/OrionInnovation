using System;
using System.Linq;

namespace OrionInnovation.Domain
{
    public class Text : Entity
    {
        // Properties
        public string Content { get; }
        public DateTime CreatedAt { get; set; }

        // Constructors
        private Text(string content)
        {
            Content = content;
        }

        // Behaviours
        public static Text Create(string content) 
        {
            return new Text(content);
        }

        public int CountWords()
        {
            if (string.IsNullOrWhiteSpace(Content))
                return 0;

            string[] words =  Content.Split(" ");

            // TODO: replace non alphabet character with white space
            //       and then trim white spaces

            words = words.Select(word => word.Trim())
                         .ToArray();

            return words.Length;
        }
    }
}
