using System;

namespace Tutoria{
	
public class Tutoria{
	public static void Main(){
		Chequera a = new Chequera(400);
		CuentaBancaria b = new Chequera(300);
		b.Depositar(300);
		b.retirar(200);
		Console.WriteLine(b.Consultar());
	}
}
	

	public class CuentaBancaria{
	protected int balance;
	
	public CuentaBancaria(int balance){
		this.balance=balance;
	}
	
	public int Consultar(){
		return this.balance;
	}
	
	public virtual void Depositar(int dinero){
		this.balance= this.balance + dinero;
	}
	
	public virtual void retirar(int dinero){
		this.balance= this.balance - dinero;
	}
}
	
	public class Chequera:CuentaBancaria{
		public int contador;
		
		public Chequera(int balance):base(balance){
			this.contador=0;
		}
		
		public override void Depositar(int dinero){
			this.contador++;
			balance= balance + dinero;
		}
	
		public override void retirar(int dinero){
			this.contador++;
			balance= balance - dinero;
		} 
	}
}
