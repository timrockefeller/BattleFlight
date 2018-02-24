using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Caress
{
    public class Function:MonoBehaviour
    {
        public string inner;
        public void Trigger() { }


        public Chess targetChess;
        public Player targetPlayer;

        public List<Chess> getTargetChessList(TargetChessOwningType own, TargetChessFilterType filter)
        {
            //your code here
            List<Chess> list = new List<Chess>();

            switch (own)
            {
                
            }
            return new List<Chess>();
        }
        /**
         * Move
         * 
         * selfChessSpec
         **/
        public void onMove(int step)
        {
            
        }
    }



    public enum TargetPlayerType
    {
        selfPlayer,//自身英雄
        oppoPlayer,//对方英雄
        allPlayer//双方英雄
    }
    public enum TargetChessOwningType
    {
        self,//己方
        oppo,//对方
        all//所有
    }
    public enum TargetChessFilterType
    {
        ALL,//所有
        DEAD,//已死亡
        ALIVE,//仍存活
        SPEC//单个
    }
}
