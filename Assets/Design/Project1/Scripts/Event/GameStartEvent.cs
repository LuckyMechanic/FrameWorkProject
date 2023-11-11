using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Design.Project1
{
    public static class GameStartEvent
    {
       //定义接受到事件委托
       private static Action mOnEvent;
        public static void Register(Action onEvent)
        {
            mOnEvent += onEvent;
        }

    }
}

