using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockChain : MonoBehaviour
{
    public int ID;

    private Vector2 _targetPos;
    public float _inc;
    public float _speed;
    private float _timer;
    public SpriteRenderer sprite;
    public Collider2D collider;



    public Transform p1Pos;
    public Transform p2Pos;
    public Transform p3Pos;

    public bool p1Empty;
    public bool p2Empty;
    public bool p3Empty;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<Collider2D>();
        P1Empty();
        P2Empty();
        P3Empty();
        //collider.isTrigger = false;

    }
    private void FixedUpdate()
    {
        MoveBlock();

    }   

    void MoveBlock()
    {
        if (_timer <= 0)
        {
            Move();
            _timer = 0.1f;
        }
        else
        {
            _timer -= Time.deltaTime;
        }
    }
    void Move()
    {
        _targetPos = new Vector2(transform.position.x, transform.position.y - _inc);
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, _speed * Time.deltaTime);
    }


    public bool P1Empty()
    {
        if (transform.Find("p1").childCount < 1)
        {
            p1Empty = true;
            return true;
        }
        else
        {
            p1Empty = false;
            return false;
        }
    }
    public bool P2Empty()
    {
        if (transform.Find("p2").childCount < 1)
        {
            p2Empty = true;
            return true;
        }
        else
        {
            p2Empty = false;
            return false;
        }
    }
    public bool P3Empty()
    {
        if (transform.Find("p3").childCount < 1)
        {
            p3Empty = true;
            return true;
        }
        else
        {
            p3Empty = false;
            return false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"xui");
        if (other.CompareTag("Block"))
        {
            if (P2Empty())
            {
                other.transform.position = p2Pos.transform.position;
                other.transform.parent = transform.Find("p2");
                p2Empty = false;
            }
            else if (P1Empty())
            {
                other.transform.position = p1Pos.transform.position;
                other.transform.parent = transform.Find("p1");
                p1Empty = false;
            }
            else if (P3Empty())
            {
                other.transform.position = p3Pos.transform.position;
                other.transform.parent = transform.Find("p3");
                p3Empty = false;
            }
            else
            {
                other.transform.position = other.GetComponent<SwipeController>().tp;// new Vector2(transform.parent.position.x, transform.parent.position.y);//other.GetComponent<SwipeController>().tp;
            }
            other.GetComponent<SwipeController>().isTaken = false;
            //sprite.color = Color.red;
            other.GetComponent<SpriteRenderer>().color = Color.red;
        }

    }

    //private void OnTriggerStay2D(Collider2D other)
    //{
    //    Debug.Log($"xui!!");
    //    if (other.CompareTag("Block"))
    //    {
    //        Debug.Log($"xui!!");

    //        transform.position = other.transform.position;
    //        sprite.color = Color.red;
    //        other.GetComponent<SpriteRenderer>().color = Color.red;
    //    }
    //}

    //protected override void OnCollisionEnter2D(Collision2D collision)
    //{
    //    IHealable healableObj = collision.gameObject.GetComponent<IHealable>();

    //    if (healableObj != null)
    //    {
    //        healableObj.Heal(healing);

    //        base.OnCollisionEnter2D(collision);
    //    }
    //}



    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        if (CanDoDmg)
    //        {
    //            other.GetComponent<PlayerController>().HP -= damage;
    //            Destroy(gameObject);
    //        }
    //    }
    //}
}
