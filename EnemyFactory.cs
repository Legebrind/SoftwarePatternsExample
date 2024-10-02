
public interface IEnemy 
{ 
    int Health { get; set; } 
    int AttackPower { get; } 
    void Attack(IPlayer player); 
}

public class Orc : IEnemy 
{ 
    public int Health { get; set; } = 100; 
    public int AttackPower { get; } = 15;

    public void Attack(IPlayer player) 
    { 
        player.TakeDamage(AttackPower); 
        Console.WriteLine("¡El orco ataca!"); 
    } 
}

public class Troll : IEnemy 
{ 
    public int Health { get; set; } = 150; 
    public int AttackPower { get; } = 20;

    public void Attack(IPlayer player) 
    { 
        player.TakeDamage(AttackPower); 
        Console.WriteLine("¡El troll ataca!"); 
    } 
}

public abstract class EnemyFactory 
{ 
    public abstract IEnemy CreateEnemy(); 
}

public class OrcFactory : EnemyFactory 
{ 
    public override IEnemy CreateEnemy() 
    { 
        return new Orc(); 
    } 
}

public class TrollFactory : EnemyFactory 
{ 
    public override IEnemy CreateEnemy() 
    { 
        return new Troll(); 
    } 
}
