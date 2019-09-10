using UnityEngine;
using TMPro;


public class EnemyController : MonoBehaviour
{
    public TextController TextController;
    public float CurrentHealth;
    public float MaxHealth;
    public ParticleSystem HealLoot;
    public ParticleSystem Attack;
    public CamShake Shake;

    private Vector2 _targetPos;

    public Animator anim;

    private Vector2 startTouchPos, endTouchPos;
    public Vector2 startPanelPos, endPanelPos, currPanelPos;
    private float touchSwipeRange = 50;
    private float mouseSwipeRange = 1.7f;
    private bool swipedleft;






    private void Start()
    {
        CurrentHealth = MaxHealth;

    }

    private void Update()
    {
        //Debug.Log(CurrentHealth);
        //Die();
    }


        

    //public void Die()
    //{
    //    if (CurrentHealth <= 0)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    private void MouseSwipeTalents()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startTouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            endTouchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var v = (endTouchPos.x - startTouchPos.x);
            Debug.Log($"{v}");

            if ((endTouchPos.x < startTouchPos.x) && v < -mouseSwipeRange)
            {
                swipedleft = true;
                transform.position = endPanelPos;
            }
            else if ((endTouchPos.x > startTouchPos.x) && v > mouseSwipeRange && swipedleft)
            {
                swipedleft = false;
                transform.position = startPanelPos;
            }
        }
    }
    public void Heal()
    {
        CurrentHealth += 1;
    }

    void AnimHPText()
    {
        anim.SetTrigger("HPTextAnim");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log($"xui!!");
        //if (other.CompareTag("Enemy"))
        //{
        //    if (!other.gameObject.GetComponent<BlockObj>().CanDoDmg)
        //    {
        //        TextController.HidePlayerHp();
        //        TextController.text.color = Color.green;
        //        AnimHPText();
        //    }
        //    if (other.gameObject.GetComponent<BlockObj>().CanDoDmg)
        //    {
        //        TextController.HidePlayerHp();
        //        TextController.text.color = Color.red;
        //        AnimHPText();
        //    }

        //    if (!other.gameObject.GetComponent<BlockObj>().CanDoDmg)
        //    {

        //        float rand = Random.Range(0, 2);
        //        if (rand == 1)
        //        {
        //            Heal();
        //        }
        //        Destroy(other.gameObject);
        //    }
        //}
    }


}
