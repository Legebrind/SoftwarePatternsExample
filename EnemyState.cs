
public interface IEnemyState 
{ 
    void Update(IEnemy enemy); 
    void OnEnter(IEnemy enemy); 
    void OnExit(IEnemy enemy); 
}

public class PatrollingState : IEnemyState 
{ 
    public void Update(IEnemy enemy) 
    { 
        if (/* El jugador está a la vista */) 
        { 
            enemy.ChangeState(new ChasingState()); 
        } 
    }

    public void OnEnter(IEnemy enemy) 
    { 
        // Lógica de patrullaje
    }

    public void OnExit(IEnemy enemy) 
    { 
        // Lógica para salir del estado de patrullaje
    }
}

public class ChasingState : IEnemyState 
{ 
    public void Update(IEnemy enemy) 
    { 
        if (/* El jugador está cerca */) 
        { 
            enemy.ChangeState(new AttackingState()); 
        } 
    }

    public void OnEnter(IEnemy enemy) 
    { 
        // Lógica de persecución
    }

    public void OnExit(IEnemy enemy) 
    { 
        // Lógica para salir del estado de persecución
    }
}

public class AttackingState : IEnemyState 
{ 
    public void Update(IEnemy enemy) 
    { 
        enemy.Attack(player);
    }

    public void OnEnter(IEnemy enemy) 
    { 
        // Lógica de ataque
    }

    public void OnExit(IEnemy enemy) 
    { 
        // Lógica para salir del estado de ataque
    }
}
