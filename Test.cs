using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    var test = "TEST!!";

    Debug.Log(test);

    Debug.Log(test.Length);

    test = null;

    Debug.Log(test.Length);
  }

  // Update is called once per frame
  void Update()
  {

  }
}
