using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Tanks
{
    public class HUD : MonoBehaviour
    {
        static HUD instance;
        void Awake()
        {
            if (instance != null)
            {
                DestroyImmediate(gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
