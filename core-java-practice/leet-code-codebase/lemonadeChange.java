package com.leetcode;
import java.util.*;
//Leetcode problem number 860

public class lemonadeChange {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		
		int len = sc.nextInt();
		
		int[] bills = new int[len];
		
		for(int i = 0; i < len;i++) {
			bills[i] = sc.nextInt(); //Taking the bill amounts of each customer
		}
		
		boolean answer = lemCh(bills);
		
		System.out.println(answer);
	}
	
	 public static boolean lemCh(int[] bills) {
	        int five = 0,ten = 0,twenty = 0;
	        for(int i = 0;i < bills.length;i++){
	            if(bills[i] == 5) five++;
	            else if(bills[i] == 10 && five > 0){
	                ten++;
	                five--;
	            }
	            
	            else if(bills[i] == 20 ){
	                if(ten > 0 && five > 0){
	                    ten--;
	                    five--;
	                }
	                
	                
	                else if(ten == 0 && five > 2){
	                    five = five - 3;
	                }
	                
	                else{
	                    return false;
	                }
	            }
	            
	            else {
	                return false;
	            }
	        }
	        
	        return true;
	    }
}
