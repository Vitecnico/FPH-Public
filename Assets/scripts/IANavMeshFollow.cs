using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace IA.Follow
{
        public class IANavMeshFollow : MonoBehaviour
    {

        [SerializeField] protected Transform targTransform;
        private NavMeshAgent navMeshMonster;
        
        
        private void Awake() {
             navMeshMonster = GetComponent<NavMeshAgent>();
         }

         private void Update() {
             navMeshMonster.destination = targTransform.position;
         }
    
     }

}
