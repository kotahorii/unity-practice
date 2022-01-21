using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReciprocatingObstacle : BaseObstacleController
{

  [SerializeField]
  protected float moveX = 0;
  [SerializeField]
  protected float moveY = 0;
  [SerializeField]
  protected float moveZ = 0;
  [SerializeField]
  protected float speed = 0;

  protected float step;
  protected bool goBack = false;
  protected Vector3 origin;
  protected Vector3 destination;

  protected override void Start()
  {
    origin = transform.position;
    destination = new Vector3(origin.x - moveX, origin.y - moveY, origin.z - moveZ);
  }

  protected override void FixedUpdate()
  {
    if (stop)
    {
      return;
    }

    step = speed * Time.deltaTime;

    if (!goBack)
    {
      transform.position = Vector3.MoveTowards(transform.position, destination, step);

      if (transform.position == destination)
      {
        goBack = true;

        StartCoroutine(WaitTimer());
      }
    }
    else
    {
      transform.position = Vector3.MoveTowards(transform.position, origin, step);

      if (transform.position == origin)
      {
        goBack = false;

        StartCoroutine(WaitTimer());
      }
    }
  }

  protected virtual void OnTriggerEnter(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      other.gameObject.transform.SetParent(gameObject.transform);
    }
  }

  protected virtual void OnTriggerExit(Collider other)
  {
    if (other.gameObject.CompareTag("Player"))
    {
      other.gameObject.transform.SetParent(null);
    }
  }

}