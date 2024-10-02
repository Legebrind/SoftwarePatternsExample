
public interface IPlayer 
{ 
    int Health { get; set; } 
    void TakeDamage(int damage);
    void Attach(IObserver observer); 
    void Detach(IObserver observer); 
}

public class Player : IPlayer 
{ 
    public int Health { get; set; } = 100; 
    private List<IObserver> observers = new List<IObserver>();

    public void TakeDamage(int damage) 
    { 
        Health -= damage; 
        Console.WriteLine("El jugador recibe " + damage + " de daño. Salud restante: " + Health);
        NotifyObservers(); 
    }

    public void Attach(IObserver observer) 
    { 
        observers.Add(observer); 
    }

    public void Detach(IObserver observer) 
    { 
        observers.Remove(observer); 
    }

    private void NotifyObservers() 
    { 
        foreach (var observer in observers) 
        { 
            observer.Update(this); 
        } 
    } 
}

public interface IObserver 
{ 
    void Update(IPlayer player); 
}

public class HealthBar : IObserver 
{ 
    public void Update(IPlayer player) 
    { 
        // Código para representar la salud restante
    } 
}

public class SoundEffect : IObserver 
{ 
    public void Update(IPlayer player) 
    { 
        if (player.Health <= 0) 
        { 
            // Código para ejecutar el sonido de muerte
        } 
        else if (player.Health <= 25) 
        { 
            // Código para ejecutar el sonido de vida baja
        } 
    } 
}
