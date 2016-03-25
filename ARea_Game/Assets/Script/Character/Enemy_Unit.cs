using UnityEngine;
using System.Collections;

public class Enemy_Unit : CharacterBase<Enemy_Unit>
{
    protected override void Start()
    {
        base.Start( );

        // 상태
        /// <summary>
        /// AddState(CHARACTER_STATE.IDLE, new Enemy_Idle( ));
        /// AddState(CHARACTER_STATE.MOVE, new Enemy_Move( ));
        /// AddState(CHARACTER_STATE.MOVETO, new Enemy_MoveTo( ));
        /// AddState(CHARACTER_STATE.ATTACK, new Enemy_Attack( ));
        /// ChangeState(CHARACTER_STATE.IDLE);
        /// </ summary >
    }       

    protected override void Update( )
    {
        base.Update( );

    }

    protected override void FixedUpdate( )
    {
        base.FixedUpdate( );
    }

    public void ReceiveDamage(int damage)
    {
        Hp -= damage;
        Debug.Log(Hp);

        if (Hp <= 0)
            Destroy(gameObject);    // State->Die로 바꿔야할것이다.
    }

    public GameObject SearchTarget( )
    {
   //     GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
   //     if (playerObj == null)
   //         return null;
   //
   //     float SqrRange = _searchRange * _searchRange;
   //     if (Vector3.SqrMagnitude(transform.position - playerObj.transform.position) <= SqrRange)
   //     {
   //         return playerObj;
   //     }
   //
        return null;
    }


}
