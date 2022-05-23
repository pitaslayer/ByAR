using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ByAR.Gameplay
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private Vector3 deltaVector; 

        void Start() => Sphere.eatenEvent += UpdatePlayerScale;

        private void UpdatePlayerScale() =>gameObject.transform.localScale += deltaVector;
    }
}