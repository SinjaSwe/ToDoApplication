using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Model
{
    public class ToDo
    {
        //Requiredprivatefields
        readonly int toDoId;
        string description;
        bool done;
        Person assignee;

        public int TodoId { get { return toDoId; } }
        public bool Done { get { return done; } }
        public Person Assignee { get { return assignee; } }

        // constructor 
        public ToDo(int toDoId, string description)
        {
            this.toDoId = toDoId;
            this.description = description;
        }

        // constructor to include done and assignee. 
        public ToDo(int toDoId, string description, bool done, Person assignee)
           : this(toDoId, description)
        {
            this.done = done;
            this.assignee = assignee;
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))

                {
                    throw new ArgumentException("Description is null, empty or consists only of white space.");
                }
                else
                {
                    description = value;
                }
            }
        }

        public string ToDoInformation()
        {
            return $"ToDo id: {toDoId} \n\nDescription: {description}\n\nAssignee:{assignee}\n\nDone: {done}";
        }
    }
}
