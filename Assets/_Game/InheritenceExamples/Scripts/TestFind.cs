using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TestFind : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var ans1 = FindObjectsOfType<MB_A>().Where(x => x.GetType() == typeof(MB_A));
        print($"Ans1={ans1.Count()}");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
