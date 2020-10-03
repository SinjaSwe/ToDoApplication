using System;
using ToDoApplication.Model;
using System.Collections.Generic;
using System.Text;

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
                if (arrayOfToDos[i].ToDoId == toDoId)
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


        public void ClearToDo() //f.Add a method public void Clear()that clears all Person objects from the Person array.
        {
            Array.Clear(arrayOfToDos, 0, arrayOfToDos.Length);
        }
    }
}
