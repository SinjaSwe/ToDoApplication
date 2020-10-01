using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApplication.Data
{
    public class TodoSequencer
    {
        // private static int variable called personId

        private static int toDoID;

        // Add a static method called nextToDoId that increment and return the next personId value

        public static int NextToDo(int toDoID)
        {
            int nextToDoId;
            nextToDoId = ++toDoID;
            return nextToDoId;
        }

        //Return to zero
        public static int ResetID(int toDoId)
        {
            toDoId = 0;
            return 0;

        }
    }
}
