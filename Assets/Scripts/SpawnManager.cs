using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject objectiveprefab;
    public List<Vector3> targetPositions; //lista de posiciones que emplearemos para no repetir dos dianas en la misma posicion al spawnearlas

    private activate_game activate_gameScript;
    public TextMeshProUGUI pointstext;

    private Vector3 spawnPos;
    public int score;


    public int currentScore;
    private int xSeparation = 4;
    private int xOffset = -10;
    private int ySeparation = 3;
    private int yOffset = 7;
    private int zPos = -40;

    private float spawnRate = 2f;

    void Start()
    {
        activate_gameScript = FindObjectOfType<activate_game>(); //comunicamos con el script de activate game, para saber si le hemos dado al boton.
        
    }
    void Update() //por pantalla podremos actualizar en todo momento cuantos puntos llevamos obtenidos
    {
        currentScore = score;
        pointstext.text = $"Score: {currentScore}";
    }

    public Vector3 RandomPosition() //generaremos una posición random para las dianas 
    {
        
        int column = Random.Range(0, 5); //se spawnearán aleatoriamente en 5 columnas
        int row = Random.Range(0, 2); //y dos filas
        int xPos = xOffset + xSeparation * column; //calculamos en que columna
        int yPos = yOffset - ySeparation * row; //y en que fila le corresponde
        Vector3 inicialPos = new Vector3(xPos, yPos, zPos); //genereamos una posición con esas condiciones
        return inicialPos;

    }
    public IEnumerator spawnObjective()
    {
        while (activate_gameScript.gameOn) //mientras el juego esté en marcha
        {
            
            yield return new WaitForSeconds(spawnRate); // cada ciclo del bucle esperará 2 segundos
            
            spawnPos = RandomPosition(); //generará una posicion aleatoria para el objetivo
            while (targetPositions.Contains(spawnPos)) //y si esa posición está ocupada por otra diana
            {
                spawnPos = RandomPosition(); //generamos una nueva posición
            }
            Instantiate(objectiveprefab, spawnPos, objectiveprefab.transform.rotation); //instanciamos la diana
            targetPositions.Add(spawnPos);
        }
   
    }
}
