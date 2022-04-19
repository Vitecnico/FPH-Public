using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.FSM
{
    public abstract class FSMAction : ScriptableObject
    {
        protected float speed = 3.5f;
        public abstract void Execute(BaseStateMachine stateMachine);
    }
}