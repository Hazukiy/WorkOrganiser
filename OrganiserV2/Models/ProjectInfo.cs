using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganiserV2.Models
{
    public class ProjectInfo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public string Comments { get; set; }
        public DateTime DateCreated { get; set; }
        public ProjectState State { get; set; }
        public ConnectionDetails Details { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Title}";
        }
    }

    public class ConnectionDetails
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ExtraValue { get; set; }
    }

    public enum ProjectState
    {
        None = 0,
        Active = 1,
        Blocked = 2,
        Complete = 3,
        Validation = 4
    }
}
