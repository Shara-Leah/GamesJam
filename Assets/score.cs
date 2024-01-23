using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    public float Score = 0;
    public float pointsPerSec;
    [SerializeField]
    TextMeshProUGUI scoreText;
    private void Update()
    {
        Score += pointsPerSec * Time.deltaTime;
        scoreText.text = "Score: " + Score.ToString();
    }

}
