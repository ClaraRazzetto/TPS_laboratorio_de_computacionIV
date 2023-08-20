using System;

// Clase base para los repartidores
abstract class Repartidor
{
    public abstract void Entregar();
}

// Implementación de un tipo de repartidor: en moto
class RepartidorEnMoto : Repartidor
{
    public override void Entregar()
    {
        //Entrega por Moto
    }
}

// Implementación de un tipo de repartidor: drone
class DroneRepartidor : Repartidor
{
    public override void Entregar()
    {
        //Entrega por drone.
    }
}

// Interfaz para la fábrica de repartidores
interface IFabricaRepartidores
{
    Repartidor CreateRepartidor();
    public void ModifiedRepartidor();
    public void DeleteRepartidor();
}

// Implementación de la fábrica de repartidores en moto
class FabricaRepartidoresEnMoto : IFabricaRepartidores
{
    public Repartidor CreateRepartidor()
    {
        return new RepartidorEnMoto();
    }
    public void ModifiedRepartidor()
    {
        //Modifica repartidor
    }
    public void DeleteRepartidor()
    {
        //Elimina repartidor
    }
}

// Implementación de la fábrica de repartidores con drones
class FabricaRepartidoresConDrones : IFabricaRepartidores
{
    public Repartidor CreateRepartidor()
    {
        return new DroneRepartidor();
    }
    public void ModifiedRepartidor()
    {
        //Modifica repartidor
    }
    public void DeleteRepartidor()
    {
        //Elimina repartidor
    }
}

// Clase que maneja la entrega de productos
public class Pedido
{
    //demas atributos ya implementados
    public string TypeDelivery { get; set; }
}

public class User
{
    //Demas atributos ya implementados...
    public string TypeUser { get; set; }
}

class Program
{
    static void Main()
    {
        User user = new User();
        Pedido pedido = new Pedido();

        if (user.TypeUser != "premium" || pedido.typeDelivery == "moto") {
            FabricaRepartidoresEnMoto fabricaMotos = new FabricaRepartidoresEnMoto();

            Repartidor repartidorMoto = fabricaDrones.CreateRepartidor();
            repartidorMoto.Entregar();
        } else
        {
            FabricaRepartidoresConDrones fabricaDrones = new FabricaRepartidoresConDrones();

            Repartidor repartidorDrone = fabricaDrones.CreateRepartidor();
            repartidorDrone.Entregar();
        }
    }
}
