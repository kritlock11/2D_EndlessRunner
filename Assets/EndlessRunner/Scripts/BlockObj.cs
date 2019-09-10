using UnityEngine;

public class BlockObj : MonoBehaviour
{
    private Transform target;
    private Vector2 curPosition;
    private Vector2 mousePosition;
    private float deltaX;
    private float deltaY;


    private void Start()
    {

    }
    //private void Update()
    //{
    //    var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
    //    Debug.Log($"MOUSE {hit.collider}");
    //}

    //private void OnMouseDown()
    //{

    //    deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
    //    deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
    //}
    //private void OnMouseDrag()
    //{
    //    mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    transform.position = new Vector2(mousePosition.x - deltaX, mousePosition.y - deltaY);
    //}
    //private void OnMouseUp()
    //{
    //    var hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
    //    //hit.collider.isTrigger = true;
    //    if (hit.collider != null)
    //    {
    //        Debug.Log($"HIT {hit.collider}");
    //        if (hit.collider.CompareTag("BlockChain"))
    //        {
    //            BlockChain bc = hit.collider.gameObject.GetComponent<BlockChain>();
    //            hit.collider.isTrigger = true;
    //            var pos = hit.collider;

    //            if (bc.P2Empty())
    //            {
    //                transform.position = pos.transform.Find("p2").transform.position;
    //                transform.parent = pos.transform.Find("p2");
    //                bc.p2Empty = false;
    //            }
    //            else if (bc.P1Empty())
    //            {
    //                transform.position = pos.transform.Find("p1").transform.position;
    //                transform.parent = pos.transform.Find("p1");
    //                bc.p1Empty = false;
    //            }
    //            else if (bc.P3Empty())
    //            {
    //                transform.position = pos.transform.Find("p3").transform.position;
    //                transform.parent = pos.transform.Find("p3");
    //                bc.p3Empty = false;
    //            }

    //            //Debug.Log($"{hit.collider}");
    //            //TakeObj(hit.collider);
    //        }
    //        else
    //        {
    //            transform.position = new Vector2(transform.parent.position.x, transform.parent.position.y);
    //        }
    //    }


    //    //if (Mathf.Abs(transform.position.x - target.position.x) <= 0.5f && Mathf.Abs(transform.position.y - target.position.y) <= 0.5f)
    //    //{
    //    //    transform.position = new Vector2(target.position.x, target.position.y);
    //    //}
    //    //else
    //    //{
    //    //    transform.position = new Vector2(curPosition.x, curPosition.y);
    //    //}
    //}








}
