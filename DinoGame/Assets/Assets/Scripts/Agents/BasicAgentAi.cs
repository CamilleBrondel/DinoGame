using UnityEngine;
using UnityEngine.AI;

public class BasicAgentAi : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private NavMeshAgent _agent;

    [SerializeField] private float _moveSpeed = 3f;
    [SerializeField] private float _rotSpeed = 3f;

    [SerializeField] private bool _isWandering =  false;
    [SerializeField] private bool _isRotatingLeft =  false;
    [SerializeField] private bool _isRotatingRight =  false;
    [SerializeField] private bool _isWalking =  false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = _cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                _agent.SetDestination(hit.point);
            }
        }
    }
}
