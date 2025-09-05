using UnityEngine;

public class EstadoMortoBoss : BaseState<BossFSM.EstadoBoss>
{
    public EstadoMortoBoss(BossFSM.EstadoBoss key) : base(key) { }

    public override void EnterState()
    {
        var boss = (BossFSM)MyFsm;
        Debug.Log("Boss MORREU!");
        boss.gameObject.SetActive(false);
    }

    public override BossFSM.EstadoBoss GetNextState() => StateKey;
}
