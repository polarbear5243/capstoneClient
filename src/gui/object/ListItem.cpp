#include"gui/object/ListItem.h"

void ListItem::selected_cb(void *data, Evas_Object *obj, void *event_info){
	((ListItem *)data)->selected();
}

ListItem::ListItem(string title){
	mTitle = title;
}

void ListItem::selected(){

}
