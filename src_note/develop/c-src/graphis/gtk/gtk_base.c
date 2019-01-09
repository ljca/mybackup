#include <gtk-2.0/gtk/gtk.h>

void btn_1(GtkWidget *w,gpointer data)
{
	g_print("hello,this is %s\n",(gchar *)data);
}

int main(int argc,char **argv)
{
	GtkWidget *window;
	gtk_init(&argc,&argv);
	if(NULL == (window=gtk_window_new(GTK_WINDOW_TOPLEVEL))){
		g_print("create new window error\n");
		return -1;
	}
	gtk_container_set_border_width(GTK_CONTAINER(window),10);
	gtk_window_set_title(GTK_WINDOW(window),"Hbox Test...");
	gtk_window_set_default_size(GTK_WINDOW(window),500,300);

	/* hbox */
	GtkWidget *hbox;
	if(NULL==(hbox = gtk_hbox_new(FALSE,0))){
		return -1;
	}
	gtk_container_add(GTK_CONTAINER(window),hbox);
	g_signal_connect(G_OBJECT(window),"delete_event",G_CALLBACK(gtk_main_quit),NULL);

/* button 1 */
	GtkWidget *btn;
	btn = gtk_button_new_with_label("Add");
	g_signal_connect(G_OBJECT(btn),"clicked",G_CALLBACK(btn_1),"btn1");
	gtk_box_pack_start(GTK_BOX(hbox),btn,TRUE,TRUE,0);
	gtk_widget_show(btn);
/* button 2 */
	//GtkWidget *btn2;
	btn = gtk_button_new_with_label("Subsraction");
	gtk_box_pack_start(GTK_BOX(hbox),btn,TRUE,TRUE,0);
	g_signal_connect(G_OBJECT(btn),"clicked",G_CALLBACK(btn_1),"btn2");
	gtk_widget_show(btn);
	gtk_widget_show(hbox);
	gtk_widget_show(window);
	gtk_main();
	return 0;
}
