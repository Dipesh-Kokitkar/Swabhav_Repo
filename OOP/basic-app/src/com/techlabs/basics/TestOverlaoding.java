package com.techlabs.basics;

public class TestOverlaoding {
	public static void main(String arg[]) {
		char[] x={'a','b','c'};
		System.err.println("String");
		System.err.println(true);
		System.err.println(86.60f);
		System.err.println(84);
		System.err.println('D');
		System.err.println(arg);
		System.err.println(10.00);
		System.err.println(x);
		System.err.println();
		System.err.println(100l);
		
		System.out.println("Overlaoded Methods:");
		printThis(true);
		printThis(100d);
		printThis(86.60f);
		printThis(84);
		printThis("String");
	}
	public static void printThis(String str){
		System.out.println(str);
		System.out.println("Overlaod 1");
	}
	
	public static void printThis(int x){
		System.out.println(x);
		System.out.println("Overlaod2");
	}
	public static void printThis(float x){
		System.out.println(x);
		System.out.println("Overlaod3");
	}
	public static void printThis(double x){
		System.out.println(x);
		System.out.println("Overlaod4");
	}
	public static void printThis(boolean x){
		System.out.println(x);
		System.out.println("Overlaod5");
	}
}
