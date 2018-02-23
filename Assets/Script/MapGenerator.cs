using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

namespace Caress
{
    public class Map {
        public Map(string Path)
        {
            this.mapName = Path;
            this.Points = parseMapByName(Path);
        }
        public string mapName;
        public List<Point> Points;
        public static List<Point> parseMapByName (string Path)
        {
            return JsonUtility.FromJson<List<Point>>(File.ReadAllText(Path, Encoding.UTF8)); 
        }
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
    }
}