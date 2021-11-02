using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionGenerator : MonoBehaviour
{
    public Vector3 RandomPosition()
    {
        float RandomX = Random.Range(0, 8);
        float RandomY = Random.Range(0, 8);
        float RandomZ = Random.Range(0, 8);
        return new Vector3(RandomX, RandomY, RandomZ);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = RandomPosition();
        }
    }
}
