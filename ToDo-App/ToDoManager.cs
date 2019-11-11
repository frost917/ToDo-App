using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ToDo_Console
{
    class ToDoManager
    {
        private List<ToDo> TodoList = new List<ToDo>();

        public void SetToDo(string contain)
        {
            TodoList.Add(new ToDo(contain));
        }

        public void GetToDo()
        {
            var ToDos = from item in TodoList
                        where item.IsCleared == false
                        select item;

            foreach (var items in ToDos)
            {
                Console.WriteLine($"{items.WhatToDo}");
            }
        }

        public void GetToDoCleared()
        {
            var ToDos = from item in TodoList
                        where item.IsCleared == true
                        select item;

            foreach(var items in ToDos)
            {
                Console.WriteLine(items.WhatToDo);
            }
        }

        public void SetToDoClear(int key)
        {
            try
            {
                TodoList[key - 1].IsCleared = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("잘못된 번호입니다.");
            }
        }

        public void Sort()
        {
            var sorted = from item in TodoList
                         orderby item.IsCleared 
                         select item;
            TodoList = sorted.ToList();
        }

        //debug code
        //public void GetAll()
        //{
        //    foreach (var i in TodoList)
        //        Console.WriteLine($"{i.IsCleared}: {i.WhatToDo}");
        //}

        //dummy
        //public void GetToDoSpecipic(int key)
        //{

        //}
    }
}
