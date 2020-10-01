using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Model
{
    public class ToDo
    {
        //Requiredprivatefields
        int toDoId;
        string description;
        bool done = true;
        Person assignee;

        // constructor
        public ToDo(int toDoId, string description)
        {
            this.toDoId = toDoId;
            this.description = description;
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
            return $"ToDo id: {toDoId} \n\nDescription: {description}\n\n";
        }
    }
}
