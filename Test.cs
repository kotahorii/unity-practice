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

    values[0] = 100;

    List<int> lists = new List<int> { 1, 2, 3 };

    UnityEngine.Debug.Log(lists.Count);

    lists.Add(999);

    UnityEngine.Debug.Log(lists[lists.Count - 1]);

  }

  // Update is called once per frame
  void Update()
  {

  }
}
