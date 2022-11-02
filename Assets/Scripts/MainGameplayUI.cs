using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(MainGameplay))]

public class MainGameplayUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeTest;
    [SerializeField] private TextMeshProUGUI textDistance;
    private MainGameplay mainGp;

    private void Start()
    {
        mainGp = GetComponent<MainGameplay>();
    }

    private void Update()
    {
        timeTest.text = $"Time: {mainGp.AttempTime:0.0} sec";
        textDistance.text = $"Distance: {mainGp.Distance:0.0} m";
    }
}
