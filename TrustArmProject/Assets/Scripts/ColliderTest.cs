using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTest : MonoBehaviour
{
    public int grab = 2; // 0 - releases the object,  1 - grabs,  2 - does nothing.
    public GameObject anim;
    Collider CollidedWith;    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim.GetComponent<Animator>().speed = 0f;  // 0 - animator not active,  1 - animator plays forward, -1 - animator plays backward
    }

    // Update is called once per frame
    void Update()
    {
        if (grab == 1)
        {
            StartCoroutine(TestCoroutine());
        }

        if (grab == 0)
        {
            ReleaseObj();
        }
    }

    private void ReleaseObj() // doing the animation in reverse, ie, releasing the grabbed object
    {
        anim.GetComponent<Animator>().StartPlayback();
        anim.GetComponent<Animator>().speed = -1f;
        CollidedWith.transform.parent = null; // no longer part of the gripper 
        CollidedWith.GetComponent<Rigidbody>().isKinematic = false; // falls down
    }

    private void OnTriggerEnter(Collider other)
    {
        CollidedWith = other;
        print(other);
    }

    IEnumerator TestCoroutine()  // in order to work with time in Unity
    {
        grab = 2;  //
        anim.GetComponent<Animator>().speed = 1f;  // activate the animation
        yield return new WaitForSeconds(3.7f);  // wait for some time
        anim.GetComponent<Animator>().speed = 0f;  // stop the animation
        CollidedWith.GetComponent<Rigidbody>().isKinematic = true;  // activate it to move the body.
        CollidedWith.transform.parent = this.transform;
    }
}