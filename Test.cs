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

    lists.Add(999);

    var dic = new Dictionary<string, int> { { "1", 1 }, { "2", 2 }, { "3", 3 } };

    UnityEngine.Debug.Log(dic.Count);

    dic["1"] = 100;

    UnityEngine.Debug.Log(dic["1"]);

    dic.Add("four", 4);

    UnityEngine.Debug.Log(dic.Count);
  }

  enum GameMode
  {
    Easy,
    Normal,
    Difficult
  }

  GameMode gameMode = GameMode.Easy;

  // Update is called once per frame
  void Update()
  {

  }
}
