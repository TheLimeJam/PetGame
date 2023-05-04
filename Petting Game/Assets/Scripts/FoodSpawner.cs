using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject food;
    // Start is called before the first frame update
    void Start()
    {       
        spawnFood(0, 3);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }

    void spawnFood(float x, float y)
    {
        Instantiate(food, new Vector3(x, y), transform.rotation); 
    }

}
