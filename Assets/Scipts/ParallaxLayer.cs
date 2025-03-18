using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Parallax
    { 
        public enum Layer
        {
        Foreground, Midground, Background
        }
    public static float speed = 4f;

    public static float GetSpeed(Layer layer)
        {
        switch (layer)
        {
            case Layer.Foreground:
            return speed * 1;
            case Layer.Midground:
            return speed * .5f;
            case Layer.Background:
            return speed * .05f;
            default:
            return speed * 1;
        }
    }
}

public class ParallaxLayer : MonoBehaviour
{
    public Transform[] tiles;

    public float left = -19f;
    public Vector3 right = new Vector3(19f, 0f, 0f);

    public float rate = 1f;
    
    void Update()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            tiles[i].position += Vector3.left * Time.deltaTime * Parallax.speed * rate;

            if (tiles[i].position.x <= left)
            {
                tiles[i].position = right;
            }
        }
    }
}
