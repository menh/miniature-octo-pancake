using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.AI;

public class InteractableObject : MonoBehaviour
{
    private NavMeshAgent playerAgent = null;
    private bool haveInteracted = false;
    // Start is called before the first frame update
    public void OnClick(NavMeshAgent playerAgent)
    {
        print("ONclick");
        this.playerAgent = playerAgent;
        playerAgent.stoppingDistance = 2;
        playerAgent.SetDestination(transform.position);
        //Interact();
    }

    private void Update()
    {
        if(playerAgent != null && playerAgent.pathPending == false && haveInteracted == false)
        {
            if (playerAgent.remainingDistance <=2)
            {
                Interact();
                haveInteracted = true;
            }
        }
    }

    // Update is called once per frame
    protected virtual void Interact()
    {
        print("1111111111");
    }
}
