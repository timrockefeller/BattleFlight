using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraCtrl : MonoBehaviour
{

        //方向灵敏度  
        public float sensitivityX = 10F;
        public float sensitivityY = 10F;

        //上下最大视角(Y视角)  
        public float minimumY = -60F;
        public float maximumY = 60F;

        float rotationY = 0F;

        private Vector3 PreMouseMPos;
        private Vector3 PreMouseLPos;
        private float wheelSpeed = 5.0f;


        void Start()
        {

        }


        void Update()
        {
            CameraMove();
            MouseScrollWheel();
            Move();
        }

        private void MouseScrollWheel()
        {
            //滚轮前进后退  
            if (Input.GetAxis("Mouse ScrollWheel") != 0)
            {
                gameObject.transform.Translate(new Vector3(0, 0, Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * 500));
            }
        }

        private void CameraMove()
        {

            //鼠标中键按下，上下左右移动相机  
            if (Input.GetMouseButton(2))
            {

                if (PreMouseMPos.x <= 0)
                {
                    PreMouseMPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f);
                }
                else
                {
                    Vector3 CurMouseMPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.0f);
                    Vector3 offset = CurMouseMPos - PreMouseMPos;
                    offset = -offset * 0.1f;//0.1这个数字的大小可以调节速度  
                    transform.Translate(offset);
                    PreMouseMPos = CurMouseMPos;


                }
            }
            else
            {
                PreMouseMPos = new Vector3(0.0f, 0.0f, 0.0f);
            }
        }


        private void Move()
        {
            //右键旋转视角  
            if (Input.GetMouseButton(1))
            {
                //根据鼠标移动的快慢(增量), 获得相机左右旋转的角度(处理X)  
                float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;
                //根据鼠标移动的快慢(增量), 获得相机上下旋转的角度(处理Y)  
                rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
                //角度限制. rotationY小于min,返回min. 大于max,返回max. 否则返回value  
                rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

                //总体设置一下相机角度  
                transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
            }
        }

    }  