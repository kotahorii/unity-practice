using System;
using System.Numerics;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
  // Start is called before the first frame update
  void Start()
  {
    // var test = 1;
    // var value = test == 1 ? "test is 1" : "test is not 1";

    // var hp = 10;
    // if (hp < 10)
    // {
    //   UnityEngine.Debug.Log("danger");
    // }
    // else if (hp < 30)
    // {
    //   UnityEngine.Debug.Log("warning");
    // }
    // else
    // {
    //   UnityEngine.Debug.Log("safe");
    // }

    // for (int i = 0; i < 10; i++)
    // {
    //   if (i == 5) break;
    //   UnityEngine.Debug.Log(i);
    // }

    // var values = new int[] { 1, 10, 100, 1000 };
    // foreach (var item in values)
    // {
    //   UnityEngine.Debug.Log(item);
    // }

    // var num = 0;
    // while (num < 90)
    // {
    //   num = UnityEngine.Random.Range(0, 100);
    // }
    // UnityEngine.Debug.Log(num);

    var val = 1;

    switch (val)
    {
      case 1:
        UnityEngine.Debug.Log("Good morning");
        break;
      default:
        UnityEngine.Debug.Log("good evening");
        break;
    }
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void SaveLevel(int level)
  {
    if (level < 1 || 99 < level)
    {
      throw new System.Exception("レベルは1～99で指定してください");
    }

    PlayerPrefs.SetInt("level", level);

    PlayerPrefs.Save();
    UnityEngine.Debug.Log("レベルを保存しました！");
  }

  public String GenerateTestMessage(int value1, int value2)
  {
    return String.Format("{0}と{1}が渡されたよ！", value1, value2);
  }

  public class Character
  {
    private int _characterLevel;
    public int CharacterLevel
    {
      get
      {
        return _characterLevel;
      }

      set
      {
        _characterLevel = Mathf.Clamp(value, 1, 99);
      }
    }
  }
  public class Car
  {
    private Engine _engine;

    private class Engine
    {
      public Engine()
      {
        UnityEngine.Debug.Log("エンジンを作ったよ！");
      }
    }

    public Car()
    {
      _engine = new Engine();
    }
  }
}





