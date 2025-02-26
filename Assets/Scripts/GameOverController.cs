using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel.SetActive(true);
        if(GameManager.Instance){
            scoreText.text = "Score: " +  GameManager.Instance.getScore();
        }
    }
    
    public void RestartGame(){
        SceneManager.LoadScene(0);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
