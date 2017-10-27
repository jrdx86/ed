package org.institutoserpis.ed;

public class Vector {

	public static void main(String[] args) {
		int [] v = new int [] {9, 15, 7, 12, 6};
		
		for (int index = 0; index<5; index++) 
			System.out.printf("v[%s]=%s", index, v[index]);
		System.out.println();
		
		int value = 33;
		
		int position = indexOf(v, value);
		System.out.println("position="+position);
		
	}
		
		public static int indexOf(int[] v, int value ) {
			int index = 0;
			while (index <v.length && v[index] != value)//OJO con el orden de la condicion
				index++;
			/*if index == v.length)
				return index-1*/
			if (index <v.length)
				return index;//nos devuelve la posición encontrada
			return -1 ;
		}
			
	}
	


