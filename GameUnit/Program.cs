using System;

namespace GameUnit
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("--- A INICIAR TESTE DAS UNIDADES ---\n");

            // 1. Criar as instâncias das classes concretas
            // Criamos um colono (SettlerUnit)
            SettlerUnit settler = new SettlerUnit();
            // Criamos um soldado (MilitaryUnit) com: 2 de movimento, 5 de vida e 10 de poder de ataque
            MilitaryUnit soldier = new MilitaryUnit(2, 5, 10);

            // ==========================================
            // TESTE 1: Invocar o método Move() em cada uma
            // ==========================================
            Console.WriteLine(">> Testando o Movimento:");
            Console.Write($"{settler.GetType().Name} moveu-se: ");
            settler.Move();

            Console.Write($"{soldier.GetType().Name} moveu-se: ");
            soldier.Move();

            Console.WriteLine();

            // ==========================================
            // TESTE 2: Imprimir Health e Cost de cada uma
            // ==========================================
            Console.WriteLine(">> Testando os Atributos Iniciais:");
            Console.WriteLine($"[Settler] Vida: {settler.Health} | Custo: {settler.Cost}");
            Console.WriteLine($"[Soldier] vida: {soldier.Health} | Custo: {soldier.Cost}");

            Console.WriteLine();

            // ==========================================
            // TESTE EXTRA: Testar o método Attack()
            // ==========================================
            Console.WriteLine(">> O Soldier ataca o Settler! (Dano = 10)");
            soldier.Attack(settler); // Soldier ganha +1 XP, Settler perde 10 de vida

            Console.WriteLine("\n>> Atributos após o ataque:");
            // O Settler tinha 3 de vida, agora deve ter -7 (3 - 10)
            Console.WriteLine($"[Settler] Nova Vida: {settler.Health}");
            // O Soldier ganhou 1 de XP, logo o seu Cost deve ter aumentado em 1!
            Console.WriteLine($"[Soldier] Novo XP: {soldier.XP} | Novo Custo (AttackPower + XP) {soldier.Cost}");
        }
    }
}
