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
            // TESTE 2: Imprimir usando o teu novo ToString()
            // ==========================================
            Console.WriteLine(">> Testando os Atributos Iniciais (com ToString):");
            
            // Passar o objeto diretamente faz o C# chamar o teu ToString() automaticamente!
            Console.WriteLine(settler); 
            Console.WriteLine(soldier); 

            Console.WriteLine();

            // ==========================================
            // TESTE EXTRA: Testar o método Attack()
            // ==========================================
            Console.WriteLine(">> O Soldier ataca o Settler! (Dano = 10)");
            soldier.Attack(settler); // Soldier ganha +1 XP, Settler perde 10 de vida

            Console.WriteLine("\n>> Atributos após o ataque (com ToString):");
            
            // Verificamos o estado atualizado das unidades usando novamente o ToString()
            Console.WriteLine(settler);
            Console.WriteLine(soldier);
        }
    }
}