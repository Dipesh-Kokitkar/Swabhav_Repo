package com.techlabs.basics;

public class TestArguments {

	public static void main(String[] args) {
		
		if(args.length==0){
		System.out.println("Thank You!");
		}
		else{
			for(int i=0;i<args.length;i++)
				System.out.print("Hello "+args[i]+" ");
		}
	}

}
