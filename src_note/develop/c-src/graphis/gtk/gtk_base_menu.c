#include <stdio.h>
#include <stdlib.h>
#include <gtk-2.0/gtk/gtk.h>

int main(int argc,char **argv)
{
  GtkWidget *window = NULL;
  GtkWidget *vbox = NULL;
  GtkWidget *menubar = NULL;
  GtkWidget *filemenu = NULL;
  GtkWidget *file = NULL;
  GtkWidget *quit = NULL;
  gtk_init(&argc,&argv);
  if (NULL == (window = gtk_window_new(GTK_WINDOW_TOPLEVEL))){
    perror("cre window error");
    exit(-1);
  }
  gtk_window_set_position(GTK_WINDOW(window),GTK_WIN_POS_CENTER);
  gtk_window_set_default_size(GTK_WINDOW(window),800,500);
  gtk_window_set_title(GTK_WINDOW(window),"GTK MENU test.....");
  vbox = gtk_vbox_new(FALSE,0);
  gtk_container_add(GTK_CONTAINER(window),vbox);
  //gtk_container_add(GTK_CONTAINER(window),menubar);
  menubar = gtk_menu_bar_new();
  filemenu = gtk_menu_new();
  file = gtk_menu_item_new_with_label("File");
  quit = gtk_menu_item_new_with_label("Quit");
  gtk_menu_item_set_submenu(GTK_MENU_ITEM(file),filemenu);
  gtk_menu_shell_append(GTK_MENU_SHELL(filemenu),quit);
  gtk_menu_shell_append(GTK_MENU_SHELL(menubar),file);
  gtk_box_pack_start(GTK_BOX(vbox),menubar,FALSE,FALSE,3);
  g_signal_connect(window,"destroy",G_CALLBACK(gtk_main_quit),NULL);
  //g_signal_connect(quit,"activate",G_CALLBACK(gtk_main_quit),quit);
  g_signal_connect(quit,"activate",G_CALLBACK(gtk_main_quit),NULL);
  gtk_widget_show_all(window);
  gtk_main();
  return 0;
}
