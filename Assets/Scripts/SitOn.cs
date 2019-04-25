using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.AI;

public class SitOn : MonoBehaviour
{
    public GameObject character;
    Animator anim;
    bool isWalkingTowards = false;
    bool sittingOn = false;

    //[SerializeField]
    //Transform _destination;
   // NavMeshAgent _navMeshAgent;

   /* void OnMouseDown()
    {
        if (!sittingOn)
        {
            anim.SetTrigger("isWalking");
            isWalkingTowards = true;
        }
    }*/
    void Start()
    {
       //_navMeshAgent = this.GetComponent<NavMeshAgent>();
        //if(_navMeshAgent == null)
       // {
      //     Debug.LogError("NavMeshAgent not attached to " + gameObject.name);
       // }
      //  else
       // {
      //      SetDestination();
      //  }

        anim = character.GetComponent<Animator>();
        if (!sittingOn)
        {

            anim.SetTrigger("isWalking");
            isWalkingTowards = true;
        }
    }
    //private void SetDestination()
   // {
    //    if(_destination != null)
      //  {
    //        Vector3 targetVector = _destination.transform.position;
     //       _navMeshAgent.SetDestination(targetVector);
       // }
//    }

    void Update()
    {
        if(isWalkingTowards)
        {
            //Vector3 targetDir;
            //targetDir = new Vector3(transform.position.x - character.transform.position.x, 0f, transform.position.z - character.transform.position.z);
            //Quaternion rot = Quaternion.LookRotation(targetDir);
            //character.transform.rotation = Quaternion.Slerp(character.transform.rotation, rot, 0.05f);
            //character.transform.Translate(Vector3.forward * 0.1f);
            if(Vector3.Distance(character.transform.position, this.transform.position)<0.6)
            {
                anim.SetTrigger("isSitting");
                character.transform.rotation = this.transform.rotation;
                isWalkingTowards = false;
                sittingOn = true;
            }
            //character.transform.Translate(Vector3.up * Time.deltaTime, Space.World);
        }
    }
}
