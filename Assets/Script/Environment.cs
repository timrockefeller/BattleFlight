using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Caress
{
    public class Environment : MonoBehaviour
    {
        Map defaultMap;
        // Use this for initialization
        void Start()
        {
            defaultMap = new Map("map01.json");
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}