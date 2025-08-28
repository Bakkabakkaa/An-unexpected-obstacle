using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSelection : MonoBehaviour
{
    [SerializeField] private Outline _outlinePlayer;
    public bool Flag { get; set; } = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            _outlinePlayer.OutlineWidth = 2;
            Flag = true;
        }
    }
}
