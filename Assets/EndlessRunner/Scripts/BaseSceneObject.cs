using System;
using UnityEngine;

public class BaseSceneObject : MonoBehaviour
{

    private Rigidbody2D _rigidbody;


    #region Свойства

    public Rigidbody2D Rigidbody
    {
        get
        {
            return _rigidbody;
        }
    }

    public Vector3 Position
    {
        get
        {
            return transform.position;
        }

        set
        {
            transform.position = value;
        }
    }

    public Vector3 Scale
    {
        get
        {
            return transform.localScale;
        }

        set
        {
            transform.localScale = value;
        }
    }

    public Quaternion Rotation
    {
        get
        {
            return transform.rotation;
        }

        set
        {
            transform.rotation = value;
        }
    }

    public Vector3 Velocity
    {
        get
        {
            return Rigidbody != null ? Rigidbody.velocity : Vector2.zero;
        }

        set
        {
            Rigidbody.velocity = value;
        }
    }

    public bool IsEnabled
    {
        get
        {
            return gameObject.activeInHierarchy;
        }
    }

    #endregion


    #region События

    public event Action OnLeavingScene;
    public event Action OnLeavedScene;

    #endregion




    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    protected virtual void Start()
    {

    }


    protected virtual void Update()
    {

    }



    public virtual void LeavingScene()
    {
        if (OnLeavingScene != null)
            OnLeavingScene.Invoke();
    }

    public virtual void LeavedScene()
    {
        if (OnLeavedScene != null)
            OnLeavedScene.Invoke();

        Destroy(gameObject);
    }

    public void SetEnable(bool enable)
    {
        gameObject.SetActive(enable);
    }

    public void Enable()
    {
        SetEnable(true);
    }

    public void Disable()
    {
        SetEnable(false);
    }

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
