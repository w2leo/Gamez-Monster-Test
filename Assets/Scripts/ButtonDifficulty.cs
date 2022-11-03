using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDifficulty : MonoBehaviour
{
    [SerializeField] private Difficulty difficulty;

    public void SetDifficulty(ButtonPlay bp)
    {
        bp.SetDifficulty(difficulty);
    }
 }
