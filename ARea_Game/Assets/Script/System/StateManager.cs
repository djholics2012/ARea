using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// 상태 관리 클래스. State의 변경을 관리하는 클래스이다. Ally, Enemy 모두 관리하는 클래스
/// </summary>
/// 

public class StateManager<T>
{
    private T _owner; // 형식의 일반화
    private Dictionary<int, State<T>> _stateList = new Dictionary<int, State<T>>();
    /// <summary>
    /// C#의 Dictionary 클래스이다.<>안의 값은 키의 값과 컬렉션을 나타닌다.
    /// </summary>
    private State<T> _curState = null; // 현재 state값
    private CHARACTER_STATE _curStateID = CHARACTER_STATE.IDLE;

    public CHARACTER_STATE CurStateID { get { return _curStateID; } }
    public StateManager(T owner) { _owner = owner; }

    public void AddState(int stateID, State<T> state) { _stateList.Add(stateID, state); }
    public void ChangeState(int stateID)
    {
        if(!_stateList.ContainsKey(stateID))
        {
            Debug.LogError("State not found.");
            return;
        }

        State<T> newState = _stateList[stateID];

        if (newState == null)   return;
        if (_curState == null)  return;
        if (_curState != null)  _curState.Exit(_owner);

        newState.Enter(_owner);

        _curState = newState;
        _curStateID = (CHARACTER_STATE)stateID;
    }

    public void Update()
    {
        if (_curState == null) return;
        _curState.Update(_owner);
    }

    public void FixedUpdate()
    {
        if (_curState == null) return;
        _curState.FixedUpdate(_owner);
    }
}