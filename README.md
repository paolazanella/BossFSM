#  FSM do Boss em Unity (2D)

Este projeto implementa uma **Máquina de Estados Finitos (FSM)** para controlar o comportamento de um Boss em um jogo 2D feito no Unity.  
O código segue a mesma estrutura usada em sala de aula (exemplo do GuardaFSM), mas adaptado para o Boss.

---

## ⚙ Funcionalidades

O Boss possui os seguintes estados:

- **Parado (Idle):** fica inativo até detectar o jogador.
- **Perseguir (Chase):** se move em direção ao jogador.
- **Atacar (Attack):** executa ataques corpo a corpo quando o jogador está próximo.
- **Ataque Especial (SpecialAttack):** ativa ataques em área quando a vida está abaixo de 50%.
- **Fugir e Recuperar (FleeRecover):** recua e regenera vida quando está com menos de 20%.
- **Morto (Dead):** desativa o Boss quando sua vida chega a 0.

---

## 📂 Estrutura de Pastas

Assets/
 └── Scripts/
      ├── BaseState.cs                  # Classe base para todos os estados
      ├── StateMachineManager.cs        # Gerenciador da FSM
      │
      ├── BossFSM.cs                    # FSM principal do Boss
      ├── EstadoParadoBoss.cs           # Estado: Parado
      ├── EstadoPerseguirBoss.cs        # Estado: Perseguir jogador
      ├── EstadoAtacarBoss.cs           # Estado: Atacar jogador
      ├── EstadoAtaqueEspecialBoss.cs   # Estado: Ataque especial
      ├── EstadoFugirRecuperarBoss.cs   # Estado: Fugir e recuperar vida
      ├── EstadoMortoBoss.cs            # Estado: Morto
      │
      └── PlayerMovimento.cs            # Script simples para mover o jogador



