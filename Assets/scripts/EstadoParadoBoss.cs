using UnityEngine;

public class EstadoParadoBoss : BaseState<BossFSM.EstadoBoss>
{
   public EstadoParadoBoss(BossFSM.EstadoBoss key) : base(key){}
   public override BossFSM.EstadoBoss GetNextState()
   {
      var boss = (BossFSM)MyFsm;
      if (Vector3.Distance(boss.transform.position, boss.jogador.position) < boss.alcanceDeteccao)
         return BossFSM.EstadoBoss.Perseguir;

      return StateKey;
   }
}
