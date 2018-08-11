using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private PlayerActionController _actionController;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _actionController.UseEquippedSpell();
        }

        if (Input.GetButtonDown("Change Spell"))
        {
            _actionController.EquipNextSpell();
        }
    }
}
