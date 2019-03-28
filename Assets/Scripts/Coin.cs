﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
      if ((other.gameObject.name == "Player")) {
        if (!GameControl.instance.gameOver) {
          GameControl.instance.AddScore(100f);
          Destroy(this.gameObject);
        }
      }   
    }
}
