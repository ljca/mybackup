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


char buf[5] = "";
gint count = 0;
void add(GtkWidget *w,gpointer l)
{
  count++;
  sprintf(buf,"%d",count);
  gtk_label_set_text(l,buf);
}

void subtraction(GtkWidget *w,gpointer l)
{
  count--;
  sprintf(buf,"%d",count);
  gtk_label_set_text(l,buf);
}

int main(int argc,char **argv)
{
  GtkWidget *window = NULL;
  gtk_init(&argc,&argv);
  window = gtk_window_new(GTK_WINDOW_TOPLEVEL);
  gtk_window_set_title(GTK_WINDOW(window),"A Simple gtk window");
  gtk_window_set_default_size(GTK_WINDOW(window),WID,HI);
  gtk_window_set_position(GTK_WINDOW(window),GTK_WIN_POS_CENTER);
  gtk_window_set_icon(GTK_WINDOW(window),cre_pix("res/ico.ico"));
  GtkWidget *l = NULL;
  GtkWidget *frame = NULL;
  GtkWidget *plus = NULL;
  GtkWidget *min = NULL;
  if(NULL == (frame = gtk_fixed_new())) perror("cre frame error");
  gtk_container_add(GTK_CONTAINER(window),frame);
  if (NULL == (plus = gtk_button_new_with_label("+"))) perror("cre label button error");
  gtk_widget_set_size_request(plus,80,35);
  gtk_fixed_put(GTK_FIXED(frame),plus,50,20);

  if (NULL == (min= gtk_button_new_with_label("-"))) perror("cre label button error");
  gtk_widget_set_size_request(min,80,35);
  gtk_fixed_put(GTK_FIXED(frame),min,50,80);

  if(NULL == (l = gtk_label_new("0"))) perror("cre lable error");
  gtk_fixed_put(GTK_FIXED(frame),l,190,58);
  gtk_widget_show_all(window);
  g_signal_connect(window,"destroy",G_CALLBACK(gtk_main_quit),NULL);
  g_signal_connect(plus,"clicked",G_CALLBACK(add),l);
  g_signal_connect(min,"clicked",G_CALLBACK(subtraction),l);
  gtk_main();
  return 0;
}
