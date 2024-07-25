using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public GameObject[] backgrounds; // ”wŒiƒXƒvƒ‰ƒCƒg
    public float[] speeds; // Še”wŒi‚Ì‘¬“x

    private Vector3 startPosition; // ŠJŽnˆÊ’u
    private float length; // ”wŒi‚Ì’·‚³

    void Start()
    {
        startPosition = backgrounds[0].transform.position;
        length = backgrounds[0].GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        for (int i = 0; i < backgrounds.Length; i++)
        {
            float newPosition = Mathf.Repeat(Time.time * speeds[i], length);
            backgrounds[i].transform.position = startPosition + Vector3.left * newPosition;

            if (backgrounds[i].transform.position.x <= -10.0f)
            {
                backgrounds[i].transform.position = new Vector3(10.0f, backgrounds[i].transform.position.y, backgrounds[i].transform.position.z);
            }
        }
    }
}

