using UnityEngine;
public class CactusInteraction : MonoBehaviour
{
    public Transform otherCactus;
    public float fightDistance = 0.25f;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (!otherCactus) return;

        float distance = Vector3.Distance(transform.position, otherCactus.position);
        bool close = distance < fightDistance;

        anim.SetBool("isAttacking", close);
    }
}
