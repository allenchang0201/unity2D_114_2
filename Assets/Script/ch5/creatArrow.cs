using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatArrow : MonoBehaviour
{
    public GameObject arrowCopy;
    // Start is called before the first frame update
    int a = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a++;
        if (a == 30)
        {
            a = 0;
            GameObject arrowCopied = Instantiate(arrowCopy);
            int b=Random.Range(-10, 10);
            arrowCopied.transform.position=new Vector3(b, 5, -2);
            while (arrowCopied.transform.position.y < -1)
            {
                Debug.Log(arrowCopied.transform.position.y);
                a = 0;
                arrowCopied.transform.Translate(0,-1,0);
            }
        }
    }
}
