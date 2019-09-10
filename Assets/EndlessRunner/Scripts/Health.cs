using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    private PlayerController player;
    //private TextMeshProUGUI text;
    public TextMeshProUGUI text;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent <PlayerController> ();
    }

    void Update()
    {
        text.text = $"Health: {player.HP}";
    }
}
