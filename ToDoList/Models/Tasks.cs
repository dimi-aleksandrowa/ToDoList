using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class Tasks
    {
        private string Name { get; set; }
        private Status Stat { get; set; }
        private string Description { get; set; }
        private DateTime DateCreated { get; set; }
        private DateTime DateModified { get; set; }

        /*
        private Status stat;
        private string description;
        private DateTime dateCreated;
        private DateTime dateModified;

        public Tasks()
        { }

        public Tasks(string description)
        {
            description = this.description;
        }

        public Status Stat
        {
            get { return stat; }
            set { stat = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        public DateTime DateModified
        {
            get { return dateModified; }
            set { dateModified = value; }
        }
        */
    }
}
