using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Demo.Enemy
{
    public class Waiting: MonoBehaviour
    {
        [SerializeField]
        private float time = 5.0f;
        private float myTime = 0f;
        
        private bool expiredTime = false;

        private void Awake()
        {
            myTime = time;
        }
        public bool CheckTimer()
        {
           
                time -= Time.deltaTime;
                if (time <= 0)
                {
                    
                    ResetTimer();
                    return false;
                }
                
                return true;
        }

        public void ResetTimer()
        {
            time = myTime;
        }
        


    }
    
    
}