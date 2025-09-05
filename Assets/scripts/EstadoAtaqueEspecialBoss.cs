using UnityEngine;

public class EstadoAtaqueEspecialBoss : BaseState<BossFSM.EstadoBoss>
{
     private float tempoRecarega = 3f;
     private float contador = 0f;

     public EstadoAtaqueEspecialBoss(BossFSM.EstadoBoss key) : base(key){}

     public override void UpdateState()
     {
          contador += Time.deltaTime;
          if (contador>=tempoRecarega)
          {
               Debug.Log("Chefao usou o ataque especial");
               contador = 0f;
          }
     }

     public override BossFSM.EstadoBoss GetNextState()
     {
          var boss = (BossFSM)MyFsm;
          if (boss.vidaA<=0 ) return BossFSM.EstadoBoss.Morto;
          if (boss.EstaComPoucaVida()) return BossFSM.EstadoBoss.FugirRecuperar;
          
          return BossFSM.EstadoBoss.Perseguir;
     }
}
