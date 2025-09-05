using UnityEngine;

public class EstadoPerseguirBoss : BaseState<BossFSM.EstadoBoss>
{
  public EstadoPerseguirBoss(BossFSM.EstadoBoss key): base(key){}


  public override void UpdateState()
  {
    var boss = (BossFSM)MyFsm;
    boss.MoverPara(boss.jogador.position);
  }

  public override BossFSM.EstadoBoss GetNextState()
  {
    var boss = (BossFSM)MyFsm;
    if (boss.vidaA <= 0) return BossFSM.EstadoBoss.Morto; //se o boss tiver vida -0 vai para estado morto
    if (boss.EstaComPoucaVida()) return BossFSM.EstadoBoss.FugirRecuperar;//com vida puica ele entra no estado fugir
    if (boss.EstaComMetadeDaVida()) return BossFSM.EstadoBoss.AtaqueEspecial; // com 50% vai para estado de ataque especial
    
    
    ///se o jogador tiver na possicao de distancia ele vai atacar ele
    float dist = Vector3.Distance(boss.transform.position, boss.jogador.position);
    if (dist <= boss.alcanceAtacar) return BossFSM.EstadoBoss.Atacar; 
    return StateKey;

  }
}
