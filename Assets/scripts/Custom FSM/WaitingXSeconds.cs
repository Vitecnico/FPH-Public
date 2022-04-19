using Demo.Enemy;
using Demo.FSM;
using UnityEngine;
namespace Demo.MyFSM
{
    [CreateAssetMenu(menuName = "FSM/Decisions/Waiting X Seconds")]
    public class WaitingXSeconds : Decision
    {
        public override bool Decide(BaseStateMachine stateMachine)
        {
            var Waiting = stateMachine.GetComponent<Waiting>();
            var enemyInLineOfSight = stateMachine.GetComponent<EnemySightSensor>();

            if (enemyInLineOfSight.Ping())
            {
                Waiting.ResetTimer();
            }

            if(enemyInLineOfSight.Ping()||
             Waiting.CheckTimer())
             {
                return true;

             }
            
            return false;
            
        }
    }
}