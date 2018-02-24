using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraCtrl : MonoBehaviour
{

    //方向灵敏度  
    public float sensitivity = 40F;

    public float acc = 40F;

    float speed = 0F;
    
    void Start()
    {
    }
    
    void Update() {
        if ( ! Input.GetMouseButton(0))
        {
            //Debug.Log(Input.mousePosition);
            Vector3 delta = new Vector3();
            if (Input.mousePosition.x < 20)
            {
                delta+= Vector3.back + Vector3.left;
            }
            if (Input.mousePosition.x > Screen.width - 20)
            {
                delta += Vector3.forward + Vector3.right;
            }
            if (Input.mousePosition.y < 20)
            {
                delta += Vector3.back + Vector3.right;
            }
            if (Input.mousePosition.y > Screen.height - 20)
            {
                delta += Vector3.forward + Vector3.left;
            }
            if (delta.magnitude != 0)
            {
                if (speed < sensitivity) { speed += acc * Time.deltaTime; } else { speed = sensitivity; }
            }
            else
            {
                if (speed > 0) { speed -= acc * Time.deltaTime; } else { speed = 0; }
            }
            
            gameObject.transform.position += delta.normalized * speed * Time.deltaTime;
        }
    }

}  