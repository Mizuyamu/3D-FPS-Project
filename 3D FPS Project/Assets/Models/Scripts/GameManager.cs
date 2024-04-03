using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI targetText; 
    private int _targetAmount;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        int floatingTargetAmount = GameObject.FindGameObjectsWithTag("Floating Target").Length;
        int standingTargetAmount = GameObject.FindGameObjectsWithTag("Targets").Length;
        _targetAmount = floatingTargetAmount + standingTargetAmount;
        targetText.text = "Targets: " + _targetAmount.ToString();
    }

    public void UpdateTargetAmount(int amount)
    {
        _targetAmount += amount;
    }
}
