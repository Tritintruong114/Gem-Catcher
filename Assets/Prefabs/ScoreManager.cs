using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;
    private float remainingTime; 
    
    public TextMeshProUGUI scoreText; 
    public GameObject gameOverPanel; 
    public GameObject gameCharacter; 
    public GameObject gameGem; 
    public TextMeshProUGUI gameOverText;
    public static void AddScore(int amount)
    {
        score += amount; 
    }

    void Start() // đếm giờ khi trò chơi bắt đầu
    {
        remainingTime = 90f; //thời gian còn lại tại thời điểm bắt đầu bằng 30s (thời lượng của trò chơi)
    gameGem.SetActive(true);
    gameCharacter.SetActive(true);
        StartCoroutine(CountdownTimer());
    }
 
    void Update() 
    {
        scoreText.text = "Score: " + score + " | Time: " + Mathf.CeilToInt(remainingTime); //Mathf.CeilToInt(remainingTime) làm tròn số nguyên dương
    }

    private IEnumerator CountdownTimer()
    {
        while (remainingTime > 0)
        {
            yield return new WaitForSeconds(1f);
            remainingTime--; 
        }
            GameOver();
        
    }


    private void GameOver()
    {	
    gameCharacter.SetActive(false);
    gameGem.SetActive(false);
    gameOverText.text = "Game Over!\nScore: " + score; //gán text vào text
    gameOverPanel.SetActive(true); //hiển thị panel
    }

}