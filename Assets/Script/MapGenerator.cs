using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

namespace Caress
{
    public class Map {
        [System.Serializable]
        public class PointData
        {
            public List<Point> data;
        }
        public Map(string Path)
        {
            this.mapName = Path;
            this.Points = JsonUtility.FromJson<PointData>(File.ReadAllText(Path, Encoding.UTF8)).data;
            //Debug.Log(this.Points.Count);
        }
        public string mapName;
        public List<Point> Points;
        Point getPointById(int id) {
            foreach (Point x in Points)
            {
                if (id == x.id) {
                    return x;
                }
            }
            return new Point();
        }
    }
    [System.Serializable]
    public class Point {
        /**
         * OnlySigned
         **/
        public int id;
        /**
         * in Range of (0,500)
         * GameScene resize to (0,126)
         **/
        public int x;
        public int y;
        /**
         * linked Points' id
         * reffer to Map.getPointById(int id)
         **/
        public List<int> linked;
        public Point()
        {
            x = 0;
            y = 0;
            linked = new List<int>();
            id = -1;
        }
    }
    
}