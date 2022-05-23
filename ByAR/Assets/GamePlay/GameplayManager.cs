using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ByAR.Gameplay
{
    public class GameplayManager : MonoBehaviour
    {
        private int spheresEaten = 0;

        public delegate void UpdateSpheresEatenEvent(int value);
        public static UpdateSpheresEatenEvent updateSpheresEatenEvent;

        void Start() => Sphere.eatenEvent += UpdateSpheresEatenValue;

        private void UpdateSpheresEatenValue()
        {
            spheresEaten++;
            updateSpheresEatenEvent?.Invoke(spheresEaten);
        }
    }
}