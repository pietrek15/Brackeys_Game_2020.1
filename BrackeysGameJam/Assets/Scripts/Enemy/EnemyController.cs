﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour,Rewind,GoodShoot
{
    private float m_maxHealth = 20f;
    [SerializeField]
    private float m_currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        m_currentHealth = m_maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damage(float damage)
    {
        if (m_currentHealth - damage <= 0f)
        {
            Destroy(gameObject);
        }
        else
        {
            m_currentHealth -= damage;
        }


    }

    public void Award()
    {
        GameObject bulletFragment = Resources.Load<GameObject>("Prefabs/BulletFragment");
        Vector2 instantianePos = Random.insideUnitCircle/2f + (Vector2)transform.position;
        Instantiate(bulletFragment, instantianePos, Quaternion.identity);
    }

    public void RewindTime()
    {
        throw new System.NotImplementedException();
    }
}
