using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeController : MonoBehaviour
{
    private Vector2 startTouchPos, endTouchPos;
    public Vector2 startPanelPos, endPanelPos, currPanelPos;
    public RaycastHit2D hit;
    public Vector2 tp;
    private float camDistanse=10;
    public bool isTaken;
    private void Update()
    {
        DND();
        TakeObj(hit.collider);
    }
    public void TakeObj(Collider2D hit)
    {
        if (hit != null && isTaken)
        {
            hit.gameObject.transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDistanse));
        }
    }
    private void DND()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            //startTouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Block"))
                {
                    tp = hit.collider.transform.position;
                    var GO = hit.collider;
                    GO.GetComponent<SwipeController>().isTaken = true;
                    //GO.isTrigger = true;
                    //Debug.Log($"{hit.collider}");
                    //TakeObj(hit.collider);
                }
            }
        }
        if (isTaken && Input.GetKeyUp(KeyCode.Mouse0))
        {
            hit.collider.GetComponent<SwipeController>().isTaken = false;
            //hit.collider.transform.localScale = Vector3.zero;
            //hit.collider.isTrigger = false;
            //endTouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //var v = (endTouchPos.x - startTouchPos.x);
            //Debug.Log($"{v}");
        }
    }
}
