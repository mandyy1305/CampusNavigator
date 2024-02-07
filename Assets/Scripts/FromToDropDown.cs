using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromToDropDown : MonoBehaviour
{
    public Transform[] points; 
    public GameObject from;
    public GameObject to;
    public void HandleFromInput(int i)
    {
       if (i == 0) { from.transform.position = to.transform.position; return; }
       from.transform.position = points[i].transform.position; 
    }
    public void HandleToInput(int i)
    {
        if (i == 0) { to.transform.position = from.transform.position; return; }
        to.transform.position = points[i].transform.position;
    }
}
