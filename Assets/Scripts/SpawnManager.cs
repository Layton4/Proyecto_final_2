using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectiveprefab;
    public List<Vector3> targetPositions;

    private activate_game activate_gameScript;
    public TextMeshProUGUI pointstext;

    private Vector3 spawnPos;
    public int score;


    public int currentScore;
    private int xSeparation = 4;
    private int ySeparation = 3;
    private int zPos = -40;

    private float spawnRate = 2f;

    void Start()
    {
        activate_gameScript = FindObjectOfType<activate_game>();
        
    }
    void Update()
    {
        currentScore = score;
        pointstext.text = $"Score: {currentScore}";
    }

    public Vector3 RandomPosition()
    {
        
        int column = Random.Range(0, 5);
        int row = Random.Range(0, 2);
        int xPos = -10 + xSeparation * column;
        int yPos = 7 - ySeparation * row;
        Vector3 inicialPos = new Vector3(xPos, yPos, zPos);
        return inicialPos;

    }
    public IEnumerator spawnObjective()
    {
        while (activate_gameScript.gameOn)
        {
            
            yield return new WaitForSeconds(spawnRate);
            
            spawnPos = RandomPosition();
            Instantiate(objectiveprefab, spawnPos, objectiveprefab.transform.rotation);
            targetPositions.Add(spawnPos);
        }
   
    }
}
