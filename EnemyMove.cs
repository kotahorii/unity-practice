using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour
{
  [SerializeField] private PlayerController _playerController;
  private NavMeshAgent _agent;
  // Start is called before the first frame update
  private void Start()
  {
    _agent = GetComponent<NavMeshAgent>();
  }

  // Update is called once per frame
  private void Update()
  {
    _agent.destination = _playerController.transform.position;
  }
}
