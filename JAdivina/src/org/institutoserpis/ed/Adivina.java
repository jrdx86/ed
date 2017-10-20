package org.institutoserpis.ed;

import java.util.Random;
import java.util.Scanner;


public class Adivina {

	public static void main(String[] args) {
		Random random = new Random();
	    int numeroAleatorio = random.nextInt(1000) + 1;
		Scanner scanner = new Scanner(System.in);
		
		int contadorDeIntentos = 1;
		
		System.out.println("Numero aleatorio="+ numeroAleatorio);
		System.out.printf("Adivina el número de entre 1 a 1000[intento %s] :",
				contadorDeIntentos);
		
		String numero = scanner.nextLine();
		int numeroIntroducido = Integer.parseInt(numero);//convertir el string en numero manualmente para evitar errores con los espacios.
		while (numeroIntroducido != numeroAleatorio) {//!= se lee como distinto, si es distinto entrara en el bucle
			contadorDeIntentos++;
			if(numeroAleatorio < numeroIntroducido) {
				System.out.printf("Es menor que ese. Vuelve a intentarlo: [intento %s]",
						+ contadorDeIntentos);
			
			}
			else 
				System.out.printf("Es mayor que ese. Intentalo otra vez:[intento %s]",
					+ contadorDeIntentos);
			numero = scanner.nextLine();
			numeroIntroducido = Integer.parseInt(numero);
		}
		System.out.printf("Enhorabuena. Has acertado en %s %s.", contadorDeIntentos, 
				contadorDeIntentos == 1?"intento":"intentos");
	}

	}		

