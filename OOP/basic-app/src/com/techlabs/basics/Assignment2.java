package com.techlabs.basics;

public class Assignment2 {

	public static void main(String[] args) {
		String url=args[0];
		
		String[] s1=url.split("\\.|\\?");
		
		for(int i=0;i<s1.length-1;i++){
			if(!s1[i].equals("www")&& !s1[i].equals("com"))
			System.out.print("Name of company="+s1[i]+"\n");
		}
		String s2=s1[s1.length-1];
		String[] split2=s2.split("\\&");
		for(int i=0;i<split2.length;i++){
			System.out.print(split2[i]+"\n");
		}

	}

}

