using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Caress
{
    public class Environment : MonoBehaviour
    {
        Map defaultMap;

        public GameObject MapCanvas;
        public GameObject Perfab_Point;
        
        void Awake()
        {
            //Load Map
            defaultMap = new Map("Assets/Script/map01.json");
            
        }
        private void Start()
        {
            foreach (Point x in defaultMap.Points)
            {
                Vector3 position = new Vector3(x.x,0, x.y);
                Quaternion rotation = new Quaternion(90,0,0,0);
                Instantiate(Perfab_Point, position, rotation, MapCanvas.transform);
            }
        }
        void Update()
        {

        }
    }
}