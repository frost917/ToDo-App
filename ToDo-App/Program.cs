using System;

namespace ToDo_Console
{
    class Program
    {
        static void Main()
        {
            ToDoManager todo = new ToDoManager();

            ConsoleKeyInfo key;
            do
            {
                Console.WriteLine("1: 새 할일 추가 | 2: 할 일 보기 | 3: 할 일 삭제 " +
                    "| 4: 완료된 할 일 보기 | esc: 종료 | 0: 디버그");

                key = Console.ReadKey();
                switch (key.Key)
                {
                    //ToDo 추가
                     case ConsoleKey.D1:
                        {
                            Console.Clear();
                            Console.WriteLine("내용을 입력해주세요.");

                            string contain = new string(Console.ReadLine());
                            todo.SetToDo(contain);

                            Console.WriteLine("\r\n계속하려면 아무 키나 눌러주세요.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    //존재하는 ToDo 보기
                    case ConsoleKey.D2:
                        {
                            Console.Clear();
                            todo.GetToDo();
                            
                            Console.WriteLine("\r\n계속하려면 아무 키나 눌러주세요.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    //할 일 삭제
                    case ConsoleKey.D3:
                        {
                            Console.Clear();

                            todo.GetToDo();
                            Console.WriteLine("삭제할 할 일을 선택해주세요.");
                            int index = 0;
                            try
                            {
                                index = int.Parse(Console.ReadLine());
                            }
                            catch(FormatException)
                            {
                                Console.WriteLine("잘못된 값을 입력하셨습니다.");
                            }
                            todo.SetToDoClear(index);
                            Console.WriteLine("삭제되었습니다.");
                            Console.WriteLine("\r\n계속하려면 아무 키나 눌러주세요.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    //완료된 할 일
                    case ConsoleKey.D4:
                        {
                            Console.Clear();
                            todo.GetToDoCleared();

                            Console.WriteLine("\r\n계속하려면 아무 키나 눌러주세요.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    //case ConsoleKey.D0:
                    //    {
                    //        Console.Clear();
                    //        todo.GetAll();

                    //        Console.WriteLine("\r\n계속하려면 아무 키나 눌러주세요.");
                    //        Console.ReadKey();
                    //        Console.Clear();
                    //        break;
                    //    }
                    default:
                        { break; }
                }
                todo.Sort();
            } while (key.Key != ConsoleKey.Escape);
        }
    }
}
