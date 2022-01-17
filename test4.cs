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
    var sportCar = new SportCar();
    sportCar.Run();
    sportCar.Stop();
  }

  // Update is called once per frame
  void Update()
  {

  }

  abstract public class Car
  {
    public virtual void Run()
    {
      UnityEngine.Debug.Log("走るよ！");
    }

    public void Stop()
    {
      UnityEngine.Debug.Log("止まるよ！");
    }
  }

  public class SportCar : Car
  {
    public override void Run()
    {
      UnityEngine.Debug.Log("超早く");
      base.Run();
    }
  }
}





