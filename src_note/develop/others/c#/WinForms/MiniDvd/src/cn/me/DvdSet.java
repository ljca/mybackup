package cn.me;

import java.util.Scanner;

public class DvdSet {
	
	/**
	 * Dvd名称数组
	 */
	public static String name[] = new String[100];
	
	/**
	 * 借出状态
	 */
	public static int[] state = new int[50];
	
	/**
	 * 借出日期
	 */
	public static String data[] = new String[50];
	
	/**
	 * 列出菜单
	 */
	public static int startMenu(){
		System.out.print("欢迎使用迷你DVD管理器！\n*************************************\n");
		System.out.println("1.新增DVD");
		System.out.println("2.查看DVD");
		System.out.println("3.删除DVD");
		System.out.println("4.借出DVD");
		System.out.println("5.归还DVD");
		System.out.println("6.退出");

		System.out.print("请选择：");
		Scanner in = new Scanner(System.in);
		int x = in.nextInt();
		return x;
	}
	
	/**
	 *切换菜单
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
			System.out.print("谢谢使用！");
			break;
			
		default:
			System.out.print("输入有误！请重新输入！");
			break;
		}
	}
	
	
}
