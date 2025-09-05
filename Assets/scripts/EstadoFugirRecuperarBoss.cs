using UnityEngine;

public class EstadoFugirRecuperarBoss : BaseState<BossFSM.EstadoBoss>
{
    public EstadoFugirRecuperarBoss(BossFSM.EstadoBoss key ): base( key ){}
    
   
    public override void UpdateState()
    {
        var boss = (BossFSM)MyFsm;
        boss.vidaA += 5f * Time.deltaTime; 
        boss.vidaA= Mathf.Clamp(boss.vidaA, 0, boss.vidaM);

        Debug.Log("Boss está FUGINDO e RECUPERANDO vida...");
    }

    public override BossFSM.EstadoBoss GetNextState()
    {
        var boss = (BossFSM)MyFsm;

        if (boss.vidaA <= 0) return BossFSM.EstadoBoss.Morto;
        if (boss.vidaA > 30) return BossFSM.EstadoBoss.Perseguir;

        return StateKey;
    }
}
