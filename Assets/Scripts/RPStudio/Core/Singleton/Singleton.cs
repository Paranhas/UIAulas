using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPStudio.Core.Singleton
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
            }
            else if (Instance == this)
            {
                {
                    Destroy(gameObject);
                }
            }
        }
    }
}
