using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace OrionInnovation.Domain
{
    public class Text : Entity
    {
        // Properties
        public string Content { get; private set; }
        public DateTime CreatedAt { get; private set; }

        // Constructors
        private Text() {}

        // Behaviours
        public static Text Create(string content, DateTime createdAt) 
        {
            return new Text { 
                Content = content,
                CreatedAt = createdAt
            };
        }

        public int CountWords()
        {
            if (string.IsNullOrWhiteSpace(Content))
                return 0;

            string text = Content;

            // Remove non-alphanumeric characters
            text = Regex.Replace(text, "\\W+", " ");

            // Trim extra white spaces and split text on white space
            string[] words =  text.Trim().Split(" ");

            return words.Length;
        }
    }
}
