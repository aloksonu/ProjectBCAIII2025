using UnityEngine;

public class SantaManager : MonoBehaviour
{
    public Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //animator.Play("AnimationJump");
        animator.Play("AnimationRun");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
