// See https://aka.ms/new-console-template for more information
using System;

// Interface untuk state
public interface IState
{
    void Operate();
}

// Implementasi state terkunci
public class LockedState : IState
{
    public void Operate()
    {
        Console.WriteLine("Pintu terkunci. Tidak bisa dibuka.");
    }
}

// Implementasi state terbuka
public class UnlockedState : IState
{
    public void Operate()
    {
        Console.WriteLine("Pintu sudah terbuka.");
    }
}

public class DoorMachine
{
    private IState currentState;

    public DoorMachine(IState initialState)
    {
        currentState = initialState;
    }

    // Method untuk menjalankan operasi pada state saat ini
    public void Operate()
    {
        currentState.Operate();
    }

    // Method untuk mengganti state
    public void ChangeState(IState newState)
    {
        currentState = newState;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Membuat objek DoorMachine dengan state terkunci
        DoorMachine doorMachine = new DoorMachine(new LockedState());

        // Pintu awalnya terkunci
        doorMachine.Operate(); // Output: Pintu terkunci. Tidak bisa dibuka.

        // Mengganti state menjadi terbuka
        doorMachine.ChangeState(new UnlockedState());

        // Membuka pintu
        doorMachine.Operate(); // Output: Pintu sudah terbuka.

        // Mengganti state menjadi terkunci
        doorMachine.ChangeState(new LockedState());

        // Mengunci pintu
        doorMachine.Operate(); // Output: Pintu terkunci. Tidak bisa dibuka.
    }
}

