using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int scpre = 0;
    public int lives = 3;

    private PlayerCollision player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Score: " + score);
        Debug.Log("Lives:" + lives);

        GameObject playerObject = GameObject.Find("Player");
        if (playerObject != null)
        {
            player = playerObject.GetComponent<PlayerController>();
        }
    }
    
    public void IncreaseScore(int points)
    {}

    // Update is called once per frame
    void Update()
    {
        
    }
}
