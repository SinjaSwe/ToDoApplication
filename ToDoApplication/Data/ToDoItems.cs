using System;
using ToDoApplication.Model;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata.Ecma335;

namespace ToDoApplication.Data
{
    public class ToDoItems
    {
        
        ToDo[] arrayOfToDos = new ToDo[0]; //a. Have a private static Person arraydeclared and instantiated as empty and not null(new Person[0]).

        public int Size() //b.Add a method publicint Size()that return the length of the array.
        {
            int size = arrayOfToDos.Length;
            return size;
        }

        public ToDo[] FindAll() // c.Add a method public Person[] FindAll()that return the Person array.
        {
            return arrayOfToDos;
        }

        public ToDo FindToDoById(int toDoId) //d.Add a method public Person FindById(int personId)that return the person that has a matching personId as the passed in parameter.
        {
            for (int i = 0; i < arrayOfToDos.Length; i++)
            {
                if (arrayOfToDos[i].TodoId == toDoId)
                {
                    return arrayOfToDos[i];
                }
            }
            return null;
        }

        public ToDo AddNewToDo(int toDoId, string description) //e.Add a method that creates a new Person, adds the newly created object in the array and then return the created object.
        {
            ToDo newToDo = new ToDo(TodoSequencer.NextToDo(), description);

            Array.Resize(ref arrayOfToDos, arrayOfToDos.Length + 1);

            arrayOfToDos[arrayOfToDos.Length - 1] = newToDo;

            return newToDo;
        }

        public ToDo AddNewToDoNew(int toDoId, string description, bool done, Person assignee) //e.Add a method that creates a new Person, adds the newly created object in the array and then return the created object.
        {
            ToDo newToDo = new ToDo(TodoSequencer.NextToDo(), description, done, assignee);

            Array.Resize(ref arrayOfToDos, arrayOfToDos.Length + 1);

            arrayOfToDos[arrayOfToDos.Length - 1] = newToDo;

            return newToDo;
        }

        public void ClearToDo() //f.Add a method public void Clear()that clears all Person objects from the Person array.
        {
            Array.Clear(arrayOfToDos, 0, arrayOfToDos.Length);
        }

        public ToDo[] FindByDoneStatus() //Returns array with objects that has a matching done status.
        {
            bool done = true;
            ToDo[] doneArray = new ToDo[0];

            for (int i = 0; i < arrayOfToDos.Length; i++)
            {
                if (arrayOfToDos[i].Done == done)
                {
                    Array.Resize(ref doneArray, doneArray.Length + 1);
                    doneArray[doneArray.Length - 1] = arrayOfToDos[i];
                }
            }
            return doneArray; 
        }

        public ToDo[] FindByAssignee(int personId) //Returns array with objects that has an assignee with a personId matching.
        {
            ToDo[] assigneArray = new ToDo[0];

            for (int i = 0; i < assigneArray.Length; i++)
            {
                if (arrayOfToDos[i].Assignee.PersonId == personId)
                {
                    Array.Resize(ref assigneArray, assigneArray.Length + 1);
                    assigneArray[assigneArray.Length - 1] = assigneArray[i];

                }
            }
            return assigneArray; 
        }

        public ToDo[] FindByFirstname(string firstname)//public Todo[] FindByAssignee(Person assignee)–Returnsarray with objects that has sent in Person.Checking by firstname
        {
            ToDo[] firstnameArray = new ToDo[0];

            for (int i = 0; i < firstnameArray.Length; i++)
            {
                if (firstnameArray[i].Assignee.Firstname == firstname)
                {
                    Array.Resize(ref firstnameArray, firstnameArray.Length + 1);
                    firstnameArray[firstnameArray.Length - 1] = firstnameArray[i]; 
                }
            }
            return firstnameArray;
        }

        public ToDo [] FindByLastname(string lastname)
        {
            ToDo[] lastnameArray = new ToDo[0];

            for (int i = 0; i < lastnameArray.Length; i++)
            {
                if(lastnameArray[i].Assignee.Firstname == lastname)
                {
                    Array.Resize(ref lastnameArray, lastnameArray.Length + 1);
                    lastnameArray[lastnameArray.Length - 1] = lastnameArray[i];
                }
            }
            return lastnameArray; 
        }

        public ToDo[] FindUnassignedTodoItems()
        {
            ToDo[] unasssignedArray = new ToDo[0];

            for (int i = 0; i < unasssignedArray.Length; i++)
            {
                if (unasssignedArray[i].Assignee.Firstname == null)
                {
                    Array.Resize(ref unasssignedArray, unasssignedArray.Length + 1);
                    unasssignedArray[unasssignedArray.Length - 1] = unasssignedArray[i];
                }
            }
            return unasssignedArray;
        }

        public void RemoveToDoObject(int toDoId) //Remove int a todo from array
        {
            for (int i = 0; i < arrayOfToDos.Length; i++)
            {
                if (arrayOfToDos[i].TodoId == toDoId)
                {
                    for (int a = i; a < arrayOfToDos.Length - 1; a++)
                    {
                        arrayOfToDos[a] = arrayOfToDos[a + 1];
                    }                   

                    Array.Resize(ref arrayOfToDos, arrayOfToDos.Length - 1);
                }
            }
        }
    }

}
