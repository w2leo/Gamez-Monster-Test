using TMPro;
using UnityEngine;

[RequireComponent(typeof(MainGameplay))]

public class MainGameplayUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI timeTest;
    [SerializeField] private TextMeshProUGUI textDistance;
    [SerializeField] private TextMeshProUGUI textTimeAttempt;
    [SerializeField] private TextMeshProUGUI textAttemptNumber;
    private MainGameplay mainGp;

    private void Start()
    {
        mainGp = GetComponent<MainGameplay>();
        MainGameplay.NotifyGameState += EndGameHandler;
    }

    private void Update()
    {
        timeTest.text = $"Time: {mainGp.AttempTime:0.0} sec";
        textDistance.text = $"Distance: {mainGp.Distance / 1000:0.00} km";
    }

    private void EndGameHandler(bool state)
    {
        textTimeAttempt.text = $"Current time: {mainGp.AttempTime:0.0} sec.";
        textAttemptNumber.text = $"Attemp number: {mainGp.AttempCount}";
    }
}
