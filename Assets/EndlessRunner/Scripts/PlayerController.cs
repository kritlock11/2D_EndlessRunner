using UnityEngine;
using TMPro;
using System;

public class PlayerController : BaseSceneObject
{
    public float HP;
    public float MaxHP;
    public CamShake Shake;
    public TextController TextController;
    public ParticleSystem HealLoot;
    public ParticleSystem Attack;
    public Animator anim;





    protected override void Start()
    {
        HP = MaxHP;

    }

    protected override void Update()
    {
        base.Update();

        //Debug.Log(HP);
        Die();
    }

    public event Action OnHurt;
    public event Action OnHeal;
    public event Action OnDeath;


    private void Die()
    {
        if (OnDeath != null)
            OnDeath.Invoke();
    }


    public void Hurt(float damage)
    {
               
        HP -= damage;

        if (OnHurt != null)
            OnHurt.Invoke();

        if (HP <= 0)
        {
            HP = 0;
            Die();
        }
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

        //        float rand = UnityEngine.Random.Range(0, 2);
        //        if (rand == 1)
        //        {
        //            Heal(1);
        //        }
        //        Destroy(other.gameObject);
        //    }
        //}
    }
}
