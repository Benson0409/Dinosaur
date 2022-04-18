using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manger : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;
    public GameObject cactus3;
    public GameObject cactus4;
    public GameObject bird;
    
    public GameObject cactusSpawnPosition;
    public float spawnTime;
    float timer;
    public GameObject GameOverScene;
    public GameObject score;

    float a;
    int b;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
       
    }

    // Update is called once per frame
    void Update()
    {
        a = score.GetComponent<score>().a;
        timer += Time.deltaTime;
        
        if (timer >= spawnTime)
        {
            if (a <=500)
            {
                spawnTime = 1.5f;
                Instantiate(cactus1, cactusSpawnPosition.transform);
                timer = 0;
            }
           
            else if (a >500&&a<=850)
            {
                
                b = Random.Range(0, 2);       
                if (b == 0)
                {
                    spawnTime = 1.4f;
                    Instantiate(cactus1, cactusSpawnPosition.transform);
                    timer = 0;
                }
                else if (b == 1)
                {
                    spawnTime = 1.3f;
                    Instantiate(cactus1, cactusSpawnPosition.transform);
                    Instantiate(cactus2, cactusSpawnPosition.transform);
                    timer = 0;
                }
            }
           
            else if (a >850 && a<=1400 )
            {
                b = Random.Range(0, 4);
                if (b == 0)
                {
                    spawnTime = 1.2f;
                    Instantiate(cactus1, cactusSpawnPosition.transform);
                    Instantiate(cactus2, cactusSpawnPosition.transform);
                    timer = 0;
                }
                if(b==1 || b==2)
                {
                    spawnTime = 1;
                    Instantiate(cactus3, cactusSpawnPosition.transform);
                    timer = 0;
                }
                if(b==3)
                {
                    spawnTime = 1.3f;
                    Instantiate(cactus1, cactusSpawnPosition.transform);
                    timer = 0;
                }
            }
            else if (a > 1400)
            {
                b = Random.Range(0, 7);
                if (b == 0)
                {
                    spawnTime = 1.3f;
                    Instantiate(cactus1, cactusSpawnPosition.transform);
                    timer = 0;
                }
                if (b == 1)
                {
                    spawnTime = 1.2f;
                    Instantiate(cactus1, cactusSpawnPosition.transform);
                    Instantiate(cactus2, cactusSpawnPosition.transform);
                    timer = 0;
                }
                if(b==3)
                {
                    spawnTime = 1;
                    Instantiate(cactus3, cactusSpawnPosition.transform);
                    timer = 0;
                }
                if(b==4)
                {
                    spawnTime = 0.8f;
                    Instantiate(cactus4, cactusSpawnPosition.transform);
                    timer = 0;
                }
                if(b==5)
                {
                    spawnTime = 0.8f;
                    Instantiate(cactus1, cactusSpawnPosition.transform);
                    Instantiate(cactus2, cactusSpawnPosition.transform);
                    timer = 0;
                }
                if(b==6)
                {
                    spawnTime = 1;
                    Instantiate(bird, cactusSpawnPosition.transform);
                    timer = 0;
                }
            }
        }
     
    }
    public void GameOver()
    {
        Time.timeScale = 0;
        GameOverScene.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("L1");
    }
}

