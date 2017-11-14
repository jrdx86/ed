package org.institutoserpis.ed;

public class Vector {

	public static void main(String[] args) {
		int [] v = new int [] {9, 15, 7, 12, 6};
		
		for (int index = 0; index<5; index++) 
			System.out.printf("v[%s]=%s", index, v[index]);
		System.out.println();
		
		int value = 6;
		
		int position = indexOf(v, value);
		System.out.println("position="+position);
		int min = min(v);
		System.out.println("el menor es="+min);
	}
		
	public static int indexOf(int[] v, int value ) {
//		
		/*int index = 0;
//		while (index <v.length&& v[index] != value)//OJO con el orden de la condicion
//			index++;*/
//		/*if index == v.length)
//			return index-1*/
//		
//		otra manera:
//		
		/*if (index <v.length) nos dice cuantas cifras hay en el array 
//			return index;nos devuelve la posición encontrada
//		return -1 ;*/
		
//		for (int index=0; index <v.length ; index++)
//			if(v[index]==value)
//				return index;
//		return -1;
		int index=0;
		while (index < v.length && v[index]!= value )
			index++;
		return index < v.length ? index : -1;
	}
		
	
	
		
		public static int min(int[]v) {
		int min =v [0];
	//		for (int index = 1; index<v.length; index++)
//				if (v[index]< min)
//					min=v[index];
				for (int item:v)
					if(item<min);
				
			
		return min;
	}	
		
		public static void selectionSort (int [] v) {
			int selectedIndex=0;
			int indexOfMin= selectedIndex;
			for (int index = selectedIndex + 1; index<v.length; index++) {
				
			}
		}
		
		public static int sum(int[]v) {
			int sum = 0;
//			for (int index=0; index<v.length; index++)
//				sum=sum + v[index];
			for (int item : v)
				sum = sum + item;
			return sum;
			
		}
		
	
		public static int indexOfMin (int[]v) {
			int indexOfMin=0;
			for (int index=1; index<v.length; index++)
				if (v[index]<v[indexOfMin])
					indexOfMin = index;
			
			return indexOfMin;
		}


