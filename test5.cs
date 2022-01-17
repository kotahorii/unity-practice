using System;
using System.Numerics;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
  private float startAt;
  private IEnumerator testLoop;
  // Start is called before the first frame update
  void Start()
  {
    startAt = Time.realtimeSinceStartup;
    testLoop = TestLoop();

    StartCoroutine(testLoop);
  }

  // Update is called once per frame
  void Update()
  {

  }

  private IEnumerator TestLoop()
  {

    while (true)
    {
      var lifeTime = Time.realtimeSinceStartup - startAt;
      UnityEngine.Debug.Log("オブジェクトの生存時間(秒)：" + lifeTime);

      if (lifeTime >= 30)
      {
        UnityEngine.Debug.Log("Stopped");
        yield break;
      }
      yield return new WaitForSeconds(1f);
    }
  }
}








