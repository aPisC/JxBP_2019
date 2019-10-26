﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{
    public GameObject cell;
    public int width = 5, height = 5;

    // Start is called before the first frame update
    void Start()
    {
        float sin60 = Mathf.Sin(60 * Mathf.Deg2Rad);
        //Debug.Log(sin60);
        for(int i = 0; i < height; i++){
            for(int j = 0; j < width; j++){
                Vector3 pos = Vector3.zero;
                pos.x += (j-width/2f)*2*sin60;
                if(i%2== 1) pos.x += sin60;
                pos.y = i * .5f;
             //  Debug.Log(pos);
                GameObject c = GameObject.Instantiate(cell, transform);
                c.transform.localPosition = pos;
                
            }
        }

        float gw = (width +1.5f) * 2 * sin60;
        float gh = (height+1 )* 0.5f;

        float size = Mathf.Max(gw, gh);
        float diff = 2 / size;
        transform.localScale = new Vector3(diff, diff, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}