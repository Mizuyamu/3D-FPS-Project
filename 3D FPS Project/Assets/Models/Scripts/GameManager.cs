using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI targetText;
    public string youWonScene;
    public string youLostScene;
    private int _targetAmount;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        int floatingTargetAmount = GameObject.FindGameObjectsWithTag("Floating Target").Length;
        int standingTargetAmount = GameObject.FindGameObjectsWithTag("Target").Length;
        _targetAmount = floatingTargetAmount + standingTargetAmount;
        targetText.text = "Targets: " + _targetAmount.ToString();
    }

    public void UpdateTargetAmount(int amount)
    {
        _targetAmount += amount;
        targetText.text = "Targets: " + _targetAmount.ToString();

        if(_targetAmount <= 0)
        {
            GameObject.Find("Game Manager").GetComponent<Timer>().EndGameTimer();
            GameObject.Find("Game Manager").GetComponent<CrossFade>().FadeIn();
            StartCoroutine(MovetoWinScene());
        }
    }

    public void GameIsOver()
    {
        StartCoroutine(MoveToLostScene());
    }

    private IEnumerator MovetoWinScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(youWonScene);
    }

    private IEnumerator MoveToLostScene()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(youLostScene);
    }
}