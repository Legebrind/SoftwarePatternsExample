
public interface IMovementStrategy 
{ 
    void Move(IEnemy enemy); 
}

public class PatrolMovement : IMovementStrategy 
{ 
    public void Move(IEnemy enemy) 
    { 
        Console.WriteLine("El enemigo está patrullando."); 
    } 
}

public class ChaseMovement : IMovementStrategy 
{ 
    public void Move(IEnemy enemy) 
    { 
        Console.WriteLine("El enemigo está persiguiendo al jugador."); 
    } 
}

public interface IEnemy 
{ 
    void SetMovementStrategy(IMovementStrategy strategy); 
}

public class Orc : IEnemy 
{
    private IMovementStrategy movementStrategy;

    public Orc() 
    { 
        movementStrategy = new PatrolMovement(); 
    }

    public void SetMovementStrategy(IMovementStrategy strategy) 
    { 
        movementStrategy = strategy; 
    }

    public void Update() 
    { 
        movementStrategy.Move(this); 
    }
}
