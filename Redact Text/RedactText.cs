using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedactText : MonoBehaviour
{
    public GameObject go;
    bool canplace;
    bool releasedbutton;
    Vector3 mousePos;
    
    // Start is called before the first frame update
    void Start()
    {
        releasedbutton = true;

        canplace = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            releasedbutton = false;
            canplace = true;
            mousePos = Input.mousePosition;
        }
        if(Input.GetMouseButtonUp(0))
        {
            releasedbutton = true;
            canplace = false;
        }

           
        if(releasedbutton == false && canplace)
        {
            GameObject tmpObj = Instantiate(go);

            tmpObj.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, 10));
            canplace = false;

        }
    }
}
