using UnityEngine;
using System.Collections.Generic;
public class BossFSM : StateMachineManager<BossFSM.EstadoBoss>
{
    public enum EstadoBoss
    {
        Parado,
        Perseguir,
        Atacar, 
        AtaqueEspecial,
        FugirRecuperar,
        Morto
    }

   

    /// estado incial
    protected override EstadoBoss StartingStateKey { get; } = EstadoBoss.Parado;

    [Header("configuraoes")] public float alcanceDeteccao = 15f;
    public float alcanceAtacar = 3f;
    public float velocidadeMovimentacao = 2f;


    [Header("vida")] public float vidaM = 100f;
    public float vidaA = 100f;
    
    [Header("referencias")]
    public Transform jogador;

    
    ///dicinorio dos estados para enum    
    protected override Dictionary<EstadoBoss, BaseState<EstadoBoss>> States  { get; set; } =
        new Dictionary<EstadoBoss, BaseState<EstadoBoss>>()
        {
            { EstadoBoss.Parado , new EstadoParadoBoss(EstadoBoss.Parado)},
            { EstadoBoss.Perseguir, new EstadoPerseguirBoss(EstadoBoss.Perseguir)},
            { EstadoBoss.Atacar, new EstadoAtacarBoss(EstadoBoss.Atacar)},
            { EstadoBoss.AtaqueEspecial, new EstadoAtaqueEspecialBoss(EstadoBoss.AtaqueEspecial)},
            { EstadoBoss.FugirRecuperar, new EstadoFugirRecuperarBoss(EstadoBoss.FugirRecuperar)},
            { EstadoBoss.Morto,new EstadoMortoBoss(EstadoBoss.Morto)}
        };
    
    
    public bool EstaComMetadeDaVida()=> vidaA< vidaM * 0.5f;
    public bool EstaComPoucaVida() => vidaA < vidaM * 0.2f;
    public void MoverPara(Vector3 destino)
    {
        Vector3 direcao = (destino - transform.position).normalized;
        transform.position += direcao * (velocidadeMovimentacao* Time.deltaTime);
    }
    
    
}
