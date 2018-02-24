using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Caress {
    public class Card_Motivation : Function {
        /**
         * 行动牌：获得随机数字的行动点数，使Target显示其周围的路径并且可移动(Function Class封装)
         **/
        public new void Trigger()
        {
            //骰子特效？
            int step = Random.Range(1, 7);

            this.onMove(step);
        }


    }
}