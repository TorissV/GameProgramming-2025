using UnityEngine;
using UnityEngine.AI;

public class NavMeshMover : MonoBehaviour, IMovable
{
    private NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public void Move()
    {
        if (agent != null)
        {
            agent.SetDestination(Vector3.zero); // Пример
            Debug.Log("NavMeshMover: Moving to (0,0,0).");
        }
    }
}