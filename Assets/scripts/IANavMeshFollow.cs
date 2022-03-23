using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IANavMeshFollow : MonoBehaviour
{

    [SerializeField] private Transform targTransform;
    private NavMeshAgent navMeshMonster;
    
    
     private void Awake() {
         navMeshMonster = GetComponent<NavMeshAgent>();
     }

     private void Update() {
        navMeshMonster.destination = targTransform.position;
     }
 
}
