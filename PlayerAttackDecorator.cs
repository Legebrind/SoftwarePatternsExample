
public interface IAttack 
{ 
    void Execute(IPlayer player, IEnemy enemy); 
}

public class BasicAttack : IAttack 
{ 
    public void Execute(IPlayer player, IEnemy enemy) 
    { 
        int damage = player.AttackPower; 
        enemy.TakeDamage(damage); 
        Console.WriteLine("El jugador ataca con un ataque básico e inflige " + damage + " de daño."); 
    } 
}

public abstract class AttackDecorator : IAttack 
{ 
    protected IAttack attack;

    public AttackDecorator(IAttack attack) 
    { 
        this.attack = attack; 
    }

    public virtual void Execute(IPlayer player, IEnemy enemy) 
    { 
        attack.Execute(player, enemy); 
    }
}

public class FireAttackDecorator : AttackDecorator 
{ 
    public FireAttackDecorator(IAttack attack) : base(attack) { }

    public override void Execute(IPlayer player, IEnemy enemy) 
    { 
        base.Execute(player, enemy);
        int fireDamage = 10; 
        enemy.TakeDamage(fireDamage);
    }
}

public class IceAttackDecorator : AttackDecorator 
{ 
    public IceAttackDecorator(IAttack attack) : base(attack) { }

    public override void Execute(IPlayer player, IEnemy enemy) 
    { 
        base.Execute(player, enemy);
        // Lógica adicional para el ataque de hielo (ralentizar al enemigo, etc.)
    }
}
