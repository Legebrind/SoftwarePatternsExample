
public interface ICommand 
{ 
    void Execute(); 
}

public class EnemyAttackCommand : ICommand 
{ 
    private IEnemy enemy; 
    private IPlayer player;

    public EnemyAttackCommand(IEnemy enemy, IPlayer player) 
    { 
        this.enemy = enemy; 
        this.player = player; 
    }

    public void Execute() 
    { 
        enemy.Attack(player); 
    } 
}

public class Orc : IEnemy 
{
    private ICommand attackCommand;

    public void SetAttackCommand(ICommand command) 
    { 
        attackCommand = command; 
    }

    public void Attack(IPlayer player) 
    { 
        if (attackCommand != null) 
        { 
            attackCommand.Execute(); 
        } 
    }
}
