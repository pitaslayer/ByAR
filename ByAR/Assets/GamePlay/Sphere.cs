using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ByAR.Gameplay
{
    public class Sphere : MonoBehaviour
    {
        public delegate void EatenEvent();
        public static EatenEvent eatenEvent;

        void OnTriggerEnter(Collider other)
        {
            if(other.gameObject.tag == "Player")
            {
                eatenEvent?.Invoke();
                GameObject.Destroy(this.gameObject);
            }
        }
    }
}