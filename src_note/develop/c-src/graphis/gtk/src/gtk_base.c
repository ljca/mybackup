#include <stdio.h>
#include <gtk-2.0/gtk/gtk.h>
#include "include/gtk_base.h"

GdkPixbuf *cre_pix(const gchar *filename)
{
  GdkPixbuf *pix_buf = NULL;
  GError *error = NULL;
  if(NULL == (pix_buf = gdk_pixbuf_new_from_file(filename,&error))){
    fprintf(stderr,"%s\n",error->message);
    g_error_free(error);
  }
  return pix_buf;
}

int main(int argc,char **argv)
{
  GtkWidget *window;
  gtk_init(&argc,&argv);
  window = gtk_window_new(GTK_WINDOW_TOPLEVEL);
  gtk_window_set_title(GTK_WINDOW(window),"A Simple gtk window");
  gtk_window_set_default_size(GTK_WINDOW(window),WID,HI);
  gtk_window_set_position(GTK_WINDOW(window),GTK_WIN_POS_CENTER);
  gtk_window_set_icon(GTK_WINDOW(window),cre_pix("res/ico.ico"));
  gtk_widget_show(window);
  g_signal_connect_swapped(G_OBJECT(window),"destroy",G_CALLBACK(gtk_main_quit),NULL);
  gtk_main();
  return 0;
}
