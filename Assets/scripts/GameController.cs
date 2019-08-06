using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 SpawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public Text ScoreText;
    public Text RestartText;
    public Text GameOverText;

    private int score;
    private bool gameOver;
    private bool Restart;
    void Start()
    {
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
        RestartText.text = "";
        GameOverText.text = "";
   
    }
    void Update()
    {
        if (Restart)
        {
            if(Input.GetKeyDown (KeyCode.R))
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 SpawnPosition = new Vector3(Random.Range(-SpawnValues.x, SpawnValues.x), SpawnValues.y, SpawnValues.z);
                Quaternion SpawnRotation = Quaternion.identity;
                Instantiate(hazard, SpawnPosition, SpawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);
            if (gameOver)
            {
                RestartText.text = "press 'R' for Restart";
                Restart = true;
                break;
            }
        }
       
    }
   public void addscore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();

    }
    void UpdateScore()
    {
        ScoreText.text = "score:" + score;
    }
  public void GameOver()
    {
        GameOverText.text = "Game Over!";
        gameOver = true;
    }
}
