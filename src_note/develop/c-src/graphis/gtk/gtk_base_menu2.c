#include <gtk-2.0/gtk/gtk.h>

int main(int argc,char **argv)
{
	GtkWidget *window;
	gtk_init(&argc,&argv);
	if(NULL == (window = gtk_window_new(GTK_WINDOW_TOPLEVEL))){
		g_print("create new window failed\n");
		return -1;
	}
	gtk_window_set_title(GTK_WINDOW(window),"        ");
	gtk_window_set_default_size(GTK_WINDOW(window),1600,600);
	gtk_window_set_position(GTK_WINDOW(window),GTK_WIN_POS_CENTER);
	g_signal_connect(G_OBJECT(window),"delete_event",G_CALLBACK(gtk_main_quit),NULL);
	GtkWidget *mbar,*f_menu;
	GtkWidget *menu_it;
	gtk_widget_show(window);
	gtk_main();
	return 0;
}
