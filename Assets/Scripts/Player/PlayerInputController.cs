using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] public GameObject spell;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(spell, transform.position, transform.rotation);
            int x = UnityEngine.Random.Range(0, 20);
            Debug.Log(x);
        }
    }
}
