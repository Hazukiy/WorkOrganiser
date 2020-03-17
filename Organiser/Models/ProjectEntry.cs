using Organiser.Models.Enums;
using System;

namespace Organiser.Models
{
    public class ProjectEntry
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Comments { get; set; }
        public DateTime DateCreated { get; set; }
        public ProjectState State { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Title} : {State}";
        }
    }
}
