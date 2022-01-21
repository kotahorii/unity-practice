using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundController : MonoBehaviour
{

  int counter = 0;
  [SerializeField] private float _maxDistance = 200;
  [SerializeField] private float _speed = 0.01f;
  [SerializeField] private Vector3 _move = new Vector3(1, 0, 0);

  // Update is called once per frame
  void Update()
  {
    transform.Translate(_move * _speed);
    counter++;

    if (counter == _maxDistance)
    {
      counter = 0;
      _move *= -1;
    }
  }
}
