#include"gui/object/List.h"

void List::list_selected_cb(void *data, Evas_Object *obj, void *event_info){
	Elm_Object_Item *it = (Elm_Object_Item*)event_info;
	elm_list_item_selected_set(it, EINA_FALSE);
}

List::List(UILayout parent){
	mContent = elm_list_add(parent.getContent());
	elm_list_go(mContent);

	elm_list_mode_set(mContent, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(mContent, "selected", list_selected_cb, this);
}

void List::addItem(ListItem * item){
	elm_list_item_append(mContent,item->mTitle.c_str(),NULL,NULL,ListItem::selected_cb,item);
}
