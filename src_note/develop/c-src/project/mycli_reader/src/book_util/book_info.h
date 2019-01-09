/*
 * =====================================================================================
 *
 *       Filename:  book_info.h
 *
 *    Description:  
 *
 *        Version:  1.0
 *        Created:  2017年06月15日 15时21分30秒
 *       Revision:  none
 *       Compiler:  gcc
 *
 *         Author:  YOUR NAME (), 
 *   Organization:  
 *
 * =====================================================================================
 */
/*
 * 小说信息
 * book_path[] 小说源文件路径
 * book_encode[] 小说采用的编码格式
 */
typedef struct book_info{
  char book_path[];
  char book_name[255];
  char book_auth[];
  char book_size[]; 
  char book_encode[]; 
}book_info;

