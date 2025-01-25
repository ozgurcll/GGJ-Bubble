using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    Player player => GetComponent<Player>();
    private void AttackTrigger()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(player.attackCheck.position, player.attackRange);

        foreach (var hit in colliders)
        {
            if (hit.GetComponent<Enemy>() != null)
            {
                hit.GetComponent<Enemy>().Die();
                player.fx.HitStopEffect(.2f, .2f);
            }
        }
    }

    private void EndAttack()
    {
        player.anim.SetBool("Attack", false);
    }
}
