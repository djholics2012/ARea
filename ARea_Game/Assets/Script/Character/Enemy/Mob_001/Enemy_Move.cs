using UnityEngine;
using System.Collections;
using System;

public class Enemy_Move : State<Enemy_Unit> {

    public override void Enter(Enemy_Unit owner)
    {
        owner.SetAnimation(ANIMATION_STATE.RUN);
        owner.MoveToTarget( ); // 목표 위치로 이동한다.
        throw new NotImplementedException( );
    }

    public override void Update(Enemy_Unit owner)
    {
        base.Update(owner);

        owner.MoveToTarget( );

        GameObject target = owner.SearchTarget();
        if (target != null)
        {
            owner.TargetObj = target;
            owner.ChangeState(CHARACTER_STATE.MOVE);
            return;
        }

        if (owner.IsReachTargetPos( ))
        {
            Debug.Log(owner.TargetPos);
            owner.ChangeState(CHARACTER_STATE.IDLE);
            return;
        }
    }

    public override void FixedUpdate(Enemy_Unit owner)
    {
        base.FixedUpdate(owner);
    }

    public override void Exit(Enemy_Unit owner)
    {
        throw new NotImplementedException( );
    }
}
