using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo_Console
{
    //xml로 데이터베이스를 대신
    //완료된 항목은 삭제로 대체

    //ToDo 관련 전체를 관리
    class ToDo
    {
        private bool isCleared;
        private string whatToDo;

        public ToDo(string Contain)
        {
            IsCleared = false;
            WhatToDo = Contain;
        }

        public string WhatToDo { get => whatToDo; set => whatToDo = value; }
        public bool IsCleared { get => isCleared; set => isCleared = value; }
    }
}
