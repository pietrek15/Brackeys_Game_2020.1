﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoFragment : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerController>())
        {
            GameManager.Instance.AddAmmo(1);
            Destroy(gameObject);
        }
    }
}
