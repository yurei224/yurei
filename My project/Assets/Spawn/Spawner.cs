using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform SpawnPos;
    public GameObject Vrag;
    public float TimeSpawn;

    public Vector3 oct = new Vector3(1,5,0);
    public Transform per;

    void Start()
    {
        StartCoroutine(SpawnCD());
    }

    
    void Repeat()
    {
        StartCoroutine(SpawnCD());
    }
    IEnumerator SpawnCD()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Instantiate(Vrag, SpawnPos.position, Quaternion.identity);
        Repeat();
    }

    private void Update()
    {
        SpawnPos.position = per.position + oct;
    }
}
