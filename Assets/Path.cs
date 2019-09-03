using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    public Color pathColor = Color.green;

    private Transform[] objArray;

    public List<Transform> pathObjList = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = pathColor;
        objArray = GetComponentsInChildren<Transform>();
        pathObjList.Clear();
        foreach (var obj in objArray)
        {
            if (obj != transform) pathObjList.Add(obj);
        }

        for (var i = 1; i < pathObjList.Count; i++)
        {
            Gizmos.DrawLine(pathObjList[i-1].position, pathObjList[i].position);
            Gizmos.DrawWireSphere(pathObjList[i].position, 0.3f);
        }
    }
}
