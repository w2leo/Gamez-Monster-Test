using UnityEngine;

public class ButtonDifficulty : MonoBehaviour
{
    [SerializeField] private Difficulty difficulty;
    private Transform panel;
    private void Start()
    {
        panel = transform.parent;
    }

    public void SetDifficulty(ButtonPlayState bp)
    {
        bp.SetDifficulty(difficulty);
        panel.gameObject.SetActive(false);
    }
 }
