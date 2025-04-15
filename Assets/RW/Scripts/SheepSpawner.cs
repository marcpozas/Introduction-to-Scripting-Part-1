using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{
    public bool canSpawn = true; // 1
    public GameObject sheepPrefab; // 2
    public GameObject blueSheepPrefab;
    public List<Transform> sheepSpawnPositions = new List<Transform>(); // 3
    public float timeBetweenSpawns;

    private List<GameObject> sheepList = new List<GameObject>(); // 5

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator SpawnRoutine() // 1
    {
        while (canSpawn) // 2
        {
            SpawnSheep(); // 3
            yield return new WaitForSeconds(timeBetweenSpawns); // 4
        }
    }

    public void RemoveSheepFromList(GameObject sheep)
    {
        sheepList.Remove(sheep);
    }

    private void SpawnSheep()
    {
        GameObject prefabToUse = sheepPrefab;
        // 10% probability that the ice sheep appears
        if (Random.value < 0.1f)
        {
            prefabToUse = blueSheepPrefab;
        }
        Vector3 randomPosition = sheepSpawnPositions[Random.Range(0, sheepSpawnPositions.Count)].position; // 1
        GameObject sheep = Instantiate(prefabToUse, randomPosition, prefabToUse.transform.rotation); // 2
        sheepList.Add(sheep); // 3
        sheep.GetComponent<Sheep>().SetSpawner(this); // 4
        Debug.Log("Spawned sheep: " + prefabToUse.name);
    }

    public void DestroyAllSheep()
    {
        foreach (GameObject sheep in sheepList) // 1
        {
            Destroy(sheep); // 2
        }

        sheepList.Clear();
    }
}
