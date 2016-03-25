
public enum DIRECTION
{
    LEFT,
    RIGHT,
    UP,
    DOWN,
    NONE,
}

// 캐릭터의 상태값
public enum CHARACTER_STATE
{
    IDLE,
    MOVE,
    ATTACK,
    MOVETO,
    DIE,
}

// 캐릭터의 애니메이션상태(Animator에서도 사용할 예정)
public enum ANIMATION_STATE
{
    IDLE,   // 0
    RUN,    // 1
}