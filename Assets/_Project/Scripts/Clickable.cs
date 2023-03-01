using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{
    private void OnMouseDown()
    {
        Score.OnBalloonClicked?.Invoke();
        Destroy(gameObject);
    }
}
