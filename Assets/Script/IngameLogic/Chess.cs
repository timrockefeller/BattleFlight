using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Caress
{
    public class Chess
    {
        //refer to ChessPool
        public int id;
        public string name;
        public ColorType colorType;
        /**
         * 棋子费用
         **/
        public int cost;
        /**
         * 血量
         **/
        public int blood;
        /**
         * 血量上限
         **/
        int maxBlood;
        /**
         * 目前所在Point
         * new Point() == this.standing =>未放出/已死亡
         **/
        public Point standing;
        /**
         * 是否存活
         **/
        public bool isAlive;
        /**
         * 特效json
         **/
        public string function;
    }
}
