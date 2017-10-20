package org.institutoserpis.ed;

import java.util.Scanner;



public class JHolaMundo {
	public static void main(String[] args) {
		int primerNumero, segundoNumero;
		System.out.print("Dime un numero: ");
		int primero = Integer.parseInt(primerNumero);
		Scanner scanner = new Scanner (System.in);
		System.out.print("Dime otro: ");
		
		int segundo = Integer.parseInt(segundoNumero);
		String nombre = scanner.nextLine();
		System.out.println("Hoooola " + nombre);
	}

}
