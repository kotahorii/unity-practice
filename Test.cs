using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    int[] values = new int[] { 1, 2, 3 };

    UnityEngine.Debug.Log(values.Length);

    UnityEngine.Debug.Log(values[0]);

    values[0] = 100;

    UnityEngine.Debug.Log(values[0]);

  }

  // Update is called once per frame
  void Update()
  {

  }
}
