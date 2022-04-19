using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Demo.FSM;
using Demo.Enemy;

namespace Demo.MyFSM{

    [CreateAssetMenu(menuName = "FSM/Actions/Patrol")]
    public class Patrol : FSMAction
    {
        public override void Execute(BaseStateMachine stateMachine)
        {
            var navMeshAgent = stateMachine.GetComponent<NavMeshAgent>();
            var patrolPoints = stateMachine.GetComponent<PatrolPoints>();
            navMeshAgent.speed = speed;

            if (patrolPoints.HasReached(navMeshAgent))
                navMeshAgent.SetDestination(patrolPoints.GetNext().position);
        }

    }
}