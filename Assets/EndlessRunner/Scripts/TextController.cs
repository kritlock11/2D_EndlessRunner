using UnityEngine;
using TMPro;

public class TextController : MonoBehaviour
{
    public RectTransform textRotationChange;
    public TextMeshProUGUI text;
    public PlayerController player;

    private float timer;
    private bool timerOn;

    private void Start()
    {
        text.text = $"";
    }
    private void FixedUpdate()
    {
        textRotationChange.rotation = Quaternion.identity;

    }
    public void Update()
    {
        if (timerOn)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                text.text = $"";
            }
        }
    }

    public void HidePlayerHp()
    {
        text.text = $"{player.HP}";
        timerOn = true;
        timer = 0.5f;

    }
}

