package cn.me;
import java.util.*;
import java.awt.*;
import java.awt.event.WindowEvent;

import javax.swing.*;
/**
 * @description 初始化迷你Dvd管理器
 * @author 子非鱼
 *@version 1.0
 */
public class DvdMgr {
	

	/**
	 * 初始化Dvd管理器
	 */
	public static void initial(){
		System.out.println("---->查看Dvd");
		
		DvdSet.name[0] = "罗马假日";
		DvdSet.name[1] = "风声鹤唳";
		DvdSet.name[2] = "浪漫满屋";
		DvdSet.state[0] = 0;
		DvdSet.state[1] = 0;
		DvdSet.state[2] = 0;
		
		System.out.println("Dvd名称\t借出状态\t借出日期");
		for(int i =0;i<DvdSet.name.length;i++){
			System.out.println(DvdSet.name[i] + "\t" + DvdSet.state[i]);
		}
	}
	
	/**
	 * 新增Dvd
	 */
	public static void addDvd(){
		Scanner in = new Scanner(System.in);
		System.out.println("****新增Dvd****");
		System.out.println("请输入Dvd名称:");
		for(int i =0;i<DvdSet.name.length;i++){
			if(DvdSet.name[i] == ""){
				DvdSet.name[i] = in.next();
			}
		}
		
	}
	
	/**
	 * 删除Dvd
	 */
	public static void removeDvd(){
		
	}
	
	/**
	 * 借出Dvd
	 */
	public static void borrowDvd(){
		
	}
	
	/**
	 * 归还Dvd
	 */
	public static void returnDvd(){
		
	}
	
}
