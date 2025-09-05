using UnityEngine;

public class EstadoAtacarBoss : BaseState<BossFSM.EstadoBoss>
{
  public EstadoAtacarBoss(BossFSM.EstadoBoss key) : base(key){}

  public override void UpdateState()
  {
    Debug.Log("Estado atacar");
  }

  public override BossFSM.EstadoBoss GetNextState()
  {
    var boss = (BossFSM)MyFsm;

    if (boss.vidaA <= 0) return BossFSM.EstadoBoss.Morto;
    if (boss.EstaComPoucaVida()) return BossFSM.EstadoBoss.FugirRecuperar;
    if (boss.EstaComMetadeDaVida()) return BossFSM.EstadoBoss.AtaqueEspecial;

    float dist = Vector3.Distance(boss.transform.position, boss.jogador.position);
    if (dist > boss.alcanceAtacar) return BossFSM.EstadoBoss.Perseguir;

    return StateKey;
  }
  
  
}
