using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;
    public float spawnRate = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnTarget());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    IEnumerator spawnTarget()
    {
        while (true)
        {
            //Espera segundos
            yield return new WaitForSeconds(spawnRate);
            
            //Despues de esperar haz esto
            GameObject targetSpawned = targets[Random.Range(0, targets.Count)];
            Instantiate(targetSpawned);
        }

    }
}
