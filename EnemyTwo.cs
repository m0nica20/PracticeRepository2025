using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    public GameObject EnemyTwoPrefab;
    public float speed = 4f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyTwo", 1, 2);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-3, -5, 0) * Time.deltaTime * 3f);
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
        
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
    

