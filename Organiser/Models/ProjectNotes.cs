using System;

namespace Organiser.Models
{
    public class ProjectNotes
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return $"({Created.ToString(Constants.StandardDateTimeFormat)}): {Content}";
        }
    }
}
