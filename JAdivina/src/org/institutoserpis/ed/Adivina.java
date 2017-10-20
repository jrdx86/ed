package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;


public class Adivina {

	public static void main(String[] args) {
		Random random = new Random();
	    int numeroAleatorio = random.nextInt(1000) + 1;
		Scanner scanner = new Scanner(System.in);
		System.out.println("Numero aleatorio="+ numeroAleatorio);
		System.out.print("Adivina el número de entre 1 a 1000:");
		
		String numero = scanner.nextLine();
		int numeroIntroducido = Integer.parseInt(numero);//convertir el string en numero manualmente para evitar errores con los espacios.
		while (numeroIntroducido != numeroAleatorio) {//!= se lee como distinto, si es distinto entrara en el bucle
			if(numeroAleatorio < numeroIntroducido) {
				System.out.print("Es menor. Vuelve a intentarlo:" );
			
			}
			else 
				System.out.print("Es mayor. Intentalo otra vez:");
			numero = scanner.nextLine();
			numeroIntroducido = Integer.parseInt(numero);
		}
		System.out.println("Enhorabuena. Has acertado, eres un maquina.");		
	}

	}		

