using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TimeInSeconds : MonoBehaviour
{
    public Transform player;
    public Text scoreText;

    private void Update()
    {
        scoreText.text = player.position.z.ToString();
    }
}

