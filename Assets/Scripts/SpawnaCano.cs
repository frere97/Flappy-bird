using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnaCano : MonoBehaviour
{
    public GameObject cano;
    public float MaxTempoTimer = 2;
    float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > MaxTempoTimer && GameManager.Instance.PlayerVivo == true) { 
        Instantiate(cano, new Vector3(this.transform.position.x, Random.Range(-3, 3), 0), Quaternion.identity);
            timer = 0;
            GameManager.Instance.Score++;
        }
    }
}
