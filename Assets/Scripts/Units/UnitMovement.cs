using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour
{
    NavMeshAgent agent;
    //public Transform targetDestination;
    public GameObject selectedSprite;

    // Start is called before the first frame update
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveToTarget(Vector3 targetDestination)
    {
        agent.destination = targetDestination;
    }

    public void ToggleSelect(bool _Selected)
    {
        selectedSprite.SetActive(_Selected);
    }
}
