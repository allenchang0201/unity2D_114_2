using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goToRight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    int a = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 10)
        {
            transform.Translate(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -10)
        {
            transform.Translate(-1, 0, 0);
        }
        a++;
        if(a==10){
            a = 0;
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x<10)
            {
                transform.Translate(1,0,0);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -10)
            {
            transform.Translate(-1,0,0);
            }
        }
    }
}
