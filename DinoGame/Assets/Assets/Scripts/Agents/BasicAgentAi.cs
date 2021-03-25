using UnityEngine;
using UnityEngine.AI;

public class BasicAgentAi : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private NavMeshAgent _agent;

    /*[SerializeField] private float _moveSpeed = 3f;
    [SerializeField] private float _rotSpeed = 3f;

    [SerializeField] private bool _isWandering =  false;
    [SerializeField] private bool _isRotatingLeft =  false;
    [SerializeField] private bool _isRotatingRight =  false;
    [SerializeField] private bool _isWalking =  false;*/

    private Vector3 _targettmp = Vector3.zero;
    [SerializeField] private float _maxTargetDistance = 100.0f;
    [SerializeField] private LayerMask _groundLayer;

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                _agent.SetDestination(hit.point);
            }
        }*/
        if(_targettmp == Vector3.zero || Vector3.Distance(gameObject.transform.position, _targettmp) < 1.5f)
        {
            RaycastHit hit;
            if (Physics.Raycast(FindRandomTarget(), -Vector3.up, out hit, 20f, _groundLayer))
            {
                _targettmp = hit.point;
                _agent.SetDestination(hit.point);
            }
        }
    }

    public Vector3 FindRandomTarget()
    {
        Vector3 newPos = gameObject.transform.position;

        newPos.x += Random.Range(-_maxTargetDistance, _maxTargetDistance);
        newPos.y += Random.Range(-_maxTargetDistance, _maxTargetDistance);
        newPos.z += 10f;

        return newPos;
    }
}
