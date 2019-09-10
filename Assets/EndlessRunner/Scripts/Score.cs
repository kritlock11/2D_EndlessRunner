using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float scoreCounter;

    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update()
    {
        text.text = $"SCORE: {scoreCounter}";
    }
}
