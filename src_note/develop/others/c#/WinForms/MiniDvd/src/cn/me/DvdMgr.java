package cn.me;
import java.util.*;
import java.awt.*;
import java.awt.event.WindowEvent;

import javax.swing.*;
/**
 * @description ��ʼ������Dvd������
 * @author �ӷ���
 *@version 1.0
 */
public class DvdMgr {
	

	/**
	 * ��ʼ��Dvd������
	 */
	public static void initial(){
		System.out.println("---->�鿴Dvd");
		
		DvdSet.name[0] = "�������";
		DvdSet.name[1] = "�������";
		DvdSet.name[2] = "��������";
		DvdSet.state[0] = 0;
		DvdSet.state[1] = 0;
		DvdSet.state[2] = 0;
		
		System.out.println("Dvd����\t���״̬\t�������");
		for(int i =0;i<DvdSet.name.length;i++){
			System.out.println(DvdSet.name[i] + "\t" + DvdSet.state[i]);
		}
	}
	
	/**
	 * ����Dvd
	 */
	public static void addDvd(){
		Scanner in = new Scanner(System.in);
		System.out.println("****����Dvd****");
		System.out.println("������Dvd����:");
		for(int i =0;i<DvdSet.name.length;i++){
			if(DvdSet.name[i] == ""){
				DvdSet.name[i] = in.next();
			}
		}
		
	}
	
	/**
	 * ɾ��Dvd
	 */
	public static void removeDvd(){
		
	}
	
	/**
	 * ���Dvd
	 */
	public static void borrowDvd(){
		
	}
	
	/**
	 * �黹Dvd
	 */
	public static void returnDvd(){
		
	}
	
}
