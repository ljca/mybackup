package cn.me;

import java.util.Scanner;

public class DvdSet {
	
	/**
	 * Dvd��������
	 */
	public static String name[] = new String[100];
	
	/**
	 * ���״̬
	 */
	public static int[] state = new int[50];
	
	/**
	 * �������
	 */
	public static String data[] = new String[50];
	
	/**
	 * �г��˵�
	 */
	public static int startMenu(){
		System.out.print("��ӭʹ������DVD��������\n*************************************\n");
		System.out.println("1.����DVD");
		System.out.println("2.�鿴DVD");
		System.out.println("3.ɾ��DVD");
		System.out.println("4.���DVD");
		System.out.println("5.�黹DVD");
		System.out.println("6.�˳�");

		System.out.print("��ѡ��");
		Scanner in = new Scanner(System.in);
		int x = in.nextInt();
		return x;
	}
	
	/**
	 *�л��˵�
	 */
	public static void returnMenu(){
		switch(startMenu()){
		case 1:
			DvdMgr.addDvd();
			break;
			
		case 2:
			DvdMgr.initial();
			break;

		case 3:
			DvdMgr.removeDvd();
			break;
			
		case 4:
			DvdMgr.borrowDvd();
			break;
		case 5:
			DvdMgr.returnDvd();
			break;
		case 6:
			System.out.print("ллʹ�ã�");
			break;
			
		default:
			System.out.print("�����������������룡");
			break;
		}
	}
	
	
}
