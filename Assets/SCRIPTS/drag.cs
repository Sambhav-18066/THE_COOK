using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    // Start is called before the first frame update

    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;


    // Update is called once per frame
    void Update()
    {
        if(isBeingHeld == true)
        {
            Vector3 mousepos;
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);

            this.gameObject.transform.localPosition = new Vector3(mousepos.x-startPosX, mousepos.y-startPosY, 0);
        }
    }



    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousepos;
            mousepos = Input.mousePosition;
            mousepos = Camera.main.ScreenToWorldPoint(mousepos);

            startPosX = mousepos.x - this.transform.localPosition.x;
            startPosY = mousepos.y - this.transform.localPosition.y;

            isBeingHeld = true;
            Debug.Log("started");
        }
    }


    private void OnMouseUp()
    {

        isBeingHeld = false;
    }
}
