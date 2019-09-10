using UnityEngine;

public class RepitingBG : MonoBehaviour
{
    private Vector2 _targetPos;
    public float _inc;
    public float _speed;

    private float _timer = 1;
    private void FixedUpdate()
    {

        if (_timer <= 0)
        {
            Left();
            Move();
            _timer = 2;
        }
        else
        {
            _timer -= Time.deltaTime;
        }

    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, _targetPos, _speed * Time.deltaTime);
    }
    public void Left()
    {
        _targetPos = new Vector2(transform.position.x - _inc, transform.position.y);
    }
}
